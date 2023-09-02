using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void öppnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if(dlgÖppna.ShowDialog() == DialogResult.OK)
            {
               
                FileStream inström = new FileStream(dlgÖppna.FileName, FileMode.Open, FileAccess.Read);

                
                StreamReader läsare = new StreamReader(inström);

                
                rtb_text.Text = läsare.ReadToEnd();

                läsare.Dispose();
                
                sparaToolStripMenuItem.Enabled = true;
            }
        }

        private void sparaSomToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dlgSpara.ShowDialog() == DialogResult.OK)
            {
               
                FileStream utström = new FileStream(dlgSpara.FileName, FileMode.Create, FileAccess.Write);

               
                StreamWriter skrivare = new StreamWriter(utström);
                
                skrivare.Write(rtb_text.Text);

                skrivare.Dispose();
            }

         }

        private void sparaToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
            FileStream utström = new FileStream(dlgÖppna.FileName, FileMode.Open, FileAccess.Write);

            StreamWriter skrivare = new StreamWriter(utström);

            skrivare.Write(rtb_text.Text);

            skrivare.Dispose();
        }

        private void stängToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnErsätt_Click(object sender, EventArgs e)
        {
           
            string text = rtb_text.Text;
            string gammal = tbx_oldWord.Text;
            string ny = tbx_newWord.Text;

            
            int word = 0;

            
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Equals(gammal[word]))
                {
                    word += 1;
                    
                    if(word == gammal.Length)
                    {
                        rtb_text.SelectionStart = i - (word-1);
                        rtb_text.SelectionLength = word;
                        
                        rtb_text.SelectedText = ny;
                        text = rtb_text.Text;

                        word = 0;
                    }

                }else
                {
                    word = 0;
                }
            }
        }

        
    }
}
