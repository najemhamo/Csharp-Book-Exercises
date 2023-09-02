using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_2._3
{
    public partial class Form1 : Form
    {
        //Listan b innehåller alla registerade konton
        List<BankKonto> b = new List<BankKonto>();


        public Form1()
        {
            InitializeComponent();
        }


        private void btn_reg_Click(object sender, EventArgs e)
        {
            // Om användaren lämnar kredit tom blir konto ett sparkonto annars är det lånekonto
            if (tbx_kredit.Text.Equals(""))
            {
                SparKonto s = new SparKonto(tbx_Pnum.Text,0,double.Parse(tbx_ränta.Text));

                b.Add(s);
            }else
            {
                LåneKonto l = new LåneKonto(tbx_Pnum.Text, 0, double.Parse(tbx_ränta.Text),double.Parse(tbx_kredit.Text));

                b.Add(l);
            }

            // Alla konton i listan skrivs i listbox
            lbx_konton.Items.Clear();

            foreach(BankKonto bank in b)
            {
                lbx_konton.Items.Add(bank.ToString());
            }
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            // beloppen adderas till den valda kontot
            b.ElementAt(lbx_konton.SelectedIndex).Insättning(double.Parse(tbx_belopp.Text));

            lbx_konton.Items.Clear();

            foreach (BankKonto bank in b)
            {
                lbx_konton.Items.Add(bank.ToString());
            }
        }

        private void btn_ut_Click(object sender, EventArgs e)
        {
            // Beloppet tas bort från kontot om det går
            if (b.ElementAt(lbx_konton.SelectedIndex).Uttag(double.Parse(tbx_belopp.Text)))
            {
                b.ElementAt(lbx_konton.SelectedIndex).Insättning(double.Parse(tbx_belopp.Text) * -1);
            }else
            {
                MessageBox.Show("Du kan inte ta den här summan från kontot.");
            }
            lbx_konton.Items.Clear();

            foreach (BankKonto bank in b)
            {
                lbx_konton.Items.Add(bank.ToString());
            }
        }

        private void btn_uppdatera_Click(object sender, EventArgs e)
        {
            // Alla konton i listan uppdateras med årsräntan
            lbx_konton.Items.Clear();

            foreach (BankKonto bank in b)
            {
                double ränta = bank.BeräknaRänta();
                bank.Insättning(ränta);
           
                lbx_konton.Items.Add(bank.ToString());
            }
        }
    }
}
