using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOO.Exceptions
{
    public class MedicDoesNotExistException : Exception
    {
        public MedicDoesNotExistException() : base("Medic does not exist!")
        {
        }

        public MedicDoesNotExistException(string s) : base(s) { }

        public MedicDoesNotExistException(string s, Exception e)
        {
            throw new MedicDoesNotExistException(e.Message + " - " + s);
        }
    }
}
