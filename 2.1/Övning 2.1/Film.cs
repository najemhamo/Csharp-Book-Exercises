using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._1
{
    class Film : Ljudspår
    {
        
        protected string Upplösning;

        public Film(string Upplösning, string titel, int speltid) : base(speltid, titel)
        {
            this.Upplösning = Upplösning;
        }

        public override string ToString()
        {
            return "(Film) " + titel + ": " + speltid + " minuter " + Upplösning;
        }
    }
}
