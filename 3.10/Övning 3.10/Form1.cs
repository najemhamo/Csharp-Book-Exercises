using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3._10
{
    public partial class Form1 : Form
    {
        int Yvarde;
        public Form1()
        {
            InitializeComponent();
            Yvarde = tbx_vara.Location.Y;
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
          
            Yvarde +=30;
             
          
            TextBox NyTextBoxVara = new TextBox();
            TextBox NyTextBoxPris = new TextBox();

            NyTextBoxVara.Location = new Point(tbx_vara.Location.X,Yvarde);
            NyTextBoxPris.Location = new Point(tbx_pris.Location.X,Yvarde);

            NyTextBoxVara.Size = tbx_vara.Size;
            NyTextBoxPris.Size = tbx_pris.Size;

            this.Controls.Add(NyTextBoxVara);
            this.Controls.Add(NyTextBoxPris);

           
            btn_add.Location = new Point(btn_add.Location.X,Yvarde);
        }
    }
}
