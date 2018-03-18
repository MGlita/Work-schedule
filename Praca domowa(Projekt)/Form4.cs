using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praca_domowa_Projekt_
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var value = subjectTxtBox.Text;
            Subject p = new Subject();
            p.subjectName = value;
            Form2.subjectList.Add(p);

            var S_L = Form2.subjectList;
            SerializeClass s = new SerializeClass();
            s.SerializeObject(S_L, "Subject_Lst.xml");

            ActiveForm.Close();   
            
        }
        
    }
}
