using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_1._7
{
    class EpostAdressFormatException : Exception
    {
        // medelandet om fel epost address
        string message = "Din epost är fel, Försök igen";
        public override string ToString()
        {
            return message;
        }
    }
}
