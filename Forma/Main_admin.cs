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
    public partial class Main_admin : Form
    {
        
        
        public Main_admin()
        {
            InitializeComponent();
            user_acc1.Text = LoginForm.usernameAcc;

            
          
          
        }

        

        private void puntoret_button_Click(object sender, EventArgs e)
        {
            panelview.Controls.Clear();
            Puntoret_adm puntoret_adm = new Puntoret_adm();
            puntoret_adm.TopLevel = false;
            panelview.Controls.Add(puntoret_adm);
            puntoret_adm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            puntoret_adm.Dock = DockStyle.Fill;
            puntoret_adm.Show();
            puntoret_adm.shfaqPunetort();

        }

    

        private void panelview_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void username_Click(object sender, EventArgs e)
        {

        }
        public void fshijpanelin()
        {
            panelview.Controls.Clear();
        }
        public void addpanelin(Form o)
        {
            panelview.Controls.Add(o);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void qytetet_button_Click(object sender, EventArgs e)
        {
            panelview.Controls.Clear();
            Qytetet_adm1 shfaq_qytet = new Qytetet_adm1();
            shfaq_qytet.TopLevel = false;
            panelview.Controls.Add(shfaq_qytet);
            shfaq_qytet.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            shfaq_qytet.Dock = DockStyle.Fill;
            shfaq_qytet.Show();
            shfaq_qytet.shfaqqytetet();

        }

        private void vendbanimet_button_Click(object sender, EventArgs e)
        {
            panelview.Controls.Clear();
            Vendbanimet_adm shfaq_vendbanimet = new Vendbanimet_adm();
            shfaq_vendbanimet.TopLevel = false;
            panelview.Controls.Add(shfaq_vendbanimet);
            shfaq_vendbanimet.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            shfaq_vendbanimet.Dock = DockStyle.Fill;
            shfaq_vendbanimet.Show();
            shfaq_vendbanimet.shfaqvendbanim();
        }

        private void qytetaret_button1_Click(object sender, EventArgs e)
        {
            panelview.Controls.Clear();
            Qytetaret_Admin shfaq_qytetaret = new Qytetaret_Admin();
            shfaq_qytetaret.TopLevel = false;
            panelview.Controls.Add(shfaq_qytetaret);
            shfaq_qytetaret.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            shfaq_qytetaret.Dock = DockStyle.Fill;
            shfaq_qytetaret.Show();
            shfaq_qytetaret.ShfaqQytetaret();
        }

        private void qytetaret_button1_Click_1(object sender, EventArgs e)
        {
            panelview.Controls.Clear();
            Qytetaret_Admin shfaq_qytetaret = new Qytetaret_Admin();
            shfaq_qytetaret.TopLevel = false;
            panelview.Controls.Add(shfaq_qytetaret);
            shfaq_qytetaret.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            shfaq_qytetaret.Dock = DockStyle.Fill;
            shfaq_qytetaret.Show();
            shfaq_qytetaret.ShfaqQytetaret();
        }

        private void vendbanimet_button_bunifu_Click(object sender, EventArgs e)
        {
            panelview.Controls.Clear();
            Vendbanimet_adm shfaq_vendbanimet = new Vendbanimet_adm();
            shfaq_vendbanimet.TopLevel = false;
            panelview.Controls.Add(shfaq_vendbanimet);
            shfaq_vendbanimet.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            shfaq_vendbanimet.Dock = DockStyle.Fill;
            shfaq_vendbanimet.Show();
            shfaq_vendbanimet.shfaqvendbanim();
        }

        private void qytetet_button_bunifu_Click(object sender, EventArgs e)
        {
            panelview.Controls.Clear();
            Qytetet_adm1 shfaq_qytet = new Qytetet_adm1();
            shfaq_qytet.TopLevel = false;
            panelview.Controls.Add(shfaq_qytet);
            shfaq_qytet.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            shfaq_qytet.Dock = DockStyle.Fill;
            shfaq_qytet.Show();
            shfaq_qytet.shfaqqytetet();
        }

        private void puntoret_button_bunifu_Click(object sender, EventArgs e)
        {
            panelview.Controls.Clear();
            Puntoret_adm puntoret_adm = new Puntoret_adm();
            puntoret_adm.TopLevel = false;
            panelview.Controls.Add(puntoret_adm);
            puntoret_adm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            puntoret_adm.Dock = DockStyle.Fill;
            puntoret_adm.Show();
            puntoret_adm.shfaqPunetort();
        }

        private void logout_button_bunifu_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
