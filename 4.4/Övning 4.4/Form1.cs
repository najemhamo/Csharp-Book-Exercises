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

namespace Övning_4._4
{
    public partial class Form1 : Form
    {
        
        List<Ingrediens> ingredienser = new List<Ingrediens>();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // En Ingrediens klass adderas till listan ingredienser
            ingredienser.Add(new Ingrediens()
            {
                Namn = tbx_ingrediens.Text,
                Mått = tbx_mått.Text,
                Mängd = double.Parse(tbx_mängd.Text)
            
            });

            // En ny rad adderas
            
                dgv_listan.Rows.Add();
            
            
            //Datan adderas till en ny rad i tabellen
            dgv_listan.Rows[ingredienser.Count -1].Cells[0].Value = tbx_ingrediens.Text;
            dgv_listan.Rows[ingredienser.Count - 1].Cells[1].Value = tbx_mängd.Text;
            dgv_listan.Rows[ingredienser.Count - 1].Cells[2].Value = tbx_mått.Text;

            

            
        }

        private void sparaSomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if(dlg_spara.ShowDialog() == DialogResult.OK)
            {
                // En utsröm skapas
                FileStream utström = new FileStream(dlg_spara.FileName,FileMode.Create,FileAccess.Write);

                // Vi använder BinaryWriter för att skriva i filen
                BinaryWriter bn = new BinaryWriter(utström);

                // Vi skiver först antal ingredienser
                bn.Write(ingredienser.Count);

                // Sedan skriver vi datan
                foreach(Ingrediens ing in ingredienser)
                {
                    bn.Write(ing.Namn);
                    bn.Write(ing.Mängd);
                    bn.Write(ing.Mått);    
                }
                bn.Dispose();
            }
        }

        private void öppnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dlg_open.ShowDialog() == DialogResult.OK)
            {
                // Vi läser inström från filen
                FileStream inström = new FileStream(dlg_open.FileName,FileMode.Open,FileAccess.Read);

                // Vi använder en BinaryReader för att läsa inström
                BinaryReader br = new BinaryReader(inström);

                // Tabellen och listan rensas från allt data
                dgv_listan.Rows.Clear();
                ingredienser.Clear();

                // Antal ingredienser läsas från filen
                int antal = br.ReadInt32();

                for(int i = 0; i < antal; i++)
                {

                    // Allt data läsas från filen och läggs i tabellen och i listan
                    string namn = br.ReadString();
                    double mängd = br.ReadDouble();
                    string mått = br.ReadString();
                    ingredienser.Add(new Ingrediens()
                    {
                        Namn = namn,
                        Mängd = mängd,
                        Mått = mått

                    });
                    dgv_listan.Rows.Add();

                    dgv_listan.Rows[i].Cells[0].Value = namn;
                    dgv_listan.Rows[i].Cells[1].Value = mängd;
                    dgv_listan.Rows[i].Cells[2].Value = mått;
                }

                br.Dispose();

            }
        }

     
        private void btn_tabort_Click(object sender, EventArgs e)
        {
            // Den tar bort en rad från tabellen
            int selected = dgv_listan.CurrentCell.OwningRow.Index;
            dgv_listan.Rows.RemoveAt(selected);

            ingredienser.RemoveAt(selected);
        }

      
    }
}
