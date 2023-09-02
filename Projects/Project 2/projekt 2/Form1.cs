using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_2
{
    public partial class Form1 : Form
    {
        Label ColorFor = new Label();

        int x = 50, y = 50;
        figur f = figur.Penna;
        bool clicked = false;
        bool drawAgain = false;
        bool cler = false;
        Color c = Color.Black;
        int size;
        List<Figur> figurer = new List<Figur>();

        public Form1()
        {
            InitializeComponent();
            size = int.Parse(tbx_size.Text);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = pnl_tavla.CreateGraphics();
            if (clicked)
            {
                figurer.ElementAt(figurer.Count - 1).RitaFigur(g);
            }

            if (drawAgain)
            {
                if (cler)
                {
                    g.Clear(Color.White);
                    cler = false;
                }

                foreach (Figur f in figurer)
                {
                  
                    f.RitaFigur(g);
                    if (f is Penna)
                    {
                        (f as Penna).RitaAll(g);
                    }
                }
                drawAgain = false;
            }

        }

        private void pnl_tavla_MouseDown(object sender, MouseEventArgs e)
        {
            if (!clicked)
            {
                if (f == figur.Linje)
                {
                    figurer.Add(new Linje(e.X, e.Y,c,size));
                    clicked = true;
                }else if(f == figur.Rektangel)
                {
                    figurer.Add(new Rektangel(e.X,e.Y,c,size));
                    clicked = true;
                }else if(f == figur.Cirkel)
                {
                    figurer.Add(new Cirkel(e.X,e.Y,c,size));
                    clicked = true;
                }else if(f == figur.Penna)
                {
                    figurer.Add(new Penna(e.X, e.Y, c , size));
                    clicked = true;
                }
                
            }
            
        }

        private void pnl_tavla_MouseUp(object sender, MouseEventArgs e)
        {
            clicked = false;
            drawAgain = true;
            Invalidate();
        }

        private void pnl_tavla_MouseMove(object sender, MouseEventArgs e)
        {
            if (clicked)
            {
                
                figurer.ElementAt(figurer.Count - 1).Punkt2(e.X, e.Y);
               
                Invalidate();
            }
        }

        private void btn_rektangel_Click(object sender, EventArgs e)
        {
            f = figur.Rektangel;
        }

        private void btn_cirkel_Click(object sender, EventArgs e)
        {
            f = figur.Cirkel;
        }

        private void btn_penna_Click(object sender, EventArgs e)
        {
            f = figur.Penna;
        }

        private void btn_ångra_Click(object sender, EventArgs e)
        {
            int index = figurer.Count - 1;
            figurer.RemoveAt(index);
            cler = true;
            drawAgain = true;
            Invalidate();
        }

        private void lbl_color_Click(object sender, EventArgs e)
        {
            ColorFor.Height -= 3;
            ColorFor.Width -= 3;

            c = (sender as Label).BackColor;
            (sender as Label).Width += 3;
            (sender as Label).Height += 3;

            ColorFor = (sender as Label);
        }

        private void tbx_size_TextChanged(object sender, EventArgs e)
        {
            try
            {
                size = int.Parse(tbx_size.Text);
            }catch(Exception ex)
            {

            }
        }

        private void btn_linje_Click(object sender, EventArgs e)
        {

            f = figur.Linje;
        }
    }
}
