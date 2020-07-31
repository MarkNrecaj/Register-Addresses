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
    public partial class Qytetet_adm1 : Form
    {
        Panel panela = Application.OpenForms["Main_admin"].Controls["panelview"] as Panel;
        private int Row = -1;
        private int Column = -1;
        public int qytetID=0;
        public Qytetet_adm1()
        {
            InitializeComponent();
            fshiqytet_button_B.Enabled = false;
            perditesoqytet_button_B.Enabled = false;
        }

        private void shfaqqytetet_button_Click(object sender, EventArgs e)
        {
            shfaqqytetet();
        }

        public void shfaqqytetet()
        {
            qytetID = 0;
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT * FROM `qyteti`", db.getConnection());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            db.closeConnection();

            dataview_qytetet.DataSource = dtbl;
        }

        private void Shtoqytet_button_Click(object sender, EventArgs e)
        {
            panela.Controls.Clear();
            Shto_Qytet shto_qytet = new Shto_Qytet();
            shto_qytet.TopLevel = false;
            panela.Controls.Add(shto_qytet);
            shto_qytet.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            shto_qytet.Dock = DockStyle.Fill;
            shto_qytet.Show();
        }

        private void fshiqytet_button_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("DELETE FROM `qyteti` WHERE id =" + qytetID, db.getConnection());
            MySqlDataAdapter sqlDa1 = new MySqlDataAdapter("DELETE FROM `vendbanimi` WHERE id_qyteti =" + qytetID, db.getConnection());

            DataTable dtbl = new DataTable();
            sqlDa1.Fill(dtbl);
            sqlDa.Fill(dtbl);
            

            db.closeConnection();
            shfaqqytetet();
        }

        private void perditesoqytet_button_Click(object sender, EventArgs e)
        {
            string emri_qy = dataview_qytetet.Rows[Row].Cells[1].Value.ToString();
            string zipkodi = dataview_qytetet.Rows[Row].Cells[2].Value.ToString();
            
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("Update `qyteti` set emri_qytetit='" + emri_qy + "',zip_kodi='" + zipkodi+ 
                "' WHERE id =" + qytetID, db.getConnection());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);


            db.closeConnection();
            shfaqqytetet();
        }

        private void dataview_qytetet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string s = dataview_qytetet.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            MessageBox.Show("Id: " + s + " u selektua");
            //Rregullo errorin
            
            try
            { qytetID = Int32.Parse(s);
            }
            catch (Exception ex)
            {

            }

            if (qytetID > 0)
            {
                    Row = e.RowIndex;
                    Column = e.ColumnIndex;

                    fshiqytet_button_B.Enabled = true;
                    perditesoqytet_button_B.Enabled = true;

            }
            
        }

        private void Shtoqytet_button_B_Click(object sender, EventArgs e)
        {
            panela.Controls.Clear();
            Shto_Qytet shto_qytet = new Shto_Qytet();
            shto_qytet.TopLevel = false;
            panela.Controls.Add(shto_qytet);
            shto_qytet.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            shto_qytet.Dock = DockStyle.Fill;
            shto_qytet.Show();
        }

        private void perditesoqytet_button_B_Click(object sender, EventArgs e)
        {
            string emri_qy = dataview_qytetet.Rows[Row].Cells[1].Value.ToString();
            string zipkodi = dataview_qytetet.Rows[Row].Cells[2].Value.ToString();

            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("Update `qyteti` set emri_qytetit='" + emri_qy + "',zip_kodi='" + zipkodi +
                "' WHERE id =" + qytetID, db.getConnection());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);


            db.closeConnection();
            shfaqqytetet();
        }

        private void fshiqytet_button_B_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("DELETE FROM `qyteti` WHERE id =" + qytetID, db.getConnection());
            MySqlDataAdapter sqlDa1 = new MySqlDataAdapter("DELETE FROM `vendbanimi` WHERE id_qyteti =" + qytetID, db.getConnection());

            DataTable dtbl = new DataTable();
            sqlDa1.Fill(dtbl);
            sqlDa.Fill(dtbl);


            db.closeConnection();
            shfaqqytetet();
        }
    }
}
