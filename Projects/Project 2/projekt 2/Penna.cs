using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_2
{
    class Penna : Figur
    {
        List<int> X = new List<int>();
        List<int> Y = new List<int>();

        public Penna(int x, int y, Color c, int size) : base(x, y, c, size)
        {

        }

        public override void RitaFigur(Graphics g)
        {
            SolidBrush sb = new SolidBrush(c);

            g.FillEllipse(sb, x1, y1, size, size);
            X.Add(x1);
            Y.Add(y1);
        }

        public override void Punkt2(int x, int y)
        {
            x1 = x;
            y1 = y;
        }

        public void RitaAll(Graphics g)
        {
            foreach(int i in X)
            {
                SolidBrush sb = new SolidBrush(c);
                g.FillEllipse(sb, i, Y.ElementAt(X.IndexOf(i)), size, size);
            }
        }
    }
}
