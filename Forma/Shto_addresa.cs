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
    public partial class Shto_addresa : Form
    {
        public int vendbanimi1;
        
        public Shto_addresa(string numriPersonal)
        {
            InitializeComponent();
            FillCombobox();
            nrpersonal_textbox.Text = numriPersonal;
            
            if (numriPersonal.Length > 0)
            {
                nrpersonal_textbox.Enabled = false;
            }
            else
            {
                nrpersonal_textbox.Enabled = true;
            }
            
        }

        private void Shto_addresa_Load(object sender, EventArgs e)
        {

        }

        private int findid()
        {
            DB db = new DB();

            
            
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT id FROM `qytetari` WHERE `nr_personal` = @nrp", db.getConnection());

            command.Parameters.Add("@nrp", MySqlDbType.VarChar).Value = nrpersonal_textbox.Text;

            adapter.SelectCommand = command;

            adapter.Fill(table);
            
            // check if this username already exists in the database
            if (table.Rows.Count > 0)
            {
                int idq=(int)table.Rows[0].ItemArray[0];
                return idq;
            }
            else
            {
                return 0;
            }
            

        }

        private void shtoaddress_button_Click(object sender, EventArgs e)
        {
            int idq = findid();
            if (idq == 0)
            {
                MessageBox.Show("Ky person nuk ekziston ne databaze");
                return;
            }
            DB db = new DB();
        
        MySqlCommand command = new MySqlCommand("INSERT INTO `adresa`(`id_vendbanimi`, `id_qytetari`,`emri_rruges`, `nr_objektit`) VALUES (@vb, @qy, @rr, @ob)", db.getConnection());

            
            command.Parameters.Add("@vb", MySqlDbType.VarChar).Value =  vendbanimi1;
            command.Parameters.Add("@qy", MySqlDbType.VarChar).Value = idq;
            command.Parameters.Add("@rr", MySqlDbType.VarChar).Value = rruga_textbox.Text;
            command.Parameters.Add("@ob", MySqlDbType.VarChar).Value = nrobjektit_textbox.Text;
            // open the connection
            db.openConnection();

            // check if the textboxes contains the default values 
            if (rruga_textbox.Text.Equals("") || nrobjektit_textbox.Text.Equals("") || nrpersonal_textbox.Text.Equals("") || rruga_textbox.Text.Equals("")  ) {
                MessageBox.Show("Mbushi te dhenat");
            }
            else {
                // check if the password equal the confirm password
                
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


        db.closeConnection();

        }

        private void vendbanimi_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            int selectedIndex = cmb.SelectedIndex;
            int selectedValue = (int)cmb.SelectedValue;
            vendbanimi1 = selectedValue;
            Console.WriteLine(vendbanimi1);
        }

        private void FillCombobox()
        {


            DataSet ds = new DataSet();
            DB db = new DB();
            try
            {


                MySqlCommand cmd = new MySqlCommand("SELECT * FROM `vendbanimi`", db.getConnection());


                db.openConnection();


                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                vendbanimi_combobox.DisplayMember = "emri_vendbanimit";
                vendbanimi_combobox.ValueMember = "id";
                vendbanimi_combobox.DataSource = ds.Tables[0];
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void shtoaddress_button_B_Click(object sender, EventArgs e)
        {
            int idq = findid();
            if (idq == 0)
            {
                MessageBox.Show("Ky person nuk ekziston ne databaze");
                return;
            }
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO `adresa`(`id_vendbanimi`, `id_qytetari`,`emri_rruges`, `nr_objektit`) VALUES (@vb, @qy, @rr, @ob)", db.getConnection());


            command.Parameters.Add("@vb", MySqlDbType.VarChar).Value = vendbanimi1;
            command.Parameters.Add("@qy", MySqlDbType.VarChar).Value = idq;
            command.Parameters.Add("@rr", MySqlDbType.VarChar).Value = rruga_textbox.Text;
            command.Parameters.Add("@ob", MySqlDbType.VarChar).Value = nrobjektit_textbox.Text;
            // open the connection
            db.openConnection();

            // check if the textboxes contains the default values 
            if (rruga_textbox.Text.Equals("") || nrobjektit_textbox.Text.Equals("") || nrpersonal_textbox.Text.Equals("") || rruga_textbox.Text.Equals(""))
            {
                MessageBox.Show("Mbushi te dhenat");
            }
            else
            {
                // check if the password equal the confirm password

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


            db.closeConnection();
        }
    }




  
}
