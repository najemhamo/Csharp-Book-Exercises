using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_1._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_skapa_Click(object sender, EventArgs e)
        {
            try
            {
                Konto k = new Konto(tbx_epos.Text, tbx_los.Text);
                lbl_los.ForeColor = Color.Black;
                lbl_add.ForeColor = Color.Black;
                MessageBox.Show("Kontot skapat");
            }
            catch(LösenFormatException fel)
            { 
                MessageBox.Show(fel.ToString());
                lbl_los.ForeColor = Color.Red;
            }
            catch (EpostAdressFormatException fel2)
            {
                MessageBox.Show(fel2.ToString());
                lbl_add.ForeColor = Color.Red;
            }

            
        }
    }
}
