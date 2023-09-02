using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._4
{
    class Cirkel : Figur, IArea
    {
     
        public Cirkel(double b, double h): base(b, h)
        {

        }
        public double RäknaArea()
        {
            return Math.Pow(bredd / 2,2) * Math.PI;
        }

        public override string ToString()
        {
            return "Cirkel: " + bredd + "x" + höjd;
        }
    }
}
