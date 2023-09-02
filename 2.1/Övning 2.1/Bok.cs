using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._1
{
    class Bok : Media
    {
       
        int sidor;
        public Bok(int sidor, string titel) : base(titel)
        {
            this.sidor = sidor;
        }

        public override string ToString()
        {
            return "(Bok) " + titel + ": " + sidor + " sidor ";
        }

    }
}
