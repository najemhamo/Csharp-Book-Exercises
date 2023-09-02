using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._7
{
    class FinnsException : Exception
    {

        object sif;
        public FinnsException(object s)
        {
            sif = s;
        }
        public override string Message
        {
            get
            {
                return sif + " Finns redan i listan";
            }
        }
    }
}
