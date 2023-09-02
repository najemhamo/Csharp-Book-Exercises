using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._1
{
    class Ljudspår : Media
    {
        
        protected int speltid;

        public Ljudspår(int speltid,string titel):base(titel)
        {
            this.speltid = speltid;
        }

  
        public override string ToString()
        {
            return "(Ljudspår) " + titel + ": " + speltid + " minuter ";
        }
    }
}
