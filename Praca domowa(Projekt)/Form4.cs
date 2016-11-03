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

        private void button1_Click(object sender, EventArgs e)
        {
            var value = textBox1.Text;
            Przedmiot p = new Przedmiot();
            p.NazwaPrzedmiotu = value;
            Form2.listaPrzedmiotow.Add(p);

            var L_P = Form2.listaPrzedmiotow;
            SerializeClass s = new SerializeClass();
            s.SerializeObject<List<Przedmiot>>(L_P, "Lista_P.xml");

            ActiveForm.Close();   
            
        }
        
    }
}
