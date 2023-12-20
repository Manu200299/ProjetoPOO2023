using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOO.Exceptions
{
    public class AlreadyExists : Exception
    {
        public AlreadyExists() : base("That item already exists!") { }

        public AlreadyExists(string s) : base(s) { }

        public AlreadyExists(string s, Exception e)
        {
            throw new EmptyMedicList(e.Message + " - " + s);
        }
    }
}
