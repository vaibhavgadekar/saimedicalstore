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
    public partial class deleteEmployee : UserControl
    {
         
        OracleConnection con;
        public deleteEmployee()
        {
            InitializeComponent();
            String connection = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = orcl) )); User Id=medicalstore; password=medicalstore";
            con = new OracleConnection();
            con.ConnectionString = connection;
        }


        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            try
            {

                int eid1 = Convert.ToInt32(eid.Text);

                String connection = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = orcl) )); User Id=medicalstore; password=medicalstore";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connection;
                con.Open();
                Console.WriteLine("ok");
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "delete from admin where ano=" + eid1;
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();



                if (MessageBox.Show("Are you Sure to Delete ?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    MessageBox.Show("Record Deleted");
                    cmd.CommandText = "select * from admin";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader dr1 = cmd.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(dr1);
                    metroGrid1.DataSource = dataTable;

                }
            }
            catch (Exception ae)
            {
                MessageBox.Show(""+ae);
            }
        }

        private void deleteEmployee_Load(object sender, EventArgs e)
        {
            try
            {      // Datagridview with table
                String connection = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = orcl) )); User Id=medicalstore; password=medicalstore";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connection;
                con.Open();
                Console.WriteLine("ok");
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "select * from admin";
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
    }
}
