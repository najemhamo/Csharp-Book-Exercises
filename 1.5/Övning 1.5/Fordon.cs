using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_1._5
{
    // enum FordonsTyp är för vilken typ
    enum FordonsTyp { Bil = 1,MC = 2};
    class Fordon
    {
        // Klassen tar de variabler
        private string regNr, märke, modell;
        FordonsTyp fordonsTyp;

        // Listan Reg sparar registeringsnummer på alla registerade fordon
        static List<string> Reg = new List<string>();

        

        public Fordon(string regNr, string märke, string modell, FordonsTyp fordonsTyp)
        {
            this.regNr = regNr;
            this.märke = märke;
            this.modell = modell;
            this.fordonsTyp = fordonsTyp;
        }

      // Denna metoden ger Fordonstyp
        public FordonsTyp FordonsTyp
        {
            get { return fordonsTyp; }
            
        }


        // Denna metoden godkänner nummret
        public static bool GodkännRegNr(string regNr)
        {
            bool res = true;

            // Den kollar först om det finns redan i listan

           for(int i = 0; i < Reg.Count; i++)
            {
                if (regNr.Equals(Reg.ElementAt(i)))
                {
                    res = false;
                }
            }
           // Den kollar sen om den består av tre bokstäver följt av tre siffror
            if (regNr.Length == 6)
            {
                for (int i = 0; i < 3; i++)
                {
                    int num = regNr[i];
                    if (num > 47 && num < 59)
                    {
                        res = false;
                    }
                }
                for (int i = 3; i < 6; i++)
                {
                    int num = regNr[i];
                    if (!(num > 47 && num < 59))
                    {
                        res = false;
                    }
                }
            }else
            {
                res = false;
            }
            // Registeringsnummret adderas till listan
            if (res)
            {
                Reg.Add(regNr);
            }
            return res;
        }
        // Metoden to string ger tillbaka alla värden
       public string ToString
        {
            get { return märke + " " + regNr + " " + modell; }
        }
    }
}
