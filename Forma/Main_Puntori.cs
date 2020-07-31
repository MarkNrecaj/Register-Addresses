using MySql.Data.MySqlClient;
using RegistreAddress;
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

    public partial class Main_Puntori : Form
    {
        public Main_Puntori()
        {
            InitializeComponent();
            user_acc2.Text = LoginForm.usernameAcc;
        }

        private void shikoAdresat_button_Click(object sender, EventArgs e)
        {
            panelview2.Controls.Clear();
            ShikoAdresat_User shiko_adresat = new ShikoAdresat_User();
            shiko_adresat.TopLevel = false;
            panelview2.Controls.Add(shiko_adresat);
            shiko_adresat.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            shiko_adresat.Dock = DockStyle.Fill;
            shiko_adresat.Show();
            shiko_adresat.shfaqAdresat();
        }

        private void vendbanimet2_button_Click(object sender, EventArgs e)
        {
            panelview2.Controls.Clear();
            Shto_addresa shto_Addresa = new Shto_addresa("");
            shto_Addresa.TopLevel = false;
            panelview2.Controls.Add(shto_Addresa);
            shto_Addresa.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            shto_Addresa.Dock = DockStyle.Fill;
            shto_Addresa.Show();

        }

        private void shtoqytetar_button_Click(object sender, EventArgs e)
        {
            panelview2.Controls.Clear();
            Qytetaret_pun qytetaret_Pun = new Qytetaret_pun();
            qytetaret_Pun.TopLevel = false;
            panelview2.Controls.Add(qytetaret_Pun);
            qytetaret_Pun.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            qytetaret_Pun.Dock = DockStyle.Fill;
            qytetaret_Pun.Show();
            qytetaret_Pun.ShfaqQytetaret();

        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void shtoAdresat_button_bunifu_Click(object sender, EventArgs e)
        {
            panelview2.Controls.Clear();
            Shto_addresa shto_Addresa = new Shto_addresa("");
            shto_Addresa.TopLevel = false;
            panelview2.Controls.Add(shto_Addresa);
            shto_Addresa.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            shto_Addresa.Dock = DockStyle.Fill;
            shto_Addresa.Show();
        }

        private void shikoAdresat_button_bunifu_Click(object sender, EventArgs e)
        {
            panelview2.Controls.Clear();
            ShikoAdresat_User shiko_adresat = new ShikoAdresat_User();
            shiko_adresat.TopLevel = false;
            panelview2.Controls.Add(shiko_adresat);
            shiko_adresat.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            shiko_adresat.Dock = DockStyle.Fill;
            shiko_adresat.Show();
            shiko_adresat.shfaqAdresat();
        }

        private void shtoqytetar_button_bunifu_Click(object sender, EventArgs e)
        {
            panelview2.Controls.Clear();
            Qytetaret_pun qytetaret_Pun = new Qytetaret_pun();
            qytetaret_Pun.TopLevel = false;
            panelview2.Controls.Add(qytetaret_Pun);
            qytetaret_Pun.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            qytetaret_Pun.Dock = DockStyle.Fill;
            qytetaret_Pun.Show();
            qytetaret_Pun.ShfaqQytetaret();
        }

        private void logout_button_bunifu_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void chati_button_bunifu_Click(object sender, EventArgs e)
        {
            panelview2.Controls.Clear();
            Form1 chat = new Form1();
            chat.TopLevel = false;
            panelview2.Controls.Add(chat);
            chat.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            chat.Dock = DockStyle.Fill;
            chat.Show();
            
        }
    }
}
