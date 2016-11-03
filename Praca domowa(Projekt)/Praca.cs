using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Praca_domowa_Projekt_
{
    [Serializable]
    public class Praca
    {
        public string Przedmiot { get; set; }
        public string Opis { get; set; }
        /*
        public Praca(string _przedmiot, string _opis)
        {
            Przedmiot = _przedmiot;
            Opis = _opis;
        }
        public Praca()
        {
            Przedmiot = "Błąd";
            Opis = "WTF";
        }*/
    }
}
