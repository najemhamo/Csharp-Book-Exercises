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

namespace Övning_4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_öppna_Click(object sender, EventArgs e)
        {
            
            if(dlg_öppna.ShowDialog() == DialogResult.OK)
            {
                
                FileStream inström = new FileStream(dlg_öppna.FileName, FileMode.Open,FileAccess.Read);

                
                StreamReader läsare = new StreamReader(inström);

                
                tbx_förnamn.Text = läsare.ReadLine();
                tbx_efternamn.Text = läsare.ReadLine();
                tbx_epost.Text = läsare.ReadLine();
                tbx_telefon.Text = läsare.ReadLine();

                
                läsare.Dispose();
            }
        }

        private void btn_spara_Click(object sender, EventArgs e)
        {
            
            if(dlg_spara.ShowDialog() == DialogResult.OK)
            {
                
                FileStream utström = new FileStream(dlg_spara.FileName, FileMode.OpenOrCreate, FileAccess.Write);

                StreamWriter skrivare = new StreamWriter(utström);

                skrivare.Write("");
                skrivare.WriteLine(tbx_förnamn.Text);
                skrivare.WriteLine(tbx_efternamn.Text);
                skrivare.WriteLine(tbx_epost.Text);
                skrivare.WriteLine(tbx_telefon.Text);

                skrivare.Dispose();
            }
        }
    }
}
