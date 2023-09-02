using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._4
{
 
    class Triangel : Figur , IArea
    {

        public Triangel(double b, double h): base(b, h)
        {

        }

     
        public double RäknaArea()
        {
            return bredd * höjd / 2;
        }

        public override string ToString()
        {
            return "Triangel: " + bredd + "x" + höjd;
        }
    }
}
