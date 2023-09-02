using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._2
{

    class Anställd
    {   
        private string namn;

        public Anställd(string n)
        {
            namn = n;
        }

        public string Namn()
        {
            return namn;
        }

  
        public virtual double BeräknaLön()
        {
            return 0;
        }
        public override string ToString()
        {
            return namn;
        }
    }
}
