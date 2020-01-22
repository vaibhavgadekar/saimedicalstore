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
    public partial class updateMedicine : UserControl
    {
        OracleConnection con;

        OracleTransaction tr;
        public updateMedicine()
        {
            InitializeComponent();
            String connection = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = orcl) )); User Id=medicalstore; password=medicalstore";
            con = new OracleConnection();
            con.ConnectionString = connection;

        }

        private void updateMedicine_Load(object sender, EventArgs e)
        {


            nameTexBox.Enabled = false;
            typeComboBox.Enabled = false;
        rackNoTexBox.Enabled = false;
           quantityTexBox.Enabled = false;
            priceTexBox.Enabled = false;
            companyTexBox.Enabled = false;
           mfgDate.Enabled = false;
            expDate.Enabled = false;


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
                MessageBox.Show(""+ae);
            }
        }

        private void idTextBox_TextChange(object sender, EventArgs e)
        {


            nameTexBox.Enabled = true;
            typeComboBox.Enabled = true;
            rackNoTexBox.Enabled = true;
            quantityTexBox.Enabled = true;
            priceTexBox.Enabled = true;
            companyTexBox.Enabled = true;
            mfgDate.Enabled = true;
            expDate.Enabled = true;

            try
            {      // Datagridview with table
               int pno = Convert.ToInt32(idTextBox.Text);
                String connection = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = orcl) )); User Id=medicalstore; password=medicalstore";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connection;
                con.Open();
                Console.WriteLine("ok");
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "select * from product where pno="+pno;
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    nameTexBox.Text = dr[1].ToString();
                    typeComboBox.Text = dr[2].ToString();
                    rackNoTexBox.Text = dr[3].ToString();
                    quantityTexBox.Text = dr[4].ToString();
                    priceTexBox.Text = dr[5].ToString();
                    companyTexBox.Text = dr[9].ToString();
                                    
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
                 int pno = Convert.ToInt32(idTextBox.Text);
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



                tr = con.BeginTransaction();
                //Insert UserInput row in Database
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = @"update  product set pname='" + name + "' ,company_name='"+company+"',ptype='" + type + "',rackno='" + rackno + "',quantity='" + quantity + "',price='" + price + "',mfgdate=to_date('" + mfg + "','dd/mm/yyyy'),expdate=to_date('" + exp + "','dd/mm/yyyy') where pno="+pno;
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                tr.Commit();

                MessageBox.Show("Updated Successfully");
                clear();

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


    }
}
