using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_1._5
{
    public partial class Form1 : Form
    {
        // Listan fordon som innehålla alla registerade fordon
        List<Fordon> fordon = new List<Fordon>();
        public Form1()
        {
            InitializeComponent();
            cb_typ.SelectedIndex = 0;
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            // Registeringsnummret granskas.
            bool god = Fordon.GodkännRegNr(tbx_num.Text);


            FordonsTyp typ = (FordonsTyp)cb_typ.SelectedIndex+1;

         

            if (god)
            {
                fordon.Add(new Fordon(tbx_num.Text,tbx_mark.Text,tbx_mod.Text,typ));
            }
            else
            {
                MessageBox.Show("Registeringsnummer är fel");
            }

           
            FordonsTyp selected = FordonsTyp.Bil;

            if (rdb_alla.Checked)
            {
                selected = FordonsTyp.Bil | FordonsTyp.MC;
            }
            else if (rdb_bil.Checked)
            {
                selected = FordonsTyp.Bil;
            }
            else if (rdb_MC.Checked)
            {
                selected = FordonsTyp.MC;
            }

            lib_regester.Items.Clear();
            foreach(Fordon f in fordon)
            {

                if ((f.FordonsTyp & selected) != 0)
                {
                    lib_regester.Items.Add(f.ToString);
                }
                
            }
        }

        private void rdb_alla_CheckedChanged(object sender, EventArgs e)
        {
           

            FordonsTyp selected = FordonsTyp.Bil;

            if (rdb_alla.Checked)
            {
                selected = FordonsTyp.Bil | FordonsTyp.MC;
            }
            else if (rdb_bil.Checked)
            {
                selected = FordonsTyp.Bil;
            }
            else if (rdb_MC.Checked)
            {
                selected = FordonsTyp.MC;
            }

            lib_regester.Items.Clear();
            foreach (Fordon f in fordon)
            {

                if ((f.FordonsTyp & selected) != 0)
                {
                    lib_regester.Items.Add(f.ToString);
                }

            }
        }
    }
}
