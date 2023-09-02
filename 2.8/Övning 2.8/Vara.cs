using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._8
{
    
    abstract class Vara
    {
        
        protected string namn;
        /// <summary>
        /// Returnerar nemnet på varan
        /// </summary>
        /// <returns>Den returnerar Namnet på varan</returns>
        public string Namn()
        {
       
            return namn;
        }
        /// <summary>
        /// Returnerar priset på varan      
        /// </summary>
        /// <returns>Returnerar priset på varan</returns>
        public abstract double BeräknaPris();
    }
}
