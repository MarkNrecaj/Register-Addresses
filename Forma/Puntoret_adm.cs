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
    public partial class Puntoret_adm : Form
    {

        public Main_admin main_admin;
        private int UserID = 0;
        private int Row = -1;
        private int Column = -1;
        Panel panela = Application.OpenForms["Main_admin"].Controls["panelview"] as Panel;
        public Puntoret_adm()
        {
            InitializeComponent();
            main_admin = new Main_admin();
            fshij_button_B.Enabled = false;
            update_button_B.Enabled = false;

        }

        private void MainAdmin_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){
            string s = dataview_puntoret.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            MessageBox.Show("Id: " + s + " u selektua");
            //Rregullo errorin
            try
            {
                UserID = Int32.Parse(s);
            }
            catch (Exception ex)
            { }

                if (UserID > 0)
                {
                    Row = e.RowIndex;
                    Column = e.ColumnIndex;

                    fshij_button_B.Enabled = true;
                    update_button_B.Enabled = true;

                }
            

        }
        

        private void shto_button_Click(object sender, EventArgs e)
        {
            panela.Controls.Clear();
            Shto_punetor shto_punetor = new Shto_punetor();
            shto_punetor.TopLevel = false;
            panela.Controls.Add(shto_punetor);
            shto_punetor.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            shto_punetor.Dock = DockStyle.Fill;
            shto_punetor.Show();
        }

        private void shfaqpuntoret_button_Click(object sender, EventArgs e)
        {
            shfaqPunetort();
        }

        //Fshij puntorin nga databaza
        private void button2_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("DELETE FROM `puntori` WHERE id =" + UserID, db.getConnection());
            
            DataTable dtbl = new DataTable();
            
            sqlDa.Fill(dtbl);

            db.closeConnection();
            shfaqPunetort();

        }

        public void shfaqPunetort()
        {
            UserID = 0;
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("Select p.id,p.emri,p.mbiemri,p.nr_telefonit,p.email,p.username,p.password,p.id_qyteti,q.emri_qytetit From puntori p inner join qyteti q on p.id_qyteti = q.id", db.getConnection());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            db.closeConnection();

            dataview_puntoret.DataSource = dtbl;
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            string emri = dataview_puntoret.Rows[Row].Cells[1].Value.ToString();
            string mbiemri = dataview_puntoret.Rows[Row].Cells[2].Value.ToString();
            string nr_telefonit = dataview_puntoret.Rows[Row].Cells[3].Value.ToString();
            string email = dataview_puntoret.Rows[Row].Cells[4].Value.ToString();
            string username = dataview_puntoret.Rows[Row].Cells[5].Value.ToString();
            string password = dataview_puntoret.Rows[Row].Cells[6].Value.ToString();
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("Update `puntori` set emri='"+emri+"',mbiemri='"+mbiemri+"',nr_telefonit='"+
                nr_telefonit+"',email='"+email+"',username='"+username+"',password='"+password+ "' WHERE id =" + UserID , db.getConnection());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            

            db.closeConnection();
            shfaqPunetort();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panela.Controls.Clear();
            Shto_punetor shto_punetor = new Shto_punetor();
            shto_punetor.TopLevel = false;
            panela.Controls.Add(shto_punetor);
            shto_punetor.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            shto_punetor.Dock = DockStyle.Fill;
            shto_punetor.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            string emri = dataview_puntoret.Rows[Row].Cells[1].Value.ToString();
            string mbiemri = dataview_puntoret.Rows[Row].Cells[2].Value.ToString();
            string nr_telefonit = dataview_puntoret.Rows[Row].Cells[3].Value.ToString();
            string email = dataview_puntoret.Rows[Row].Cells[4].Value.ToString();
            string username = dataview_puntoret.Rows[Row].Cells[5].Value.ToString();
            string password = dataview_puntoret.Rows[Row].Cells[6].Value.ToString();
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("Update `puntori` set emri='" + emri + "',mbiemri='" + mbiemri + "',nr_telefonit='" +
                nr_telefonit + "',email='" + email + "',username='" + username + "',password='" + password + "' WHERE id =" + UserID, db.getConnection());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);


            db.closeConnection();
            shfaqPunetort();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();

            MySqlDataAdapter sqlDa = new MySqlDataAdapter("DELETE FROM `puntori` WHERE id =" + UserID, db.getConnection());

            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);

            db.closeConnection();
            shfaqPunetort();
        }
    }
    }
