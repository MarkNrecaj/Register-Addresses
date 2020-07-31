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
    public partial class Vendbanimet_adm : Form
    {
        Panel panela = Application.OpenForms["Main_admin"].Controls["panelview"] as Panel;
        private int Row = -1;
        private int Column = -1;
        public int vendbanimID = 0;
        public Vendbanimet_adm()
        {
            InitializeComponent();
            fshivendbanimin_button_B.Enabled = false;
            perditesovendbanim_button_B.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string emri_vb = dataview_vendbanimet.Rows[Row].Cells[1].Value.ToString();

            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("Update `vendbanimi` set emri_vendbanimit='" + emri_vb +
                "' WHERE id =" + vendbanimID, db.getConnection());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);


            db.closeConnection();
            shfaqvendbanim();
        }
        private void shfaqvendbanimet_button_Click(object sender, EventArgs e)
        {
            shfaqvendbanim();
        }
        public void shfaqvendbanim()
        {
            vendbanimID = 0;
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT v.id,v.emri_vendbanimit as 'Vendbanimi' ,v.id_qyteti ,q.emri_qytetit as 'Qyteti' FROM `vendbanimi` v inner join qyteti q on v.id_qyteti=q.id", db.getConnection());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            db.closeConnection();

            dataview_vendbanimet.DataSource = dtbl;
        }

        private void shtovenbanim_button_Click(object sender, EventArgs e)
        {
            panela.Controls.Clear();
            Shto_Vendbanimet shto_vendbanim = new Shto_Vendbanimet();
            shto_vendbanim.TopLevel = false;
            panela.Controls.Add(shto_vendbanim);
            shto_vendbanim.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            shto_vendbanim.Dock = DockStyle.Fill;
            shto_vendbanim.Show();
        }

        private void fshivendbanimin_button_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("DELETE FROM `vendbanimi` WHERE id =" + vendbanimID, db.getConnection());
            DataTable dtbl = new DataTable();
            
            sqlDa.Fill(dtbl);

            db.closeConnection();
            shfaqvendbanim();
        }

        private void dataview_vendbanimet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string s = dataview_vendbanimet.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            MessageBox.Show("Id: " + s + " u selektua");
            //Rregullo errorin

            try
            {
                vendbanimID = Int32.Parse(s);
            }
            catch (Exception ex)
            {

            }

            if (vendbanimID > 0)
            {
                Row = e.RowIndex;
                Column = e.ColumnIndex;

                fshivendbanimin_button_B.Enabled = true;
                perditesovendbanim_button_B.Enabled = true;

            }
        }

        private void shtovenbanim_button_B_Click(object sender, EventArgs e)
        {
            panela.Controls.Clear();
            Shto_Vendbanimet shto_vendbanim = new Shto_Vendbanimet();
            shto_vendbanim.TopLevel = false;
            panela.Controls.Add(shto_vendbanim);
            shto_vendbanim.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            shto_vendbanim.Dock = DockStyle.Fill;
            shto_vendbanim.Show();
        }

        private void perditesovendbanim_button_B_Click(object sender, EventArgs e)
        {
            string emri_vb = dataview_vendbanimet.Rows[Row].Cells[1].Value.ToString();

            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("Update `vendbanimi` set emri_vendbanimit='" + emri_vb +
                "' WHERE id =" + vendbanimID, db.getConnection());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);


            db.closeConnection();
            shfaqvendbanim();
        }

        private void fshivendbanimin_button_B_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("DELETE FROM `vendbanimi` WHERE id =" + vendbanimID, db.getConnection());
            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);

            db.closeConnection();
            shfaqvendbanim();
        }
    }
}
