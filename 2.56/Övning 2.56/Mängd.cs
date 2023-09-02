using Övning_2._56;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._56
{
    class Mängd<T>: Samling<T>
    {
        public Mängd(): base()
        {

        }

        public override void LäggTill(T e)
        {
            
            if (!Har(e))
            {

             
                if (antal + 1 > längd) Expendera(1 + buffert);

                lista[antal] = e;
                antal += 1;
            }else
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
                }catch(FinnsException f)
                {
                    Console.WriteLine(f.Message);
                }
            }
        }
    }
}
