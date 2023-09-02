using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_2._2
{
    public partial class Form1 : Form
    {
        
        List<Anställd> anställd = new List<Anställd>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_registeraS_Click(object sender, EventArgs e)
        {
            Säljare s = new Säljare(tbx_namnSäljare.Text,double.Parse(tbx_prov.Text),double.Parse(tbx_för.Text));

            anställd.Add(s);
        }

        private void btn_registeraK_Click(object sender, EventArgs e)
        {
            Konsult k = new Konsult(tbx_namnKonsult.Text, double.Parse(tbx_arbetadTid.Text), double.Parse(tbx_timlön.Text));

            anställd.Add(k);
        }

        private void btn_registerako_Click(object sender, EventArgs e)
        {
            Kontorist k = new Kontorist(tbx_namnKontorist.Text,double.Parse(tbx_månadLön.Text));

            anställd.Add(k);
        }

        private void btn_beräkna_Click(object sender, EventArgs e)
        {
            
            lbx_lön.Items.Clear();
            lbx_reg.Items.Clear();

            double sum = 0;
            foreach(Anställd a in anställd)
            {
                lbx_reg.Items.Add(a.ToString());
                lbx_lön.Items.Add(a.ToString() + ": " + a.BeräknaLön());

                sum += a.BeräknaLön();
            }

            tbx_lön.Text = sum + "";
        }
    }
}
