using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._7
{
    class Samling<T>
    {
        protected int buffert;      
        protected T[] lista;        

        protected int längd;       
        protected int antal;        

        public Samling()
        {
            buffert = 30;
            antal = 0;
            längd = 30;
            lista = new T[längd];
        }

        protected void Expendera(int storlek)
        {
            if (storlek < 1) return;

        
            T[] temp = new T[längd + storlek];

            
            for (int i = 0; i < antal; i++)
            {
                temp[i] = lista[i];
            }

            lista = temp;

            längd += storlek;
        }

        protected void Reducera()
        {
            
            T[] temp = new T[antal];

            for (int i = 0; i < antal; i++)
            {
                temp[i] = lista[i];
            }

            lista = temp;
            längd = antal;
        }

        public virtual void LäggTill(T e)
        {
          
            if (antal + 1 > längd) Expendera(1 + buffert);

            lista[antal] = e;
            antal += 1;
        }

        public T TaBort(int index)
        {
            T temp = lista[index];


            
            for (int i = index; i < antal - 1; i++)
            {
                lista[i] = lista[i + 1];
            }

            antal--;

            
            if (längd - antal > buffert)
            {
                Reducera();
            }

            return temp;
        }

        public T ElementFrån(int index)
        {
            
            T temp = lista[index];

            return temp;
        }

        public int Antal()
        {
            return antal;
        }

        public bool Har(T temp)
        {
            bool har = false;

     
            for (int i = 0; i < antal; i++)
            {
                if (lista[i].Equals(temp))
                {
                    har = true;
                }
            }

            return har;
        }
        public int Sök(T temp)
        {
            int index = -1;

       
            for (int i = 0; i < antal; i++)
            {
                if (lista[i].Equals(temp))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }
        public virtual void LäggTill(Samling<T> samling)
        {
            int size = samling.Antal();

        
            for (int i = 0; i < size; i++)
            {
                LäggTill(samling.ElementFrån(i));
            }
        }

    }
}
