using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistreAddress
{
    public partial class Shto_Qytet : Form
    {
        public Shto_Qytet()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `qyteti`(`emri_qytetit`, `zip_kodi`) VALUES (@qy, @zk)", db.getConnection());

            command.Parameters.Add("@qy", MySqlDbType.VarChar).Value = qyteti_textbox.Text;
            command.Parameters.Add("@zk", MySqlDbType.VarChar).Value = zip_textbox.Text;

            // open the connection
            db.openConnection();

            // check if the textboxes contains the default values 
            if (qyteti_textbox.Text.Equals("") || zip_textbox.Text.Equals(""))
            {
                MessageBox.Show("Mbushi te dhenat");

            }
            else
            {


                // check if this username already exists
                if (checkCity())
                {
                    MessageBox.Show("This City Already Exists, Select A Different One", "Duplicate City", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    // execute the query
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("City Has Been Created", "City Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ERROR 404");
                    }
                }

            }
            db.closeConnection();
        }

            private Boolean checkCity(){
                DB db = new DB();

                String city = qyteti_textbox.Text;

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `qyteti` WHERE `emri_qytetit` = @qy", db.getConnection());

                command.Parameters.Add("@qy", MySqlDbType.VarChar).Value = city;

                adapter.SelectCommand = command;

                adapter.Fill(table);

                // check if this username already exists in the database
                if (table.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                

            }

        private void button1_B_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `qyteti`(`emri_qytetit`, `zip_kodi`) VALUES (@qy, @zk)", db.getConnection());

            command.Parameters.Add("@qy", MySqlDbType.VarChar).Value = qyteti_textbox.Text;
            command.Parameters.Add("@zk", MySqlDbType.VarChar).Value = zip_textbox.Text;

            // open the connection
            db.openConnection();

            // check if the textboxes contains the default values 
            if (qyteti_textbox.Text.Equals("") || zip_textbox.Text.Equals(""))
            {
                MessageBox.Show("Mbushi te dhenat");

            }
            else
            {


                // check if this username already exists
                if (checkCity())
                {
                    MessageBox.Show("This City Already Exists, Select A Different One", "Duplicate City", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    // execute the query
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("City Has Been Created", "City Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ERROR 404");
                    }
                }

            }
            db.closeConnection();
        }
    }
}
