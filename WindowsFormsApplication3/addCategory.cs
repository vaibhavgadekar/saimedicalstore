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
    public partial class addCategory : UserControl
    {
        OracleConnection con;
        public addCategory()
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

                check();
                con.Open();
                String name = category.Text.ToString();



                //Insert UserInput row in Database
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = @"insert into category values(category_seq.nextval,'" + name + "','"+Login.text+"')";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Inserted Succesfully");

                clear();

                // Fetch Row After Add Row button click


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

        private void addCategory_Load(object sender, EventArgs e)
        {
            try
            {      // Datagridview with table
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

            }
        }


         public void clear()
        {

            category.Text = "";
         }



         public void check()
        {

            if(category.Text=="")
            {
                MessageBox.Show("Category Name Is Empty");
            }
         }

         private void clearTextButton_Click(object sender, EventArgs e)
         {
             clear();
         }

         private void panel1_Paint(object sender, PaintEventArgs e)
         {

         }
    }
}
