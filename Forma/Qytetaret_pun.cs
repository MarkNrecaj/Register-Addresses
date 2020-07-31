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
    public partial class Qytetaret_Admin : Form
    {
        //Panel panela = Application.OpenForms["Main_Puntori"].Controls["panelview2"] as Panel;
        private int qytetariID = 0;
        private int Row = -1;
        private int Column = -1;
        public static string  numriPersonal = "";
        public Qytetaret_Admin()
        {
            InitializeComponent();
            numriPersonal = "";
            fshijQytetar_button_B.Enabled = false;
            perditsoQytetar_button_B.Enabled = false;
        }

        private void Qytetaret_pun_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void shtoqytetar_button_Click(object sender, EventArgs e)
        {

        }

        

        private void dataview_qytetaret_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string s = dataview_qytetaret.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            MessageBox.Show("Id: " + s + " u selektua");
            //Rregullo errorin
            try
            {
                qytetariID = Int32.Parse(s);
            }
            catch (Exception ex)
            { }

            if (qytetariID > 0)
            {
                Row = e.RowIndex;
                Column = e.ColumnIndex;

                fshijQytetar_button_B.Enabled = true;
                perditsoQytetar_button_B.Enabled = true;

            }


        }
    
    public void ShfaqQytetaret()
    {
        qytetariID = 0;
        DB db = new DB();
        db.openConnection();
        MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT * FROM `qytetari`", db.getConnection());
        DataTable dtbl = new DataTable();
        sqlDa.Fill(dtbl);
        db.closeConnection();

        dataview_qytetaret.DataSource = dtbl;
    }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("DELETE FROM `qytetari` WHERE id =" + qytetariID, db.getConnection());
            MySqlDataAdapter sqlDa1 = new MySqlDataAdapter("DELETE FROM `adresa` WHERE id_qytetari =" + qytetariID, db.getConnection());

            DataTable dtbl = new DataTable();

            sqlDa1.Fill(dtbl);
            sqlDa.Fill(dtbl);

            db.closeConnection();
            ShfaqQytetaret();
        }

        private void perditsoQytetar_button_Click(object sender, EventArgs e)
        {
            string emri = dataview_qytetaret.Rows[Row].Cells[1].Value.ToString();
            string mbiemri = dataview_qytetaret.Rows[Row].Cells[2].Value.ToString();
            string nr_telefonit = dataview_qytetaret.Rows[Row].Cells[3].Value.ToString();
            string nr_personal = dataview_qytetaret.Rows[Row].Cells[4].Value.ToString();

            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("Update `qytetari` set emri='" + emri + "',mbiemri='" + mbiemri+
                "',nr_telefonit='" + nr_telefonit + "',nr_personal='" + nr_personal + "' WHERE id =" + qytetariID, db.getConnection());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);


            db.closeConnection();
            ShfaqQytetaret();
        }

        private void fshijQytetar_button_B_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("DELETE FROM `qytetari` WHERE id =" + qytetariID, db.getConnection());
            MySqlDataAdapter sqlDa1 = new MySqlDataAdapter("DELETE FROM `adresa` WHERE id_qytetari =" + qytetariID, db.getConnection());

            DataTable dtbl = new DataTable();

            sqlDa1.Fill(dtbl);
            sqlDa.Fill(dtbl);

            db.closeConnection();
            ShfaqQytetaret();
        }

        private void perditsoQytetar_button_B_Click(object sender, EventArgs e)
        {
            string emri = dataview_qytetaret.Rows[Row].Cells[1].Value.ToString();
            string mbiemri = dataview_qytetaret.Rows[Row].Cells[2].Value.ToString();
            string nr_telefonit = dataview_qytetaret.Rows[Row].Cells[3].Value.ToString();
            string nr_personal = dataview_qytetaret.Rows[Row].Cells[4].Value.ToString();

            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("Update `qytetari` set emri='" + emri + "',mbiemri='" + mbiemri +
                "',nr_telefonit='" + nr_telefonit + "',nr_personal='" + nr_personal + "' WHERE id =" + qytetariID, db.getConnection());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);


            db.closeConnection();
            ShfaqQytetaret();
        }
    }
}
