using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praca_domowa_Projekt_
{
    public partial class Form2 : Form
    {
        public static List<Subject> subjectList = new List<Subject>();
        public Form2()
        {
            InitializeComponent();
            ComboxBinding();
        }
             
        public void Form2_Load(object sender, EventArgs e)
        {   
            DeleteEnable(false);
        }

        public void SaveBtn_Click(object sender, EventArgs e)
        {
            Homework p = new Homework
            {
                Subject = this.subjectListCmBox.Text,
                Desc = this.homeworkDescTxtBox.Text
            };

            string name = p.Subject + p.Desc;
            SerializeClass s = new SerializeClass();
            s.SerializeObject(p, "Homework_"+ Guid.NewGuid() + ".xml");
            Form2.ActiveForm.Close();            
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
        }

        private void AddSubjectBtn_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide();
            new Form4().ShowDialog();
            ComboxBinding();
            new Form2().ShowDialog();
            DeleteEnable(true);
        }

        public void ComboxBinding()
        {
            SerializeClass s = new SerializeClass();
            var newSubject = s.DeSerializeObject<List<Subject>>("Subject_Lst.xml");
            subjectList = newSubject;
            BindingSource bindingsource1 = new BindingSource
            {
                DataSource = subjectList
            };

            subjectListCmBox.DataSource = bindingsource1.DataSource;
            subjectListCmBox.DisplayMember = "SubjectName";
            subjectListCmBox.Refresh();
        }

        private void DeleteSubjectBtn_Click(object sender, EventArgs e)
        {
            var currentName = subjectListCmBox.Text;
            var itemToRemove = subjectList.Single(r => r.subjectName == currentName);
            subjectList.Remove(itemToRemove);
            var S_L = subjectList;
            SerializeClass s = new SerializeClass();
            s.SerializeObject(S_L, "Subject_Lst.xml");
            ComboxBinding();
            DeleteEnable(false);
        }

        private void DeleteEnable (bool enable)
        {
            if (subjectList.Count == 0)
                deleteSubjectBtn.Enabled = enable;
        }
    }
}
