using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOO.Exceptions
{
    public class InputIsNull : Exception
    {
        public InputIsNull() : base("NULL input!") { }

        public InputIsNull(string s) : base(s) { }

        public InputIsNull(string s, Exception e)
        {
            throw new InputIsNull(e.Message + " - " + s);
        }
    }
}
