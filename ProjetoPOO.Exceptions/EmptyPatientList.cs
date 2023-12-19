using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOO.Exceptions
{
    public class EmptyPatientList : Exception
    {
        public EmptyPatientList() : base("The medic list is empty!") { }

        public EmptyPatientList(string s) : base(s) { }

        public EmptyPatientList(string s, Exception e)
        {
            throw new EmptyPatientList(e.Message + " - " + s);
        }
    }
}
