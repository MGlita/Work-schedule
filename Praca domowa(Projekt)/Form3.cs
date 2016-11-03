using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Praca_domowa_Projekt_
{
    public partial class Form3 : Form
    {
        int currentWork;
        DirectoryInfo dir;
        List<FileInfo> files = new List<FileInfo>();
        SerializeClass s = new SerializeClass();
        public Form3()
        {
            InitializeComponent();
            currentWork = 0;
            var path = Path.GetDirectoryName(Application.ExecutablePath);
            dir = new DirectoryInfo(Path.GetDirectoryName(Application.ExecutablePath));
            files.AddRange(dir.GetFiles("Praca_*.xml"));

            if (files.Count > 0)
            {
                button3.Enabled = true;
                label1.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
            }
            if (files.Count == 0)
            {
                button3.Enabled = false;
                label1.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if(files.Count!=0)
            deserialize();                      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentWork++;
            if (currentWork >= files.Count)
                currentWork = 0;
            deserialize();           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentWork--;
            if (currentWork < 0)
                currentWork = files.Count - 1;
            deserialize();        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            files[currentWork].Delete();
            files.Remove(files[currentWork]);
            currentWork--;
            if (currentWork < 0 && files.Count != 0)
                currentWork = files.Count - 1;
            if (files.Count != 0)
            {
                deserialize();
            }
            if (files.Count == 0)
            {
                button3.Enabled = false;
                button1.Visible = false;
                button2.Visible = false;
                label1.Visible = true;
                textBox1.Text = "";
            }
        }
        private void deserialize()
        {
            string fileName = files[currentWork].Name;
            var des = s.DeSerializeObject<Praca>(fileName);
            var data = des.Przedmiot + "\r\n" + des.Opis;
            this.textBox1.Text = data;
        }
    }
}
