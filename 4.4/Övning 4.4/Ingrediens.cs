using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_4._4
{
    // Klassen Ingrediens inehåller namn och mängd och mått
    class Ingrediens
    {
        private string namn,mått;
        private double mängd;

        public string Namn
        {
            get { return namn; }
            set { namn = value; }
        }
        public double Mängd
        {
            get { return mängd; }
            set { mängd= value; }
        }
        public string Mått
        {
            get { return mått; }
            set { mått = value; }
        }
    }
}
