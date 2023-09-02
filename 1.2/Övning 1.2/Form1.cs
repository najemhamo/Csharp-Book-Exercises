using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_1._2
{
    public partial class Form1 : Form
    {

        string[,] data = new string[5, 3];

        public Form1()
        {
            InitializeComponent();


            // Alla värden i fältet data fylls med "" 
            for (int i = 0; i < 5; i++)
            {
                for (int y = 0; y < 3; y++)
                {
                    data[i, y] = "";
                }

            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Textboxen töms
            tbx_tab.Text = "";

            // rad och kolumn värde blir int
            int rad = int.Parse(tbx_rad.Text) -1;
            int kolumn = int.Parse(tbx_kolumn.Text) -1;

            // värdet sätts i fältet
            data[rad, kolumn] = tbx_varde.Text + "      ";

            // Fältet skrivs i textboxen tbx_tab
            for(int i = 0; i < 5; i++)
            {
                for (int y = 0; y < 3 ; y++)
                {
                    tbx_tab.AppendText(data[i,y]);
                }
                tbx_tab.AppendText("\n");
            }


        }


    }
}
