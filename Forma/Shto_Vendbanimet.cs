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
    public partial class Shto_Vendbanimet : Form
    {
        public int idQyteti = 0;
        public Shto_Vendbanimet()
        {
            InitializeComponent();
            FillCombobox();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Shto_Vendbanimet_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            int selectedIndex = cmb.SelectedIndex;
            int selectedValue = (int)cmb.SelectedValue;
            idQyteti = selectedValue;
            Console.WriteLine(idQyteti);
        }

        private void FillCombobox()
        {
            
            
            DataSet ds = new DataSet();
            DB db = new DB();
            try
            {
                

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM `qyteti`", db.getConnection());


                db.openConnection();


                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                comboBox1.DisplayMember = "emri_qytetit";
                comboBox1.ValueMember = "id";
                comboBox1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                //Exception Message
            }
            finally
            {
                db.closeConnection();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `vendbanimi`(`emri_vendbanimit`, `id_qyteti`) VALUES (@ev, @iq)", db.getConnection());

            command.Parameters.Add("@ev", MySqlDbType.VarChar).Value = emri_textbox.Text;
            command.Parameters.Add("@iq", MySqlDbType.VarChar).Value = idQyteti;

            // open the connection
            db.openConnection();

            // check if the textboxes contains the default values 
            if (emri_textbox.Text.Equals("") || idQyteti == 0)
            {
                MessageBox.Show("Mbushi te dhenat");

            }
            else
            {


                //check if this username already exists
                if (checkVendbanimi())
                {
                    MessageBox.Show("this Vendbanim already exists, select a different one", "duplicate Vendbanimi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    // execute the query
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Vendbanimi Has Been Created", "Vendbanimi Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("error 404");
                    }
                }

            }
            db.closeConnection();
        }

        private Boolean checkVendbanimi()
        {
            DB db = new DB();

            String vendbanimi = emri_textbox.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `vendbanimi` WHERE `emri_vendbanimit` = @ev", db.getConnection());

            command.Parameters.Add("@ev", MySqlDbType.VarChar).Value = vendbanimi;

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

        private void vendbanim_button_B_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `vendbanimi`(`emri_vendbanimit`, `id_qyteti`) VALUES (@ev, @iq)", db.getConnection());

            command.Parameters.Add("@ev", MySqlDbType.VarChar).Value = emri_textbox.Text;
            command.Parameters.Add("@iq", MySqlDbType.VarChar).Value = idQyteti;

            // open the connection
            db.openConnection();

            // check if the textboxes contains the default values 
            if (emri_textbox.Text.Equals("") || idQyteti == 0)
            {
                MessageBox.Show("Mbushi te dhenat");

            }
            else
            {


                //check if this username already exists
                if (checkVendbanimi())
                {
                    MessageBox.Show("this Vendbanim already exists, select a different one", "duplicate Vendbanimi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    // execute the query
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Vendbanimi Has Been Created", "Vendbanimi Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("error 404");
                    }
                }

            }
            db.closeConnection();
        }
    }
}
