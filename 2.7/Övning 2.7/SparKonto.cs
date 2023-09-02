using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._7
{
  
    class SparKonto : BankKonto
    {
        public SparKonto(string p, double b, double r) : base(p, b, r)
        {

        }

       
        public override bool Uttag(double belopp)
        {
            double kvar = behållning - belopp;
            bool yesORno = true;

            if (kvar < 0)
            {
                yesORno = false;
            }

            return yesORno;
        }

   
        public override double BeräknaRänta()
        {
            double ränta = behållning * (ränteSats / 100);



            return ränta;

        }
        public override string ToString()
        {
            return "Sparkonto " + personNummer + ": " + behållning;
        }
    }
}
