using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_2
{
    class Rektangel: Figur
    {
        int GammalX, GammalY;
        Rectangle r;
        bool d = true;
        public Rektangel(int x, int y, Color c, int size) : base(x, y, c, size)
        {
            r = new Rectangle();  
            r.X = x1;
            r.Y = y1;
            r.Width = 100;
            r.Height = 100;
        }

        public override void RitaFigur(Graphics g)
        {
            Pen pen = new Pen(c);

            
                        
            
            
            
            pen.Width = size;
            

            int XR = x1;
            int YR = y1;


            



            Pen penGammal = new Pen(Color.White);
            penGammal.Width = size;

            int bredd2 = GammalX - x1;
            int höjd2 = GammalY - y1;

            if (bredd2 < 0)
            {
                x1 = GammalX;
                bredd2 *= -1;
            }
            if (höjd2 < 0)
            {
                y1 = GammalY;
                höjd2 *= -1;
            }

            g.DrawRectangle(penGammal, x1, y1, bredd2, höjd2);

            x1 = XR;
            y1 = YR;

            int bredd = x2 - x1;
            int höjd = y2 - y1;

            if (bredd < 0)
            {
                x1 = x2;
                bredd *= -1;
            }
            if (höjd < 0)
            {
                y1 = y2;
                höjd *= -1;
            }


            if (x2 != 0 && y2 != 0)
            {
                g.DrawRectangle(pen, x1, y1, bredd, höjd);
            }

            x1 = XR;
            y1 = YR;
            
        }


        public override void Punkt2(int x, int y)
        {
            GammalX = x2;
            GammalY = y2;
            base.Punkt2(x, y);
        }
    }
}
