using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._3
{

    class LåneKonto:BankKonto
    {

        double kreditGräns;

        public LåneKonto(string p, double b, double r, double k):base(p,b,r)
        {
            kreditGräns = k;
        }

 
        public override bool Uttag(double belopp)
        {
            double kvar = behållning - belopp;

            bool yesORno = true;

            if (kvar < kreditGräns)
            {
                yesORno = false;
            }

            return yesORno;
        }

    
        public override double BeräknaRänta()
        {
            double ränta = behållning * (ränteSats / 100);

            if(ränta > 0)
            {
                ränta *= -1;
            }

            return ränta;
        }

        public override string ToString()
        {
            return "Lånekonto " + personNummer + ": " + behållning;  
        }
    }
}
