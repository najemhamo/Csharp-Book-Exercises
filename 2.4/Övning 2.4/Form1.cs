using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_2._4
{
    public partial class Form1 : Form
    {
        // Listan figurer innehåller alla figurer
        List<Figur> figurer = new List<Figur>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_triangel_Click(object sender, EventArgs e)
        {
            // En triangel adderas till listan
            Figur f = new Triangel(double.Parse(tbx_bredd.Text),double.Parse(tbx_höjd.Text));

            figurer.Add(f);

            // Listan fylls med alla figurer
            lbx_lista.Items.Clear();
            foreach(Figur figur in figurer)
            {
                lbx_lista.Items.Add(figur.ToString());
            }
        }

        private void btn_cirkel_Click(object sender, EventArgs e)
        {
            double bredd = double.Parse(tbx_bredd.Text);
            double höjd = double.Parse(tbx_höjd.Text);

            // En cirkel adderas till listan om bredden och höjden är lika
            if(bredd == höjd)
            {
                Figur f = new Cirkel(bredd, höjd);

                figurer.Add(f);

            }else
            {
                MessageBox.Show("Höjden och bredden måste vara samma","Fel",MessageBoxButtons.OK,MessageBoxIcon.Error);
               
           }

            // Listan fylls med alla figurer
            lbx_lista.Items.Clear();
            foreach (Figur figur in figurer)
            {
                lbx_lista.Items.Add(figur.ToString());
            }
        }

        private void btn_linje_Click(object sender, EventArgs e)
        {
            // En linje adderas till listan
            Figur f = new Linje(double.Parse(tbx_bredd.Text), double.Parse(tbx_höjd.Text));

            figurer.Add(f);

            // Listan fylls med alla figurer
            lbx_lista.Items.Clear();
            foreach (Figur figur in figurer)
            {
                lbx_lista.Items.Add(figur.ToString());
            }
        }

        private void btn_Area_Click(object sender, EventArgs e)
        {
            // Arean räknas i alla figurer med hjälp av Interface IArea
            double Area = 0;
            foreach (Figur figur in figurer)
            {
                if(figur is IArea)
                {
                    Area += (figur as IArea).RäknaArea();
                }
            }
            tbx_area.Text = Area + " cm^2";
        }
    }
}
