using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._2
{

    class Säljare : Anställd
    {
        private double provition,försäljning;

        public Säljare(string n,double p,double f) : base(n)
        {
            provition = p;
            försäljning = f;
        }


        public override double BeräknaLön()
        {
            return försäljning * (provition / 100);
        }

        public override string ToString()
        {
            return Namn() + " (Säljare)";
        }

    }
}
