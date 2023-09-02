using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_1._7
{
    class Konto
    {

        string epost;
        string lösen;

        public Konto(string epost, string lösen)
        {
            
            bool lös = false, ep = false;
            // Löseren ordet granskas om den innehåller bokstäver och siffror
            int antalS = 0;

            // Antal siffror räknas
            for (int i = 0; i < lösen.Length; i++)
            {
                if (char.IsDigit(lösen[i]))
                {
                    antalS++;
                }

               
            }
             // Om lösenorden är godkänt sätts bool lös till true
            if (0 < antalS && antalS < lösen.Length)
            {
                lös = true;
                
            }
            else
            {
                // Om lösenordet är inte godkänt anropas LösenFormatException
                throw new LösenFormatException();
            }
            
            // Den kollar om det epost addressen innehåller @ sen . alltå den formen a@b.c
            char[] epostt = {'@','.'};
            int y = 0;

            for (int i = 0; i < epost.Length; i++)
            {
                if (y < 2)
                {
                    if (epost[i].Equals(epostt[y]))
                    {
                        y = y + 1;
                    }
                }
            }
            if(y == 2)
            {
                // Om epost addressen är godkänt sätts bool ep till true
                ep = true;
            }else
            {
                // Om epost är inte godkänt anropas EpostAdressFormatException
                throw new EpostAdressFormatException();
            }

            if(ep && lös)
            {
                // Om epost addressen och lösenordet är godkända variablarna sättas.
                this.lösen = lösen;
                this.epost = epost;
            }
         
        }
    }
}
