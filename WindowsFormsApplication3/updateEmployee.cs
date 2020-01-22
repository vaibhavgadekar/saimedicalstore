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
    public partial class updateEmployee : UserControl
    {
        OracleConnection con;
        OracleTransaction tr;
        public updateEmployee()
        {
            InitializeComponent();
            String connection = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = orcl) )); User Id=medicalstore; password=medicalstore";
            con = new OracleConnection();
            con.ConnectionString = connection;
        }
        private void updateEmployee_Load(object sender, EventArgs e)
        {
            

                ename.Enabled = false;
                eaddr.Enabled = false;
                econtact.Enabled = false;
                euser.Enabled = false;
                epass.Enabled = false;

                try
                {
                    String connection = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = orcl) )); User Id=medicalstore; password=medicalstore";
                    OracleConnection con = new OracleConnection();
                    con.ConnectionString = connection;
                    con.Open();
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

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
                       try
            {
                           check();
                          
                con.Open();
                int eid1 = Convert.ToInt32(eid.Text);
                String name = ename.Text.ToString();
                String addr = eaddr.Text.ToString();
                long contact1 = long.Parse(econtact.Text);
                String user = euser.Text.ToString();
                String pass = epass.Text.ToString();




                tr = con.BeginTransaction();
                //Insert UserInput row in Database
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = @"update  admin set aname='" + name + "' ,aaddr='" + addr + "',contactno='" + contact1 + "',apassword='"+pass+"',ausername='"+user+"' where ano=" +eid1 ;
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                tr.Commit();

                MessageBox.Show("Updated Successfully");

                cmd.CommandText = "select * from admin";
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

      




        public void check()
        {
            if (ename.Text == "")
            {
                MessageBox.Show("Employee Name Is Empty");
            }
            if (eaddr.Text == "")
            {
                MessageBox.Show("Address Is Empty");
            }
            if (econtact.Text == "")
            {
                MessageBox.Show("Contact Is Empty");
            }
            if (euser.Text == "")
            {
                MessageBox.Show("Username Is Empty");
            }
            if (epass.Text == "")
            {
                MessageBox.Show("Password Is Empty");
            }
        }

        public void clear()
        {
            ename.Text = "";
            eaddr.Text = "";
            econtact.Text = "";
            euser.Text = "";
            epass.Text = "";
        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {
            ename.Enabled = true;
            eaddr.Enabled = true;
            econtact.Enabled = true;
            euser.Enabled = true;
            epass.Enabled = true;


            try
            {      // Datagridview with table
                int eid1 = Convert.ToInt32(eid.Text);
                String connection = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = orcl) )); User Id=medicalstore; password=medicalstore";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connection;
                con.Open();
                Console.WriteLine("ok");
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "select * from admin where ano=" + eid1;
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ename.Text = dr[1].ToString();
                    eaddr.Text = dr[2].ToString();
                    econtact.Text = dr[3].ToString();
                    epass.Text = dr[4].ToString();
                    euser.Text = dr[5].ToString();
                }
            }
            catch (Exception ae)
            {

                MessageBox.Show(""+ae);
            }

        }

        private void clearTextButton_Click(object sender, EventArgs e)
        {
            clear();
        }

    }
}
