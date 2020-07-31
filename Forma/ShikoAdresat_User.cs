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
    public partial class ShikoAdresat_User : Form
    {
        private int adresaID = 0;
        private int Row = -1;
        private int Column = -1;
        
        public ShikoAdresat_User()
        {
            InitializeComponent();
            fshijAdresen_button_B.Enabled = false;
            perditesoAdresen_button_B.Enabled = false;
        }

       

        public void shfaqAdresat()
        {
            adresaID = 0;
            DB db = new DB();
            db.openConnection();
            //MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT * FROM `adresa`", db.getConnection());
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("Select a.id AS id, qy.emri AS Emri,q.emri_qytetit as 'Qyteti',v.emri_vendbanimit as 'Vendbanimi',a.emri_rruges as 'Rruga',a.nr_objektit as 'Numri i Objektit' From qytetari qy inner join adresa a on qy.id = a.id_qytetari inner join vendbanimi v on a.id_vendbanimi = v.id inner join qyteti q on v.id_qyteti = q.id", db.getConnection());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            db.closeConnection();
            dataview_adresat.DataSource = dtbl;
            //this.dataview_adresat.Columns["id_qytetari"].Visible = false;
        }

        private void dataview_adresat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string s = dataview_adresat.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            MessageBox.Show("Id: " + s + " u selektua");
            //Rregullo errorin

            try
            {
                adresaID = Int32.Parse(s);
            }
            catch (Exception ex)
            {

            }

            if (adresaID > 0)
            {
                Row = e.RowIndex;
                Column = e.ColumnIndex;

                fshijAdresen_button_B.Enabled = true;
                perditesoAdresen_button_B.Enabled = true;

            }
        }

        private void fshijAdresen_button_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("DELETE FROM `adresa` WHERE id =" + adresaID, db.getConnection());
            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);

            db.closeConnection();
            shfaqAdresat();
        }

        private void perditesoAdresen_button_Click(object sender, EventArgs e)
        {
            string emri_rr = dataview_adresat.Rows[Row].Cells[3].Value.ToString();
            string nr_objektit = dataview_adresat.Rows[Row].Cells[4].Value.ToString();

            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("Update `adresa` set emri_rruges='" + emri_rr  +"',nr_objektit='" + nr_objektit +
                "' WHERE id =" + adresaID, db.getConnection());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);


            db.closeConnection();
            shfaqAdresat();
        }

        private void perditesoAdresen_button_B_Click(object sender, EventArgs e)
        {
            string emri_rr = dataview_adresat.Rows[Row].Cells[3].Value.ToString();
            string nr_objektit = dataview_adresat.Rows[Row].Cells[4].Value.ToString();

            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("Update `adresa` set emri_rruges='" + emri_rr + "',nr_objektit='" + nr_objektit +
                "' WHERE id =" + adresaID, db.getConnection());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);


            db.closeConnection();
            shfaqAdresat();
        }

        private void fshijAdresen_button_B_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("DELETE FROM `adresa` WHERE id =" + adresaID, db.getConnection());
            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);

            db.closeConnection();
            shfaqAdresat();
        }
    }
}
