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

namespace Projekt_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void öppnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dlg_öppna.ShowDialog() == DialogResult.OK)
            {
                
                FileStream inström = new FileStream(dlg_öppna.FileName,FileMode.Open,FileAccess.Read);

                StreamReader läsare = new StreamReader(inström);

                // Alla rader i tabellen raderas
                dgv_lista.Rows.Clear();

                // Första raden i filen läsas
                string rad = läsare.ReadLine();
                int radIndex = 0;
                while(rad != null)
                {
                    // Raden deles till fyra delar beroende på tecknet ;
                    string[] celler = rad.Split(';');
                    int celIndex = 0;
                    dgv_lista.Rows.Add();
                    foreach (string s in celler)
                    {
                        // Värdet läggs i tabllen
                        dgv_lista.Rows[radIndex].Cells[celIndex].Value = s;
                        celIndex += 1;
                    }
                    radIndex += 1;

                    // Programmet läsar nästa rad i filen
                    rad = läsare.ReadLine();
                }
                läsare.Dispose();
            }
        }

        private void sparaSomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dlg_spara.ShowDialog() == DialogResult.OK)
            {
                FileStream utström = new FileStream(dlg_spara.FileName, FileMode.Create, FileAccess.Write);

                StreamWriter skrivare = new StreamWriter(utström);

                // Alla rader i tebellen läsas 
                foreach(DataGridViewRow row in dgv_lista.Rows)
                {
                    string rad = "";
                    // Alla värden i varje rad i tabellen samlas i en sträng med tecknet ; i mellan
                    for(int i = 0;i < 4; i++)
                    {
                        string tec = "";
                        if(i != 3)
                        {
                            tec = ";";
                        }
                        rad = rad + row.Cells[i].Value + tec; 
                    }
                    // Strängen skrivs i filen
                    skrivare.WriteLine(rad);
                }
                skrivare.Dispose();
            }
        }
    }
}
