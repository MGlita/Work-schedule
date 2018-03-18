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
            GetHomework();

            if (files.Count > 0)
            {               
                allDoneLbl.Visible = false;
                ButtonsVisibility(true);
            }
            if (files.Count == 0)
            {                
                allDoneLbl.Visible = true;
                ButtonsVisibility(false);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if(files.Count!=0)
            Deserialize();                      
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            currentWork++;
            if (currentWork >= files.Count)
                currentWork = 0;
            Deserialize();           
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            currentWork--;
            if (currentWork < 0)
                currentWork = files.Count - 1;
            Deserialize();        
        }

        private void DoneBtn_Click(object sender, EventArgs e)
        {
            files[currentWork].Delete();
            files.Remove(files[currentWork]);
            currentWork--;
            if (currentWork < 0 && files.Count != 0)
                currentWork = files.Count - 1;
            if (files.Count != 0)
            {
                Deserialize();
            }
            if (files.Count == 0)
            {
                ButtonsVisibility(false);
                allDoneLbl.Visible = true;
                hworkDescTxtBox.Text = "";
            }
        }
        private void Deserialize()
        {
            string fileName = files[currentWork].Name;
            var des = s.DeSerializeObject<Homework>(fileName);
            var data = des.Subject + "\r\n" + des.Desc;
            this.hworkDescTxtBox.Text = data;
        }
        private void ButtonsVisibility(bool enabled)
        {
            doneBtn.Enabled = enabled;
            nextBtn.Visible = enabled;
            previousBtn.Visible = enabled;
        }
        private void GetHomework()
        {
            var path = Path.GetDirectoryName(Application.ExecutablePath);
            dir = new DirectoryInfo(Path.GetDirectoryName(Application.ExecutablePath));
            files.AddRange(dir.GetFiles("Homework_*.xml"));
        }
    }
}
