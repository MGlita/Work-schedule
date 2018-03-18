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
    public class Homework
    {
        public string Subject { get; set; }
        public string Desc { get; set; }
        
    }
}
