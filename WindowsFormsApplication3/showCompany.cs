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
    public partial class showCompany : UserControl
    {
        OracleConnection con;
        public showCompany()
        {
            InitializeComponent();
            String connection = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = orcl) )); User Id=medicalstore; password=medicalstore";
            con = new OracleConnection();
            con.ConnectionString = connection;
        }

        private void showCompany_Load(object sender, EventArgs e)
        {

            try
            {      // Datagridview with table
                String connection = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = orcl) )); User Id=medicalstore; password=medicalstore";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connection;
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "select * from company";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dr);
                metroGrid1.DataSource = dataTable;




                cmd.CommandText = "select  cname from company";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr1 = cmd.ExecuteReader();
                AutoCompleteStringCollection myCollection = new AutoCompleteStringCollection();


                while (dr1.Read())
                {
                    myCollection.Add(dr1.GetString(0));
                }
                nameTexBox.AutoCompleteCustomSource = myCollection;

            }
            catch (Exception ae)
            {
                MessageBox.Show("" + ae);
            }

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

            try
            {      // Datagridview with table
                String pname = nameTexBox.Text.ToString();
                String connection = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = orcl) )); User Id=medicalstore; password=medicalstore";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connection;
                con.Open();
                Console.WriteLine("ok");
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "select * from company where cname like'" + pname + "%'";
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

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            clear();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void clear()
        {
            
           nameTexBox.Text = "";

        }

    }
}
