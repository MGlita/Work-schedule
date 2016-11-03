using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praca_domowa_Projekt_
{
    public partial class Form1 : Form
    {
        string webName;
        SerializeClass s = new SerializeClass();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            button4.Visible = false;
            var path = Path.GetDirectoryName(Application.ExecutablePath);
            bool exist = File.Exists(path + @"\URL.xml");
            if (exist == true)
            {
                webName = s.DeSerializeObject<string>("URL.xml");
                webBrowser1.Navigate(webName);
            }
            else
            {
                webBrowser1.Visible = false;
                textBox1.Visible = true;
                button4.Visible = true;
                button3.Visible = false;
            }
            string n = "http://planzajec.uek.krakow.pl/index.php?typ=G&id=84731&okres=1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = false;
            textBox1.Visible = true;
            button4.Visible = true;
            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webName = textBox1.Text;
            webBrowser1.Navigate(webName);
            s.SerializeObject(webName, "URL.xml");
            webBrowser1.Visible = true;
            textBox1.Visible = false;
            button4.Visible = false;
            button3.Visible = true;

        }
    }
}
