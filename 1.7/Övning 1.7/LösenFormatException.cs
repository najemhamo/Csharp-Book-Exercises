using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_1._7
{
    class LösenFormatException : Exception
    {
        // medelandet om fel lösenord
        string message = "Lösenordet måste innehålla både bokstäver och siffror";

        public override string ToString()
        {
            return message;
        }
    }
}
