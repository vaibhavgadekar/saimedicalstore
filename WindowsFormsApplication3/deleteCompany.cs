using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Oracle.DataAccess.Client;

namespace WindowsFormsApplication3
{
    public partial class deleteCompany : UserControl
    {
        OracleConnection con;
        public deleteCompany()
        {
            InitializeComponent();
            String connection = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = orcl) )); User Id=medicalstore; password=medicalstore";
            con = new OracleConnection();
            con.ConnectionString = connection;
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteCompany_Load(object sender, EventArgs e)
        {
            try
            {      // Datagridview with table
                String connection = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = orcl) )); User Id=medicalstore; password=medicalstore";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connection;
                con.Open();
                Console.WriteLine("ok");
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "select * from company";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dr);
                metroGrid1.DataSource = dataTable;

            }
            catch (Exception ae)
            {
                MessageBox.Show("" + ae);
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            int pno = Convert.ToInt32(nameTexBox.Text);
            String connection = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = orcl) )); User Id=medicalstore; password=medicalstore";
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connection;
            con.Open();
            Console.WriteLine("ok");
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "delete from company where cno=" + pno;
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            cmd.ExecuteNonQuery();



            if (MessageBox.Show("Are you Sure to Delete ?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                MessageBox.Show("Record Deleted");
                cmd.CommandText = "select * from company";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr1 = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dr1);
                metroGrid1.DataSource = dataTable;

            }
        }
    }
}
