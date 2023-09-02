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

namespace Övning_6._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void VisaElever()
        {
            col1.Visible = true;
            col2.Visible = true;
            col3.Visible = true;
            col4.Visible = false;
            col5.Visible = false;
            dataVy.Columns[0].HeaderText = "PersonNr";
            dataVy.Columns[1].HeaderText = "Förnamn";
            dataVy.Columns[2].HeaderText = "Efternamn";
            dataVy.Rows.Clear();

            try
            {
                using (var db = new SkolDBEntities())
                {
                    var urval = from elev in db.Elever select elev;
                    foreach (var elev in urval)
                    {
                        dataVy.Rows.Add(elev.PersonNr, elev.Förnamn, elev.Efternamn);
                    }

                }
            }catch(Exception error)
            {
                MessageBox.Show(error.Message,null,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

       
        private void VisaBöcker()
        {
            col1.Visible = true;
            col2.Visible = true;
            col3.Visible = true;
            col4.Visible = true;
            col5.Visible = true;
            dataVy.Columns[0].HeaderText = "BokNr";
            dataVy.Columns[1].HeaderText = "Title";
            dataVy.Columns[2].HeaderText = "Ämne";
            dataVy.Columns[3].HeaderText = "PersonNr";
            dataVy.Columns[4].HeaderText = "Lånedatum";
            dataVy.Rows.Clear();
            try
            {
                using (var db = new SkolDBEntities())
                {
                    var urval = from bok in db.Böker select bok;
                    foreach (var bok in urval)
                    {
                        dataVy.Rows.Add(bok.BokNr, bok.Title, bok.Ämne, bok.PersonNr, bok.Lånedatum);
                    }
                }
            }catch(Exception error)
            {
                MessageBox.Show(error.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        
        private void VisaKurser()
        {
            col1.Visible = true;
            col2.Visible = true;
            col3.Visible = true;
            col4.Visible = false;
            col5.Visible = false;

            dataVy.Columns[0].HeaderText = "Kurskod";
            dataVy.Columns[1].HeaderText = "Kursnamn";
            dataVy.Columns[2].HeaderText = "Poäng";
            dataVy.Rows.Clear();

            try
            {
                using (var db = new SkolDBEntities())
                {
                    var urval = from kurs in db.Kurser select kurs;
                    foreach (var kurs in urval)
                    {
                        dataVy.Rows.Add(kurs.Kurskod, kurs.Kursnamn, kurs.Poäng);

                    }
                }
            }catch(Exception error)
            {
                MessageBox.Show(error.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        
        private void VisaLedigaBöcker()
        {
            col1.Visible = true;
            col2.Visible = true;
            col3.Visible = true;
            col4.Visible = false;
            col5.Visible = false;
            dataVy.Columns[0].HeaderText = "BokNr";
            dataVy.Columns[1].HeaderText = "Title";
            dataVy.Columns[2].HeaderText = "Ämne";
           
            dataVy.Rows.Clear();

            try
            {
                using (var db = new SkolDBEntities())
                {
                    var urval = from bok in db.Böker where bok.PersonNr == null select bok;

                    foreach (var bok in urval)
                    {
                        dataVy.Rows.Add(bok.BokNr, bok.Title, bok.Ämne, bok.PersonNr, bok.Lånedatum);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        
        private void VisaLånadeBöcker(string personNr)
        {
            col1.Visible = true;
            col2.Visible = true;
            col3.Visible = true;
            col4.Visible = true;
            col5.Visible = true;
            dataVy.Columns[0].HeaderText = "BokNr";
            dataVy.Columns[1].HeaderText = "Title";
            dataVy.Columns[2].HeaderText = "Ämne";
            dataVy.Columns[3].HeaderText = "PersonNr";
            dataVy.Columns[4].HeaderText = "Lånedatum";
            dataVy.Rows.Clear();

            try
            {
                using (var db = new SkolDBEntities())
                {
                    var urval = from bok in db.Böker where bok.PersonNr == personNr select bok;
                    foreach (var bok in urval)
                    {
                        dataVy.Rows.Add(bok.BokNr, bok.Title, bok.Ämne, bok.PersonNr, bok.Lånedatum);
                    }
                }
            }catch(Exception error)
            {
                MessageBox.Show(error.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        
        private void VisaKursGrupp(string kurskod)
        {
            col1.Visible = true;
            col2.Visible = true;
            col3.Visible = true;
            col4.Visible = false;
            col5.Visible = false;
            dataVy.Columns[0].HeaderText = "PersonNr";
            dataVy.Columns[1].HeaderText = "Förnamn";
            dataVy.Columns[2].HeaderText = "Efternamn";
            dataVy.Rows.Clear();

            try
            {
                using (var db = new SkolDBEntities())
                {
                    var urval = from elev in db.Elever from kurs in elev.Kurser where kurs.Kurskod == kurskod select elev;
                    foreach (var elev in urval)
                    {
                        dataVy.Rows.Add(elev.PersonNr, elev.Förnamn, elev.Efternamn);
                    }

                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void VisaElevKurser(string personNr)
        {
            col1.Visible = true;
            col2.Visible = true;
            col3.Visible = true;
            col4.Visible = false;
            col5.Visible = false;
            dataVy.Columns[0].HeaderText = "Kurskod";
            dataVy.Columns[1].HeaderText = "Kursnamn";
            dataVy.Columns[2].HeaderText = "Poäng";
            dataVy.Rows.Clear();

            try
            {
                using (var db = new SkolDBEntities())
                {
                    var urval = from kurs in db.Kurser from elev in kurs.Elever where elev.PersonNr == personNr select kurs;

                    
                    foreach (var kurs in urval)
                    {
                        dataVy.Rows.Add(kurs.Kurskod, kurs.Kursnamn, kurs.Poäng);

                    }
                }
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
       
        
        private void btn_elev_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new SkolDBEntities())
                {
                    Elev elev = new Elev();
                    elev.PersonNr = tbx_personNr.Text;
                    elev.Förnamn = tbx_förnamn.Text;
                    elev.Efternamn = tbx_efternamn.Text;

                    db.Elever.Add(elev);
                    db.SaveChanges();
                }
            }catch(Exception error)
            {

                MessageBox.Show(error.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void btn_kurs_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new SkolDBEntities())
                {
                    Kurser kurs = new Kurser
                    {
                        Kurskod = tbx_kusrkod.Text,
                        Kursnamn = tbx_kursnamn.Text,
                        Poäng = int.Parse(tbx_poäng.Text)

                    };

                    db.Kurser.Add(kurs);
                    db.SaveChanges();

                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void btn_bok_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new SkolDBEntities())
                {
                    Böker bok = new Böker
                    {
                        Title = tbx_titel.Text,
                        Ämne = tbx_ämne.Text
                        
                    };

                    db.Böker.Add(bok);
                    db.SaveChanges();
                }
            }catch (Exception error)
            {
                MessageBox.Show(error.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btn_lån_Click(object sender, EventArgs e)
        {
            int giltig = 0;
            int bokNr;
            if(! int.TryParse(tbx_bokNrLån.Text,out bokNr))
            {
                MessageBox.Show("Fel, du måste ange en giltig siffra", null, MessageBoxButtons.OK,MessageBoxIcon.Error);
                giltig += 1;
            }

            DateTime datum;
            if (! DateTime.TryParse(tbx_datum.Text, out datum))
            {
                MessageBox.Show("Fel, du måste ange en giltig Datum", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                giltig += 1;
            }
            if (giltig == 0)
            {
                try
                {
                    using (var db = new SkolDBEntities())
                    {
                        
                        var urval = from bok in db.Böker where bok.BokNr == bokNr select bok;

                        urval.First().PersonNr = tbx_personNrBöcker.Text;
                        urval.First().Lånedatum = datum;
                        db.SaveChanges();
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,null,MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
       
        private void btn_kursval_Click(object sender, EventArgs e)
        {


            try
            {
                using (var db = new SkolDBEntities())
                {
                    var urval = from elev in db.Elever where elev.PersonNr == tbx_personNrVal.Text select elev;
                    var urval2 = from Kurs in db.Kurser where Kurs.Kurskod == tbx_kurskodVal.Text select Kurs;

                    urval.First().Kurser.Add(urval2.First());
                    urval2.First().Elever.Add(urval.First());

                    db.SaveChanges();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_uppdate_Click(object sender, EventArgs e)
        {
            if (cmdVisaMeny.SelectedIndex == 0)
            {
                tbx_data.Enabled = false;
                VisaElever();
            }
            else if (cmdVisaMeny.SelectedIndex == 1)
            {
                tbx_data.Enabled = false;
                VisaBöcker();
            }
            else if (cmdVisaMeny.SelectedIndex == 2)
            {
                tbx_data.Enabled = false;
                VisaKurser();
            }
            else if (cmdVisaMeny.SelectedIndex == 3)
            {
                tbx_data.Enabled = false;
                VisaLedigaBöcker();
            }
            else if (cmdVisaMeny.SelectedIndex == 4)
            {
                tbx_data.Enabled = true;
                VisaLånadeBöcker(tbx_data.Text);
            }
            else if (cmdVisaMeny.SelectedIndex == 5)
            {
                tbx_data.Enabled = true;
                VisaKursGrupp(tbx_data.Text);
            }
        }
        private void cmdVisaMeny_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmdVisaMeny.SelectedIndex == 0)
            {
                tbx_data.Enabled = false;
                VisaElever();
            }
            else if (cmdVisaMeny.SelectedIndex == 1)
            {
                tbx_data.Enabled = false;
                VisaBöcker();
            }
            else if (cmdVisaMeny.SelectedIndex == 2)
            {
                tbx_data.Enabled = false;
                VisaKurser();
            }
            else if (cmdVisaMeny.SelectedIndex == 3)
            {
                tbx_data.Enabled = false;
                VisaLedigaBöcker();
            }
            else if (cmdVisaMeny.SelectedIndex == 4)
            {
                tbx_data.Enabled = true;
                VisaLånadeBöcker(tbx_data.Text);
            }
            else if (cmdVisaMeny.SelectedIndex == 5)
            {
                tbx_data.Enabled = true;
                VisaKursGrupp(tbx_data.Text);
            }
        }

       
    }
}
