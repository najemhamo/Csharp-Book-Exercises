using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._7
{

    abstract class BankKonto: IComparable<BankKonto>
    {
    
        protected string personNummer;
        protected double behållning, ränteSats;

        public BankKonto(string p, double b, double r)
        {
            personNummer = p;
            behållning = b;
            ränteSats = r;
        }

   
        public double Behållning()
        {
            return behållning;
        }

        
        public void Insättning(double belopp)
        {
            behållning = behållning + belopp;
        }

       
        public abstract bool Uttag(double belopp);

        public abstract double BeräknaRänta();

        public int CompareTo(BankKonto bank)
        {
            return personNummer.CompareTo(bank.personNummer);
        }

       
    }
}
