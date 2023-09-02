using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Övning_1._6
{
    public partial class Form1 : Form
    {
        Excel.Application excel;
        Excel._Worksheet kalkylBlad;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_öppna_Click(object sender, EventArgs e)
        { 
            // Appen Excel öppnas
            excel = new Excel.Application();
            excel.Visible = true;

            excel.Workbooks.Add();
            kalkylBlad = excel.ActiveSheet;
        }

        private void btn_exp_Click(object sender, EventArgs e)
        { 
           
            int rad = int.Parse(tbx_rad.Text);

           
            Excel.Range celA = kalkylBlad.Cells[rad, "A"];
            Excel.Range celB = kalkylBlad.Cells[rad, "B"];
            Excel.Range celC = kalkylBlad.Cells[rad, "C"];


            // Värden sätts i cellerna
            celA.Value = tbx_namn.Text;
            celB.Value = tbx_kurs.Text;
            celC.Value = tbx_klass.Text;
        }

        private void btn_spa_Click(object sender, EventArgs e)
        {
            // Excel sparas i Dokument och stängs
            kalkylBlad.SaveAs("Excel Test.xlsx");
            excel.Quit();
        }

        private void btn_imp_Click(object sender, EventArgs e)
        {
            
            int rad = int.Parse(tbx_rad.Text);


            
            Excel.Range celA = kalkylBlad.Cells[rad, "A"];
            Excel.Range celB = kalkylBlad.Cells[rad, "B"];
            Excel.Range celC = kalkylBlad.Cells[rad, "C"];

            
            tbx_namn.Text = celA.Text;
            tbx_kurs.Text = celB.Text;
            tbx_klass.Text = celC.Text;
        }
    }
}
