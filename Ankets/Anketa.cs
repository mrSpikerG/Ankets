using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ankets
{
    class Anketa
    {

        //Это конечно не ФИО но смысл остается тот же 
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public Anketa(string name,DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
        }
        public override string ToString()
        {
            return String.Format("{0} {1}", Name, Birthday.ToShortDateString());// Birthday.ToShortDateString()) ;
        }

    }
}
