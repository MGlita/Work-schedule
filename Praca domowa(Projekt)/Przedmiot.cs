using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praca_domowa_Projekt_
{
    [Serializable]
    public class Przedmiot
    {
        //public int Id { get; set; }
        public string NazwaPrzedmiotu { get; set; }
        public Przedmiot(string _nazwaPrzedmiotu)
        {
            //Id = _id;
            NazwaPrzedmiotu = _nazwaPrzedmiotu;
        }
        public Przedmiot() { }
    }
}
