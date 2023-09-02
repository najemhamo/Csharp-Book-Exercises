using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3._1
{
    public partial class Form1 : Form
    {
        // btn är objekten som ska innehållar knappen
        object btn;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_farg_Click(object sender, EventArgs e)
        {

            // Dialogen visas till användaren
            DialogResult r = dlgColor.ShowDialog();

            // Om användaren klickar okej ändras knappens färg till den valda färgen 
            if(r == DialogResult.OK)
            {
                (btn as Button).BackColor = dlgColor.Color;
            }
        }

        private void btn_fil_Click(object sender, EventArgs e)
        {
            // Dialogen visas till användaren
            DialogResult r = dlgFile.ShowDialog();

            // Om användaren klickar okej ändras knappens namn till filens namn 
            if (r == DialogResult.OK)
            {
                btn_fil.Text = dlgFile.SelectedPath.ToString();
            }
        }

        private void btn_tecken_Click(object sender, EventArgs e)
        {

            // Dialogen visas till användaren

            DialogResult r = dlg_font.ShowDialog();

            // Om användaren klickar okej ändras knappens teckensnitt till den valda teckensnittet
            if (r == DialogResult.OK)
            {
                (btn as Button).Font = dlg_font.Font;
            }
        }

      
        
        private void baklängestextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Texten på knappen ändras baklänges
            string Baktext = "";

            for (int i = (btn as Button).Text.Length-1; i >= 0; i--)
            {
                Baktext = Baktext + (btn as Button).Text[i];
            }

            (btn as Button).Text = Baktext;
        }

        private void taBortToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Controls.Remove((Button) btn);
        }

        private void btn_farg_MouseEnter(object sender, EventArgs e)
        {
            // När musen kommer in i knappen ändras (btn) till knappen
            btn = sender;
        }
    }
}
