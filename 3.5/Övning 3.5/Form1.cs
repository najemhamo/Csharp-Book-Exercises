using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3._5
{
    public partial class Form1 : Form
    {
       

        TabControl tb = new TabControl();
        TabPage tbgMusik = new TabPage();
        TabPage tbgFilm = new TabPage();
        TabPage tbgAppar = new TabPage();
        TabPage tbgLjud = new TabPage();
        TabPage tbgradio = new TabPage();

        public Form1()
        {
            InitializeComponent();

         
            tb.Size = new Size(480, 320);
            tb.Location = new Point(20,20);
            
            
            tb.Controls.Add(tbgMusik);
            tb.Controls.Add(tbgFilm);
            tb.Controls.Add(tbgLjud);
            tb.Controls.Add(tbgradio);
            tb.Controls.Add(tbgAppar);

            
            tbgMusik.Text = "Musik";
            tbgFilm.Text = "Film"; 
            tbgLjud.Text = "Ljudböcker";
            tbgradio.Text = "Podradio";
            tbgAppar.Text = "Appar";


           
            tbgMusik.BackColor = Color.White;
            tbgFilm.BackColor = Color.White;
            tbgLjud.BackColor = Color.White;
            tbgradio.BackColor = Color.White;
            tbgAppar.BackColor = Color.White;

            this.Controls.Add(tb);
            
        }
    }
}
