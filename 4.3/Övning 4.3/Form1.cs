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

namespace Övning_4._3
{
    public partial class Form1 : Form
    {
        List<Kontakt> kontakter = new List<Kontakt>();

        string filnamn;

        public Form1()
        {
            InitializeComponent();
        }

        private void öppnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if(dlg_open.ShowDialog() == DialogResult.OK)
            {
                FileStream inström = new FileStream(dlg_open.FileName, FileMode.Open, FileAccess.Read);

                StreamReader läsare = new StreamReader(inström);

               
                ltb_kontakter.Items.Clear();

               
                string fornamn = läsare.ReadLine();

                

                while(fornamn != null)
                {
                    kontakter.Add(new Kontakt()
                    {
                        Förnamn = fornamn,
                        Efternamn = läsare.ReadLine(),
                        Epost = läsare.ReadLine(),
                        TelefonNummer = läsare.ReadLine()
                    });
                    ltb_kontakter.Items.Add(fornamn);
                    fornamn = läsare.ReadLine();
                }
                läsare.Dispose();

                filnamn = dlg_open.FileName;
                sparaToolStripMenuItem.Enabled = true;
                
            }
        }

        private void sparaSomToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (dlg_spara.ShowDialog() == DialogResult.OK)
            {

                FileStream utström = new FileStream(dlg_spara.FileName, FileMode.Create, FileAccess.Write);


                StreamWriter skrivare = new StreamWriter(utström);

               
                foreach(Kontakt k in kontakter)
                {
                    skrivare.WriteLine(k.Förnamn);
                    skrivare.WriteLine(k.Efternamn);
                    skrivare.WriteLine(k.Epost);
                    skrivare.WriteLine(k.TelefonNummer);
                }

                skrivare.Dispose();

                filnamn = dlg_spara.FileName;
                sparaToolStripMenuItem.Enabled = true;
            }
        }

        private void sparaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FileStream utström = new FileStream(filnamn, FileMode.Create, FileAccess.Write);
            
            
            StreamWriter skrivare = new StreamWriter(utström);



            
            
            
            foreach (Kontakt k in kontakter)
            {
                skrivare.WriteLine(k.Förnamn);
                skrivare.WriteLine(k.Efternamn);
                skrivare.WriteLine(k.Epost);
                skrivare.WriteLine(k.TelefonNummer);
            }
            
            skrivare.Dispose();
        }

        private void läggTillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            kontakter.Add(new Kontakt()
            {
                Förnamn = tbx_förnamn.Text,
                Efternamn = tbx_efternamn.Text,
                Epost = tbx_epost.Text,
                TelefonNummer = tbx_telefon.Text
            });

            
            ltb_kontakter.Items.Add(tbx_förnamn.Text);
        }

        private void taBortToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            int index = ltb_kontakter.SelectedIndex;
            ltb_kontakter.Items.RemoveAt(index);
            kontakter.RemoveAt(index);
            
        }

        private void ltb_kontakter_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            try
            {
                tbx_förnamn.Text = kontakter.ElementAt(ltb_kontakter.SelectedIndex).Förnamn;
                tbx_efternamn.Text = kontakter.ElementAt(ltb_kontakter.SelectedIndex).Efternamn;
                tbx_epost.Text = kontakter.ElementAt(ltb_kontakter.SelectedIndex).Epost;
                tbx_telefon.Text = kontakter.ElementAt(ltb_kontakter.SelectedIndex).TelefonNummer;
            }catch(Exception ex)
            {

            }
        }
    }
}
