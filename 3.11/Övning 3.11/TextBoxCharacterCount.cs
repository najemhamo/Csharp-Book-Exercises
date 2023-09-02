using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3._11
{
    public partial class TextBoxCharacterCount : UserControl
    {
        string text = "";
        public TextBoxCharacterCount()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            int length = 140 - textBox1.Text.Length;
            label1.Text = "(" + length + ")";

           
            if(length == 0)
            {
                text = textBox1.Text;
            }
            
            if(length < 0)
            {
                int selected = textBox1.SelectionStart;
                textBox1.Text = text;
                textBox1.SelectionStart = selected;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
