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
    public partial class addMedicine : UserControl
    {
        OracleConnection con;
       long user;
        public addMedicine()
        {
            InitializeComponent();
            String connection = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = orcl) )); User Id=medicalstore; password=medicalstore";
            con = new OracleConnection();
            con.ConnectionString = connection;
            

        }
        String a;
        private void addMedicine_Load(object sender, EventArgs e)
        {




            user = Login.text;
            Console.Write(user);

            typeComboBox.SelectedValue = 1;
            try
            {      // Datagridview with table
                String connection = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = orcl) )); User Id=medicalstore; password=medicalstore";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connection;
                con.Open();
                Console.WriteLine("ok");
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "select * from product";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dr);
                metroGrid1.DataSource = dataTable;

                //////end


                /// Get Product auto increment id from database as nextval
             /*   cmd.CommandText = "select  admin_seq.nextval from dual";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr3 = cmd.ExecuteReader();
                while (dr3.Read())
                {
                    a = dr3[0].ToString();
                }
                IdTextBox.Text = a;
                */




                /*   // Autocomplte  Textbox with Database 
                   cmd.CommandText = "select first_name from employees";
                   cmd.CommandType = CommandType.Text;
                   OracleDataReader dr1 = cmd.ExecuteReader();
                   AutoCompleteStringCollection myCollection = new AutoCompleteStringCollection();
             

                   while(dr1.Read())
                   {
                       myCollection.Add(dr1.GetString(0));
                   }
                   textBox1.AutoCompleteCustomSource = myCollection;
             
                   */

                ///end 
                ///


                ///Combobox with Database
                ///
                cmd.CommandText = "select cname from category";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr2 = cmd.ExecuteReader();
                while (dr2.Read())
                {
                    typeComboBox.Items.Add(dr2[0]);
                }

            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("My Error is" + ae);
            }
            finally
            {
                con.Close();
            }

        }



        // Code for Quantti textbox only accept number
        private void quantity_accept_digit(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        // Code for Price textbox only accept number
        private void price_accept_float(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar!='.'))
            {
                e.Handled = true;
            }
        }
       


                    //Add Row Button
        private void bunifuButton1_Click(object sender, EventArgs e)
        {

            check();

            try
            {

                con.Open();
                Console.WriteLine("ok");
                String name = nameTexBox.Text.ToString();
                String type = typeComboBox.Text.ToString();
                String rackno = rackNoTexBox.Text.ToString();
                int quantity = int.Parse(quantityTexBox.Text);
                Double price = double.Parse(priceTexBox.Text);
                String company = companyTexBox.Text.ToString();
                String mfg = mfgDate.Value.Day.ToString() + "/" + mfgDate.Value.Month.ToString() + "/" + mfgDate.Value.Year.ToString();
                String exp = expDate.Value.Day.ToString() + "/" + expDate.Value.Month.ToString() + "/" + expDate.Value.Year.ToString();
                Console.Write(quantity);


                //Insert UserInput row in Database
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = @"insert into product values(admin_seq.nextval,'"+name+"','"+type+"','"+rackno+"','"+quantity+"','"+price+"',to_date('"+mfg+"','dd/mm/yyyy'),to_date('"+exp+"','dd/mm/yyyy'),'"+Login.text+"','"+company+"')";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                clear();

                // Fetch Row After Add Row button click


                cmd.CommandText = "select * from product";
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
            
            nameTexBox.Text = "";
            typeComboBox.Text = "";
            rackNoTexBox.Text = "";
            quantityTexBox.Text = "";
            priceTexBox.Text = "";
            companyTexBox.Text = "";
            mfgDate.Text = "";
            expDate.Text = "";
        }

        private void clearTextButton_Click(object sender, EventArgs e)
        {
            clear();
        }


        public void check()
        {
        }

       
    }
}
