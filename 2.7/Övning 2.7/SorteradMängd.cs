using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._7
{
    class SorteradMängd<T> : Samling<T> where T : IComparable<T>
    {
        public SorteradMängd() : base()
        {

        }

        public void Sortera()
        {
          

            int i, j;
            int n = antal; if (n < 2) return;
            T a;

          
            for(j = 1; j < n; j++)
            {
                a = lista[j];
                i = j - 1;

               
                while(i >= 0 && lista[i].CompareTo(a) > 0)
                {
                    lista[i + 1] = lista[i];
                    i--;
                }

            
                lista[i + 1] = a;
            }

        }

        public override void LäggTill(T e)
        {
            
            if (!Har(e))
            {

           
                if (antal + 1 > längd) Expendera(1 + buffert);

                lista[antal] = e;
                antal += 1;
                Sortera();
            }
            else
            {
                throw new FinnsException(e);
            }
        }
        public override void LäggTill(Samling<T> samling)
        {
            int size = samling.Antal();

      
            for (int i = 0; i < size; i++)
            {
                try
                {
                    LäggTill(samling.ElementFrån(i));
                }
                catch (FinnsException f)
                {
                    Console.WriteLine(f.Message);
                }
            }

            Sortera();
        }
    }
}
