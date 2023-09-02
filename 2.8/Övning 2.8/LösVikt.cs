using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._8
{
    class LösVikt:Vara
    {
        protected double kiloPris, vikt;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n">Namnet på varan</param>
        /// <param name="k">Varans pris i kilo</param>
        /// <param name="v">Varans vikt</param>
        public LösVikt(string n, double k, double v)
        {
            namn = n;
            kiloPris = k;
            vikt = v;

        }


        /// <summary>
        /// Den returnerar varas pris i kilo
        /// </summary>
        /// <returns>Den returnerar varas pris i kilo</returns>
        public double KiloPris()
        {
            return kiloPris;
        }


        /// <summary>
        /// Returnerar varans vikt
        /// </summary>
        /// <returns>Returnerar varans vikt</returns>
        public double Vikt()
        {
            return vikt;
        }

        /// <summary>
        /// Returnerar prist på varan
        /// </summary>
        /// <returns>Returnerar prist på varan</returns>
        public override double BeräknaPris()
        {
            return kiloPris * vikt;
        }
    }
}
