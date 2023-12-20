using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOO.Exceptions
{
    public class CantInsertMedic : Exception
    {
        public CantInsertMedic() : base("It was not possible to insert a medic on the list!") { }

        public CantInsertMedic(string s) : base(s) { }

        public CantInsertMedic(string s, Exception e)
        {
            throw new EmptyMedicList(e.Message + " - " + s);
        }
    }
}
