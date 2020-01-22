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
    public partial class updateCategory : UserControl
    {
        OracleConnection con;
        OracleTransaction tr;
        public updateCategory()
        {
            InitializeComponent();
            String connection = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = orcl) )); User Id=medicalstore; password=medicalstore";
            con = new OracleConnection();
            con.ConnectionString = connection;
        }

        private void updateCategory_Load(object sender, EventArgs e)
        {
            category_name.Enabled = false;



            try
            {
                String connection = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = orcl) )); User Id=medicalstore; password=medicalstore";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connection;
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "select * from category";
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
                int cno = Convert.ToInt32(category_id.Text);
                String name = category_name.Text.ToString();
             
           



                tr = con.BeginTransaction();
                //Insert UserInput row in Database
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = @"update  category set cname='" + name + "'  where cid=" + cno;
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                tr.Commit();

                MessageBox.Show("Updated Successfully");

                cmd.CommandText = "select * from category";
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


        public void clear()
        {
            category_id.Text = "";
            category_name.Text = "";
         
        }

        public void check()
        {
            if (category_id.Text == "")
            {
                MessageBox.Show("ID Is Empty");
            }
            if (category_name.Text == "")
            {
                MessageBox.Show("Name Is Empty");
            }
            
        }

        private void clearTextButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void category_id_TextChange(object sender, EventArgs e)
        {
            category_name.Enabled = true;
           


            try
            {      // Datagridview with table
                int cno = Convert.ToInt32(category_id.Text);
                String connection = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = orcl) )); User Id=medicalstore; password=medicalstore";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connection;
                con.Open();
                Console.WriteLine("ok");
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "select * from category where cid=" + cno;
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    category_name.Text = dr[1].ToString();
                }
            }
            catch (Exception ae)
            {


            }


        }

        }
    }

