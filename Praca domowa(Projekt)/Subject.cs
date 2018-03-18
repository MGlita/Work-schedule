using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praca_domowa_Projekt_
{
    [Serializable]
    public class Subject
    {
        public string subjectName { get; set; }
        public Subject(string _subjectName)
        {
            subjectName = _subjectName;
        }
        public Subject() { }
    }
}
