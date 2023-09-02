using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._8
{
    class StyckSak : Vara
    {
        protected double styckPris;
        protected int antal;

        
        /// <param name="n">Varans namn</param>
        /// <param name="p">Varans styckpris</param>
        /// <param name="a">Antal stycken </param>
        public StyckSak(string n, double p , int a)
        {
            namn = n;
            styckPris = p;
            antal = a;
        }

        /// <summary>
        /// Returnerar styckpris
        /// </summary>
        /// <returns>Returnerar styckpris</returns>
        public double StyckPris()
        {
            return styckPris;
        }

        /// <summary>
        /// Returnerar antal stycken
        /// </summary>
        /// <returns>Returnerar antal stycken</returns>
        public int Antal()
        {
            return antal;
        }

        /// <summary>
        /// Returnerar prist på varan
        /// </summary>
        /// <returns>Returnerar prist på varan</returns>
        public override double BeräknaPris()
        {
            return styckPris * antal;
        }
    }
}
