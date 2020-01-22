﻿using System;
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
    public partial class addEmployee : UserControl
    {
         OracleConnection con;
        public addEmployee()
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
                String name = ename.Text.ToString();
                String addr = eaddr.Text.ToString();
                long contact1 = long.Parse(econtact.Text);
                String user = euser.Text.ToString();
                String pass = epass.Text.ToString();



                //Insert UserInput row in Database
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = @"insert into admin values(admin_seq.nextval,'" + name + "','" + addr + "','" + contact1 + "','" + pass + "','" + user + "')";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Inserted Succesfully");

                clear();

                // Fetch Row After Add Row button click


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

        private void clearTextButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addEmployee_Load(object sender, EventArgs e)
        {
            try
            {      // Datagridview with table
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

            }
        }
    }
}
