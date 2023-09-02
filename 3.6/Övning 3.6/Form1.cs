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
        Color c = Color.Black;
        public Form1()
        {
            InitializeComponent();

           
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
            
        }

    
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

        //SelectionFont
        private void btn_tecken_Click(object sender, EventArgs e)
        {
            DialogResult r = dlg_font.ShowDialog();

            if (r == DialogResult.OK)
            {
                rtb_text.SelectionFont = dlg_font.Font;
            }

            
        }

        // SelectionColor
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
        }
    }
}
