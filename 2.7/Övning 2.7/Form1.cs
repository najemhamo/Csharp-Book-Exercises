using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_2._7
{
    public partial class Form1 : Form
    {
        
        Samling<BankKonto> b = new SorteradMängd<BankKonto>();


        public Form1()
        {
            InitializeComponent();
        }


        private void btn_reg_Click(object sender, EventArgs e)
        {
            
            if (tbx_kredit.Text.Equals(""))
            {
                SparKonto s = new SparKonto(tbx_Pnum.Text, 0, double.Parse(tbx_ränta.Text));

                b.LäggTill(s);
            }
            else
            {
                LåneKonto l = new LåneKonto(tbx_Pnum.Text, 0, double.Parse(tbx_ränta.Text), double.Parse(tbx_kredit.Text));

                b.LäggTill(l);
            }

          
            lbx_konton.Items.Clear();

            for (int i = 0; i < b.Antal(); i++)
            {
                lbx_konton.Items.Add(b.ElementFrån(i).ToString());
            }

           
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            
            b.ElementFrån(lbx_konton.SelectedIndex).Insättning(double.Parse(tbx_belopp.Text));

            lbx_konton.Items.Clear();

            for (int i = 0; i < b.Antal(); i++)
            {
                lbx_konton.Items.Add(b.ElementFrån(i).ToString());
            }
        }

        private void btn_ut_Click(object sender, EventArgs e)
        {
            
            if (b.ElementFrån(lbx_konton.SelectedIndex).Uttag(double.Parse(tbx_belopp.Text)))
            {
                b.ElementFrån(lbx_konton.SelectedIndex).Insättning(double.Parse(tbx_belopp.Text) * -1);
            }
            else
            {
                MessageBox.Show("Du kan inte ta den här summan från kontot.");
            }
            lbx_konton.Items.Clear();

            for (int i = 0; i < b.Antal(); i++)
            {
                lbx_konton.Items.Add(b.ElementFrån(i).ToString());
            }
        }

        private void btn_uppdatera_Click(object sender, EventArgs e)
        {
            
            lbx_konton.Items.Clear();

            for (int i = 0; i < b.Antal(); i++)
            {
                BankKonto bank = b.ElementFrån(i);
            
            double ränta = bank.BeräknaRänta();
                bank.Insättning(ränta);

                lbx_konton.Items.Add(bank.ToString());
            }
        }
    }
}
