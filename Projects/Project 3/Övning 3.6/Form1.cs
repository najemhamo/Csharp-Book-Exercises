using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3._6
{
    public partial class Form1 : Form
    {
        bool punkt = false;
        bool punkt2 = false;
        FontStyle fontstyle = FontStyle.Regular;
        Color c = Color.Black;
        public Form1()
        {
            InitializeComponent();

            // Vi lägger en bild på alla radiobutton
            rdb_vänster.BackgroundImage = Image.FromFile("Vänster.jpg");
            rdb_vänster.BackgroundImageLayout = ImageLayout.Stretch;
            rdb_vänster.Size = new Size(25, 25);

            rdb_center.BackgroundImage = Image.FromFile("Center.jpg");
            rdb_center.BackgroundImageLayout = ImageLayout.Stretch;
            rdb_center.Size = new Size(25, 25);

            rdb_höger.BackgroundImage = Image.FromFile("Höger.jpg");
            rdb_höger.BackgroundImageLayout = ImageLayout.Stretch;
            rdb_höger.Size = new Size(25, 25);

            lbl_color.BackColor = c;

            rtb_text.SelectionAlignment = HorizontalAlignment.Left;

            // Vi sätter alla fontfamiljer i combobox

            foreach(FontFamily f in FontFamily.Families)
            {
                cbxFont.Items.Add(f.Name);
            }
            cbxFont.SelectedItem = "Arial";

            
                }

        // Vi ger funktionen till radioknappar så att textens format ändras
        private void rdb_center_CheckedChanged(object sender, EventArgs e)
        {
            rtb_text.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void rdb_höger_CheckedChanged(object sender, EventArgs e)
        {
            rtb_text.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void rdb_vänster_CheckedChanged(object sender, EventArgs e)
        {
            rtb_text.SelectionAlignment = HorizontalAlignment.Left;
        }

       

        // Labeln med färgen ändrar färgen på den markerade texten i RichTextBox och änvändar egenskapen (SelectionColor)
        private void lbl_color_Click(object sender, EventArgs e)
        {
            DialogResult r = dlg_color.ShowDialog();

            if(r == DialogResult.OK)
            {
                c = dlg_color.Color;
            }

            rtb_text.SelectionColor = c;
            lbl_color.BackColor = c;
        }


        private void rtb_text_TextChanged(object sender, EventArgs e)
        {
            c = rtb_text.SelectionColor;

            if(c != Color.Empty)
            {
                lbl_color.BackColor = c;
            }
        }

        private void rtb_text_KeyDown(object sender, KeyEventArgs e)
        {
            c = rtb_text.SelectionColor;

            if (c != Color.Empty)
            {
                lbl_color.BackColor = c;
            }

            if (punkt && e.KeyCode == Keys.Enter)
            {

                punkt2 = true;

            }else
            {
                punkt2 = false;
            }
                 
            
        }
       // tecken snittet ändras i RichTextBox beroende på vilken teckensnitt användaren väljer i rullistan
        private void cbxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtb_text.SelectionFont = new Font(cbxFont.Text,(float)nudSize.Value,fontstyle);
        }

        // Storleken på texten ändras
        private void nudSize_ValueChanged(object sender, EventArgs e)
        {
            rtb_text.SelectionFont = new Font(cbxFont.Text, (float)nudSize.Value, fontstyle);
        }

        // Techensnittet ändras beror på vad användaren väljer i chekboxen 
        private void cbxBold_CheckedChanged(object sender, EventArgs e)
        {
            fontstyle = FontStyle.Regular;
            if (cbxBold.Checked)
            {
                fontstyle = fontstyle | FontStyle.Bold;
            }

            if (cbxItalic.Checked)
            {
                fontstyle = fontstyle | FontStyle.Italic;
            }
            rtb_text.SelectionFont = new Font(cbxFont.Text, (float)nudSize.Value, fontstyle);
        }

        // En punkt lista skapas när man trycker på den knappen
        private void btn_punkt_Click(object sender, EventArgs e)
        {
            if (!punkt)
            {
                punkt = true;
                rtb_text.SelectionFont = new Font(cbxFont.Text, 20, fontstyle);
                rtb_text.AppendText("\n.  ");
                rtb_text.SelectionFont = new Font(cbxFont.Text, (float)nudSize.Value, fontstyle);

            }
            else
            {
                punkt = false;
            }
        }

        //
        private void rtb_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Om användaren har vald punkt listan skrivs en punkt när man trycker på Enter
            if (punkt2 )
            {

                rtb_text.SelectionFont = new Font(cbxFont.Text, 20, fontstyle);
                rtb_text.AppendText(".  ");
                rtb_text.SelectionFont = new Font(cbxFont.Text, (float)nudSize.Value, fontstyle);

            }
        }

        // Här är söknings funktion
        private void tbx_sök_TextChanged(object sender, EventArgs e)
        {
            
            rtb_text.SelectionStart = 0;
            rtb_text.SelectionLength = rtb_text.Text.Length;

            rtb_text.SelectionBackColor = Color.White;

            string sökt = tbx_sök.Text;
            int number = 0;
            int start = 0;

            int antal = 0;
            // Den loopas genom hela texten och kollar på bokstäver 
            if (sökt.Length != 0)
            {
                for (int i = 0; i < rtb_text.Text.Length; i++)
                {
                    if (rtb_text.Text[i] == sökt[number])
                    {
                        if (number == 0)
                        {
                            start = i;
                        }

                        number += 1;

                        if (number == sökt.Length)
                        {
                            rtb_text.SelectionStart = start;
                            rtb_text.SelectionLength = sökt.Length;

                            rtb_text.SelectionBackColor = Color.Orange;

                            start = 0;
                            number = 0;

                            antal += 1;
                        }

                    }
                    else
                    {
                        start = 0;
                        number = 0;

                    }
                }
            }
            if (antal != 0)
            {
                lbl_hittade.Text = "Hittade "+ antal.ToString();
            }else
            {
                lbl_hittade.Text = "Hittade inget";
            }
          
        }
        // Funktionen (SelectionCharOffest) används för att upphöja och sänka
        private void btn_upphöjt_Click(object sender, EventArgs e)
        {
            if (rtb_text.SelectionCharOffset == 6)
            {
                rtb_text.SelectionCharOffset = 1;
            }
            else
            {
                rtb_text.SelectionCharOffset = 6;
            }
        }

        private void btn_nedsänkt_Click(object sender, EventArgs e)
        {
            if (rtb_text.SelectionCharOffset == -5)
            {
                rtb_text.SelectionCharOffset = 1;
            }
            else
            {
                rtb_text.SelectionCharOffset = -5;
            }
        }
    }
}
