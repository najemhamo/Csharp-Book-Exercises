using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._4
{
  
    class Figur
    {
        protected double bredd, höjd;

        public Figur(double b, double h)
        {
            bredd = b;
            höjd = h;
        }

    }
  
    interface IArea{
     double RäknaArea();
    }
}
