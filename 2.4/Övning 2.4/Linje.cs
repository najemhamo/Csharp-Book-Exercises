using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._4
{
  
    class Linje : Figur
    {
        public Linje(double b, double h): base(b, h)
        {

        }

        public override string ToString()
        {
            return "Linje: " + bredd + "x" + höjd;
        }
    }
}
