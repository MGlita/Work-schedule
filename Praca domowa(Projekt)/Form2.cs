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
        public static List<Przedmiot> listaPrzedmiotow = new List<Przedmiot>();
        public Form2()
        {
            InitializeComponent();
            comboxBinding();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
        }
       
        public void Form2_Load(object sender, EventArgs e)
        {
            //comboxBinding();    
            if (listaPrzedmiotow.Count == 0)
                button4.Enabled = false;                    
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Praca p = new Praca();
            p.Przedmiot = this.comboBox1.Text;
            p.Opis = this.textBox1.Text;
            
            string name = p.Przedmiot + p.Opis;
            SerializeClass s = new SerializeClass();
            s.SerializeObject(p, "Praca_"+ Guid.NewGuid() + ".xml");
            Form2.ActiveForm.Close();            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide();
            new Form4().ShowDialog();
            comboxBinding();
            new Form2().ShowDialog();
            if (listaPrzedmiotow.Count > 0)
                button4.Enabled = true;
        }

        public void comboxBinding()
        {
            SerializeClass s = new SerializeClass();
            var nowePrzed = s.DeSerializeObject<List<Przedmiot>>("Lista_P.xml");
            listaPrzedmiotow = nowePrzed;
            BindingSource bindingsource1 = new BindingSource();
            bindingsource1.DataSource = listaPrzedmiotow;
            
            comboBox1.DataSource = bindingsource1.DataSource;
            comboBox1.DisplayMember = "NazwaPrzedmiotu";
            comboBox1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var currentName = comboBox1.Text;
            var itemToRemove = listaPrzedmiotow.Single(r => r.NazwaPrzedmiotu == currentName);
            listaPrzedmiotow.Remove(itemToRemove);
            var L_P = listaPrzedmiotow;
            SerializeClass s = new SerializeClass();
            s.SerializeObject(L_P, "Lista_P.xml");
            comboxBinding();
            if (listaPrzedmiotow.Count == 0)
                button4.Enabled = false;
        }
    }
}
