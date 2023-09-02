using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3._7
{
    public partial class Form1 : Form
    {

        private List<Match> macher = new List<Match>();
        int SelectedRow = 0;

        public Form1()
        {
            InitializeComponent();
        }

      

        private void dvgMatcher_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Index 
            int i = e.RowIndex; 

         
            if(e.ColumnIndex == 0)
            {
                macher[i].HemmaLag = (string)dvgMatcher.Rows[i].Cells[0].Value;
            }else if (e.ColumnIndex == 1)
            {
                macher[i].BortaLag = (string)dvgMatcher.Rows[i].Cells[1].Value;
            }else if (e.ColumnIndex == 2)
            {
                macher[i].MålhemmaLag = int.Parse((string)dvgMatcher.Rows[i].Cells[2].Value);
            }
            else if (e.ColumnIndex == 3)
            {
                macher[i].MålBortaLag = int.Parse((string)dvgMatcher.Rows[i].Cells[3].Value);
            }
        }

        private void dvgMatcher_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
        
            macher.Add(new Match());
        }

        private void btn_målrikast_Click(object sender, EventArgs e)
        {

            string hemmalag = "";
            string bortalag = "";
            int antalMål = 0;

           
            for (int i = 0; i < macher.Count; i++)
            {
                if(macher[i].MålhemmaLag + macher[i].MålBortaLag > antalMål)
                {
                    hemmalag = macher[i].HemmaLag;
                    bortalag = macher[i].BortaLag;
                    antalMål = macher[i].MålhemmaLag + macher[i].MålBortaLag;
                }
            }

           
            tbx_målrikast.Text = hemmalag + " " + bortalag + ": " + antalMål;
        }

        private void dvgMatcher_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
       
            macher.RemoveAt(e.Row.Index);


        }

        private void btn_största_Click(object sender, EventArgs e)
        {
            string hemmalag = "";
            string bortalag = "";
            int Målskillnad = 0;

            for (int i = 0; i < macher.Count; i++)
            {
                if (Math.Abs(macher[i].MålhemmaLag - macher[i].MålBortaLag) > Målskillnad)
                {
                    hemmalag = macher[i].HemmaLag;
                    bortalag = macher[i].BortaLag;
                    Målskillnad = Math.Abs(macher[i].MålhemmaLag - macher[i].MålBortaLag);
                }
            }

            tbx_målrikast.Text = hemmalag + " " + bortalag + ": " + Målskillnad;
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
          

            Match m;
            m = macher[SelectedRow - 1];

            macher[SelectedRow - 1] = macher[SelectedRow];

            macher[SelectedRow] = m;
            
         
            for(int i = SelectedRow -1;i <= SelectedRow; i++)
            {
                dvgMatcher.Rows[i].Cells[0].Value = macher[i].HemmaLag;
                dvgMatcher.Rows[i].Cells[1].Value = macher[i].BortaLag;
                dvgMatcher.Rows[i].Cells[2].Value = macher[i].MålhemmaLag;
                dvgMatcher.Rows[i].Cells[3].Value = macher[i].MålBortaLag;
            }
            
        }

        private void dvgMatcher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dvgMatcher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            SelectedRow = e.RowIndex;


        }

        private void btn_ner_Click(object sender, EventArgs e)
        {
   
            Match m;
            m = macher[SelectedRow + 1];

            macher[SelectedRow + 1] = macher[SelectedRow];

            macher[SelectedRow] = m;


         
            for (int i = SelectedRow; i <= SelectedRow +1; i++)
            {
                dvgMatcher.Rows[i].Cells[0].Value = macher[i].HemmaLag;
                dvgMatcher.Rows[i].Cells[1].Value = macher[i].BortaLag;
                dvgMatcher.Rows[i].Cells[2].Value = macher[i].MålhemmaLag;
                dvgMatcher.Rows[i].Cells[3].Value = macher[i].MålBortaLag;
            }
        }
    }
}
