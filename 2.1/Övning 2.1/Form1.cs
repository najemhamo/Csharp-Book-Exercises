using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_2._1
{
    public partial class Form1 : Form
    {
        //lista med olika medier
        List<Media> media = new List<Media>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            // Median adderas till listan
            if (rdb_bok.Checked)
            {
                Bok b = new Bok(int.Parse(tbx_sidor.Text),tbx_title.Text);
                media.Add(b);
            }
            else if (rdb_film.Checked)
            {
                Film f = new Film(tbx_Uppplösning.Text,tbx_title.Text,int.Parse(tbx_tid.Text));
                media.Add(f);
            }
            else
            {
                Ljudspår ls = new Ljudspår(int.Parse(tbx_tid.Text),tbx_title.Text);
                media.Add(ls);
            } 
            lbx_lista.Items.Clear();

            foreach(Media m in media)
            {
                lbx_lista.Items.Add(m.ToString());
            }
        }
    }
}
