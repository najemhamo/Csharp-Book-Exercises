using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Övning_6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sök_Click(object sender, EventArgs e)
        {
            try
            {
              
                string path = Path.GetFullPath("..\\..\\KundRegister.mdf");

               
                string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";

             
                string query = "SELECT Förnamn, Efternamn FROM Kunder WHERE PersonNr =" + tbx_personnummer.Text;

              
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    connection.Open();
              
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                       
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            tbx_resultat.AppendText(reader.GetString(0) + " " + reader.GetString(1) + "\n");
                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdb_person_CheckedChanged(object sender, EventArgs e)
        {

            pnl_person.Visible = true;
            pnl_sql.Visible = false;
        }

        private void rdb_sql_CheckedChanged(object sender, EventArgs e)
        {
            pnl_sql.Visible = true;
            pnl_person.Visible = false;

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.GetFullPath("..\\..\\KundRegister.mdf");

                string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";

              
                string query = tbx_sql.Text;

                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                       
                        command.ExecuteNonQuery();

                        MessageBox.Show("Insert secceded", null,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
            }catch(Exception error)
            {
                MessageBox.Show(error.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void btn_select_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.GetFullPath("..\\..\\KundRegister.mdf");

                string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";

           
                string query = tbx_sql.Text;

                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                           
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                tbx_sqlResultat.AppendText(reader.GetString(i) + " ");
                            }
                            tbx_sqlResultat.AppendText("\n");
                        }
                        reader.Close();
                    }
                }
            }catch(Exception error)
            {
                MessageBox.Show(error.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
