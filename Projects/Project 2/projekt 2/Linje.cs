using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_2
{
    class Linje: Figur
    {
        int GammalX, GammalY;
        public Linje(int x, int y, Color c, int size): base(x, y, c , size)
        {

        }

        public override void RitaFigur(Graphics g)
        {
            Pen pen = new Pen(c);
            Pen penGammal = new Pen(Color.White);

            pen.Width = size;
            penGammal.Width = size;
            

            g.DrawLine(penGammal, new Point(x1, y1), new Point(GammalX, GammalY));
            g.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));

        }
       
        
        public override void Punkt2(int x, int y)
        {
            GammalX = x2;
            GammalY = y2;
            base.Punkt2(x, y);
        }
    }
}
