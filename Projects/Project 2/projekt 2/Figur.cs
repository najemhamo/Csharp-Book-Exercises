using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_2
{
    enum figur { Penna, Rektangel, Cirkel, Linje }

    abstract class Figur
    {
        protected int x1, x2, y1, y2, size;
        protected Color c;
        

        public Figur(int x , int y, Color c, int size)
        {
            x1 = x;
            y1 = y;
            this.c = c;
            this.size = size;
        }

        public virtual void Punkt2(int x , int y)
        {
            x2 = x;
            y2 = y;
        }

        public abstract void RitaFigur(Graphics g);

       


    }
}
