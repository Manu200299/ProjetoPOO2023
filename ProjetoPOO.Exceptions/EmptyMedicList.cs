using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOO.Exceptions
{
    public class EmptyMedicList : Exception
    {
        public EmptyMedicList() : base("The medic list is empty!") { }

        public EmptyMedicList(string s) : base(s) { }

        public EmptyMedicList(string s, Exception e)
        {
            throw new EmptyMedicList(e.Message + " - " + s);
        }
    }
}
