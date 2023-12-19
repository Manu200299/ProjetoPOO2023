using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOO.Exceptions
{
    public class PatientDoesNotExistException : Exception
    {
        public PatientDoesNotExistException() : base("Patient does not exist!")
        {

        }

        public PatientDoesNotExistException(string s) : base(s) { }

        public PatientDoesNotExistException(string s, Exception e)
        {
            throw new PatientDoesNotExistException(e.Message + " - " + s);
        }
    }
}
