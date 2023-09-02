using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_2._8
{
    public partial class Form1 : Form
    {
      
        List<Vara> varor = new List<Vara>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
          
            if (rdb_styck.Checked)
            {
                varor.Add(new StyckSak(tbx_vara.Text,double.Parse(tbx_pris.Text),int.Parse(tbx_mangd.Text)));
            }else if (rdb_vikt.Checked)
            {
                varor.Add(new LösVikt(tbx_vara.Text, double.Parse(tbx_pris.Text), int.Parse(tbx_mangd.Text)));
            }

            
            lbx_lista.Items.Clear();
            double sum = 0;


            foreach(Vara vara in varor)
            {
                if (vara is StyckSak) {
                    lbx_lista.Items.Add(vara.Namn() + " " + (vara as StyckSak).Antal() + " st. " + (vara as StyckSak).StyckPris() + " kr/st");
                    lbx_lista.Items.Add("                                   " + vara.BeräknaPris() + " kr");
                }
                if (vara is LösVikt)
                {
                    lbx_lista.Items.Add(vara.Namn() + " " + (vara as LösVikt).Vikt() + " kg. " + (vara as LösVikt).KiloPris() + " kr/kg");
                    lbx_lista.Items.Add("                                   " + vara.BeräknaPris() + " kr");
                }

               
                sum += vara.BeräknaPris();
            }

            tbx_sum.Text = sum.ToString();


        }
    }
}
