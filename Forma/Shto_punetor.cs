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
    public partial class Shto_punetor : Form
    {
        public int idqyteti;
        public Shto_punetor()
        {
            InitializeComponent();
            FillCombobox();
        }

    private void shto_button_Click(object sender, EventArgs e)
    {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `puntori`(`emri`, `mbiemri`,`nr_telefonit`, `email`, `username`, `password`,`admin`,`id_qyteti`) VALUES (@fn, @ln, @phone, @email,@usn ,@pass,0,@id_q)", db.getConnection());

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = emri_textbox.Text;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = mbiemri_textbox.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email_textbox.Text;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username_textbox.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = fjalkalimi_textbox.Text;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = tel_textbox.Text;
            command.Parameters.Add("@id_q", MySqlDbType.VarChar).Value = idqyteti;
            // open the connection
            db.openConnection();

            // check if the textboxes contains the default values 
            if (emri_textbox.Text.Equals("") || mbiemri_textbox.Text.Equals("") || email_textbox.Text.Equals("") || username_textbox.Text.Equals("") || fjalkalimi_textbox.Text.Equals("") || tel_textbox.Text.Equals("")) {
                MessageBox.Show("Mbushi te dhenat");
            }
            else {
                // check if the password equal the confirm password
                if (fjalkalimi_textbox.Text.Equals(fjalkalimiconf_textbox.Text))
                {
                    // check if this username already exists
                    if (checkUsername())
                    {
                        MessageBox.Show("This Username Already Exists, Select A Different One", "Duplicate Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // execute the query
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Your Account Has Been Created", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("ERROR");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Confirmation Password", "Password Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }


            // close the connection
            db.closeConnection();

        }




        public Boolean checkUsername()
    {
        DB db = new DB();

        String username = username_textbox.Text;

        DataTable table = new DataTable();

        MySqlDataAdapter adapter = new MySqlDataAdapter();

        MySqlCommand command = new MySqlCommand("SELECT * FROM `puntori` WHERE `username` = @usn", db.getConnection());

        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;

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
    private void emri_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tel_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_label_Click(object sender, EventArgs e)
        {

        }

        private void email_label_Click(object sender, EventArgs e)
        {

        }

        private void email_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void qytetet_p_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            int selectedIndex = cmb.SelectedIndex;
            int selectedValue = (int)cmb.SelectedValue;
            idqyteti = selectedValue;
            Console.WriteLine(idqyteti);
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
                qytetet_p.DisplayMember = "emri_qytetit";
                qytetet_p.ValueMember = "id";
                qytetet_p.DataSource = ds.Tables[0];
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

        private void Shto_punetor_Load(object sender, EventArgs e)
        {

        }

        private void shto_button_B_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `puntori`(`emri`, `mbiemri`,`nr_telefonit`, `email`, `username`, `password`,`admin`,`id_qyteti`) VALUES (@fn, @ln, @phone, @email,@usn ,@pass,0,@id_q)", db.getConnection());

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = emri_textbox.Text;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = mbiemri_textbox.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email_textbox.Text;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username_textbox.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = fjalkalimi_textbox.Text;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = tel_textbox.Text;
            command.Parameters.Add("@id_q", MySqlDbType.VarChar).Value = idqyteti;
            // open the connection
            db.openConnection();

            // check if the textboxes contains the default values 
            if (emri_textbox.Text.Equals("") || mbiemri_textbox.Text.Equals("") || email_textbox.Text.Equals("") || username_textbox.Text.Equals("") || fjalkalimi_textbox.Text.Equals("") || tel_textbox.Text.Equals(""))
            {
                MessageBox.Show("Mbushi te dhenat");
            }
            else
            {
                // check if the password equal the confirm password
                if (fjalkalimi_textbox.Text.Equals(fjalkalimiconf_textbox.Text))
                {
                    // check if this username already exists
                    if (checkUsername())
                    {
                        MessageBox.Show("This Username Already Exists, Select A Different One", "Duplicate Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // execute the query
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Your Account Has Been Created", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("ERROR");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Confirmation Password", "Password Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }


            // close the connection
            db.closeConnection();
        }
    }
}
