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
            ChangingUrlVisibility(false);
            var path = Path.GetDirectoryName(Application.ExecutablePath);
            bool exist = File.Exists(path + @"\URL.xml");
            if (exist == true)
            {
                webName = s.DeSerializeObject<string>("URL.xml");
                webBrowser1.Navigate(webName);
            }
            else
            {
                ChangingUrlVisibility(true);
            }
            //string url = "http://planzajec.uek.krakow.pl/index.php?typ=G&id=84731&okres=1";
        }

        private void AddHomework_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void MyHomework_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }

        private void ChangeUrl_Click(object sender, EventArgs e)
        {
            ChangingUrlVisibility(true);
        }

        private void PathBtn_Click(object sender, EventArgs e)
        {
            webName = urlName.Text;
            webBrowser1.Navigate(webName);
            s.SerializeObject(webName, "URL.xml");
            ChangingUrlVisibility(false);
        }
        private void ChangingUrlVisibility(bool visible)
        {
            if (visible == true)
            {
                webBrowser1.Visible = false;
                urlName.Visible = true;
                pathBtn.Visible = true;
                changeUrl.Visible = false;
            }
            else
            {
                webBrowser1.Visible = true;
                urlName.Visible = false;
                pathBtn.Visible = false;
                changeUrl.Visible = true;
            }
        }
    }
}
