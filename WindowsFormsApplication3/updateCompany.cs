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
    public partial class updateCompany : UserControl
    {
        OracleConnection con;

        OracleTransaction tr;
        public updateCompany()
        {
        InitializeComponent();
            String connection = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = orcl) )); User Id=medicalstore; password=medicalstore";
            con = new OracleConnection();
            con.ConnectionString = connection;

        }

        private void updateCompany_Load(object sender, EventArgs e)
        {
            nameTexBox.Enabled = false;
           addressTextbox.Enabled = false;
            contactTextBox.Enabled = false;
 
            try
            {
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

            }
            catch (Exception ae)
            {
                MessageBox.Show("" + ae);
            }
        }

        private void idTextBox_TextChange(object sender, EventArgs e)
        {
            nameTexBox.Enabled = true;
            addressTextbox.Enabled = true;
            contactTextBox.Enabled = true;
            

            try
            {      // Datagridview with table
                int pno = Convert.ToInt32(idTextBox.Text);
                String connection = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = orcl) )); User Id=medicalstore; password=medicalstore";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connection;
                con.Open();
                Console.WriteLine("ok");
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "select * from company where cno=" + pno;
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    nameTexBox.Text = dr[1].ToString();
                    addressTextbox.Text = dr[2].ToString();
                    contactTextBox.Text = dr[3].ToString();
                   

                }
            }
            catch (Exception ae)
            {


            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                int cno = Convert.ToInt32(idTextBox.Text);
                Console.WriteLine("ok");
                String name = nameTexBox.Text.ToString();
                String addr = addressTextbox.Text.ToString();
                long contactno = long.Parse(contactTextBox.Text);

           



                tr = con.BeginTransaction();
                //Insert UserInput row in Database
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = @"update  company set cname='" + name + "' ,caddr='" + addr + "',contact_no='" + contactno + "' where cno=" + cno;
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                tr.Commit();

                MessageBox.Show("Updated Successfully");

                cmd.CommandText = "select * from company";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dr);
                metroGrid1.DataSource = dataTable;

            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.Write(ea);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
