using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_1._3
{
    public partial class Form1 : Form
    {
        //
        PictureBox b = new PictureBox();
        public Form1()
        {
            InitializeComponent();
            
            // Fältet bilder ska innehålla alla PictureBox
            PictureBox[,] bilder = new PictureBox[5, 5];

             
            


            int x = 0;
            int y = 0;

            int bred = 100;
            int höjd = 100;

          
            
          
            // En dubbel array används för att rita bilderna
            for(int i = 0; i < 5; i++)
            {
                for(int c = 0; c < 5; c++)
                {
                    bilder[i, c] = new PictureBox();
                    bilder[i, c].Left = x;
                    bilder[i, c].Top = y;
                    bilder[i, c].Width = bred;
                    bilder[i, c].Height = höjd;
                    
                    bilder[i, c].Image = Image.FromFile("blomma.png");
                   
                    // Man lägger en klick funktion till PictureBox
                    bilder[i, c].Click += pbxblomma_Click;

                    Controls.Add(bilder[i, c]);
                    x += 100;
                }
                y += 100;
                x = 0;
            }

            
            
        }

        private void pbxblomma_Click (object sender, EventArgs e)
        {
         
            b.BorderStyle = BorderStyle.None;
            PictureBox klickk = (PictureBox)sender;
            klickk.BorderStyle = BorderStyle.FixedSingle;
            b = klickk;
        }

    }
}
