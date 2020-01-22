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
    public partial class managemedicine : UserControl
    {
        OracleConnection con;
        public double rate;
        public long quantity;
        public managemedicine()
        {
            InitializeComponent();
            String connection = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = orcl) )); User Id=medicalstore; password=medicalstore";
            con = new OracleConnection();
            con.ConnectionString = connection;
           
        }

        private void managemedicine_Load(object sender, EventArgs e)
        {
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
               // dataTable.Load(dr);
                //metroGrid1.DataSource = dataTable;




                cmd.CommandText = "select pname from Product";
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

        private void quantity_only_accept_digit(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void category_TextChange(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nameTexBox_TextChange(object sender, EventArgs e)
        {
            try
            {      // Datagridview with table
                String pname = nameTexBox.Text;
                String connection = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = orcl) )); User Id=medicalstore; password=medicalstore";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connection;
                con.Open();
                Console.WriteLine("ok");
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "select * from product where pname='"+pname+"'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    
                    categoryTextBox.Text = dr[2].ToString();
                    quantityTextBox.Text = dr[4].ToString();
                    RackTextBox.Text = dr[3].ToString();
                    rateTextBox.Text = dr[5].ToString();
                }
                rate = Convert.ToDouble(rateTextBox.Text);
                quantity = Convert.ToInt64(quantityText.Text);
                priceTextBox.Text = String.Format("{0:n0}", (rate * quantity).ToString());
                
            }
            catch (Exception ae)
            {

               
            }
        }

        private void quantityText_TextChange(object sender, EventArgs e)
        {
            if (quantityText.Text == "")
            {
                quantity = 1;
            }
            else
            {

                quantity = Convert.ToInt64(quantityText.Text);
                priceTextBox.Text = (rate * quantity).ToString();
            }
        }

        private void SGST_per_TextChange(object sender, EventArgs e)
        {
            if (SGST_per.Text == "")
            {
                SGST_per.Text = 0.ToString();
            }
            if (SGST_per.Text == "0")
            {

            }
         
             SGST_amount.Text = (Convert.ToDouble(priceTextBox.Text) * (Convert.ToDouble(SGST_per.Text) / 100)).ToString();
             priceTextBox.Text =( Convert.ToDouble(SGST_amount.Text )+ Convert.ToDouble(priceTextBox.Text)).ToString();
        }
        double total = 0;
        private void bunifuButton1_Click(object sender, EventArgs e)
        {

            try
            {
                int cnt = 0, quantitycnt = 0;
                
                String pname = nameTexBox.Text;
                String connection = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = orcl) )); User Id=medicalstore; password=medicalstore";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connection;
                con.Open();
                Console.WriteLine("ok");
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "select quantity from product where pname='" + pname + "'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cnt = int.Parse(dr[0].ToString());
                }
                quantitycnt = int.Parse(quantityText.Text);
                if (quantitycnt > cnt)
                {
                    MessageBox.Show("only " + cnt + " products available please update the Stock of "+nameTexBox.Text+" then try to add !", "Action Required", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {



                    billdatagrid.Rows.Add(nameTexBox.Text,categoryTextBox.Text,rateTextBox.Text,quantityText.Text,priceTextBox.Text);
                    total = total + (double.Parse(priceTextBox.Text));
                    TotalTextBox.Text = String.Format("{0:n}",total);
                   
                }
            }
            catch (Exception a)
            {
                Console.WriteLine(a);
            }



           

        }

        private void billdatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (billdatagrid.Columns[e.ColumnIndex].Name == "removecolumn")
            {
                if (MessageBox.Show("Are You Sure To Delete  ", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)==DialogResult.OK)
                {
                    int index = billdatagrid.CurrentCell.RowIndex;
                    total = total - (double.Parse(billdatagrid.Rows[index].Cells[4].Value.ToString()));
                    TotalTextBox.Text = String.Format("{0:n}", total);
                    billdatagrid.Rows.RemoveAt(index);
                }
               
            }
        }

        private void printBill_Click(object sender, EventArgs e)
        {

        }

       /* private void bunifuTextBox8_TextChange(object sender, EventArgs e)
        {

        }*/
    }
}
