using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_1._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            foreach(FontFamily ff in FontFamily.Families)
            {
                cbTecken.Items.Add(ff.Name);
            }
            cbTecken.SelectedIndex = 2;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

           
            FontStyle font = FontStyle.Regular;

            if (cbxFet.Checked)
            {
                font = font | FontStyle.Bold;
            }
            if (cbxKursiv.Checked)
            {
                font = font | FontStyle.Italic;
            }
            if (cbxUnder.Checked)
            {
                font = font | FontStyle.Underline;
            }

            // Font 
            int size = int.Parse(tbx_size.Text);
            Font f = new Font(cbTecken.SelectedItem.ToString(),size,font);

            


            tbxText.Font = f;
        }
    }
}
