
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
    public partial class LoginForm : Form
    {
        public String us;
        public static string usernameAcc = "";

        public LoginForm()
        {
            InitializeComponent();
        }


        private void login_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        

        private void password_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            us = username_textbox.Text;

            String username = username_textbox.Text;
            String password = password_textbox.Text;
            if (username.Trim().Equals(""))
            {
                MessageBox.Show("Sheno usernamin per te bere login", "Username i thatë", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password.Trim().Equals(""))
            {
                MessageBox.Show("Sheno Fjalëkalimin per te bere login", "Fjalëkalimi i thatë", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Console.WriteLine(username);
                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `puntori` WHERE `username` = @usn and `password` = @pass", db.getConnection());

                // MySqlCommand command2 = new MySqlCommand("SELECT admin FROM `puntori` WHERE `username` = @usn and `password` = @pass", db.getConnection());
                command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;


                adapter.SelectCommand = command;

                adapter.Fill(table);
                //Console.WriteLine(table.Rows.Count + "uuu");

                // check if the user exists or not
                if (table.Rows.Count > 0)
                {
                    this.Hide();
                    usernameAcc = table.Rows[0].ItemArray[5] + "";
                    Console.WriteLine(usernameAcc);
                    bool admin = (bool)table.Rows[0].ItemArray[7];
                    if (admin)
                    {
                        Main_admin main_admin = new Main_admin();
                        main_admin.Show();
                    }
                    else
                    {
                        Main_Puntori main_punetori = new Main_Puntori();
                        main_punetori.Show();
                    }


                    //MainForm mainform = new MainForm();
                    //Console.WriteLine("PAssi mire");
                    //mainform.Show();
                }
                else
                {



                    MessageBox.Show("Username ose Fjalëkalimi eshte Gabim", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
