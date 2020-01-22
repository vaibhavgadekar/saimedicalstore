using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;


namespace WindowsFormsApplication3
{
   
  
    public partial class Login : Form
    {

        public String aname = "";

        public static long text;
        public static String sessionName;
        OracleConnection con;
        public Login()
        {
            InitializeComponent();
            try
            {
                String connection = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = orcl) )); User Id=medicalstore; password=medicalstore";

                con = new OracleConnection();
                con.ConnectionString = connection;
            }catch(Exception e)
            {
                MessageBox.Show(""+e);
            }
       
        }


     

        public static int logincnt = 0, passcnt = 0;
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            this.Hide();
            r.Show();
        }



        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            if (UserLogo.Visible == true)
                bunifuTransition1.ShowSync(UserLogo);
            else
                bunifuTransition1.HideSync(UserLogo);

        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                String uname = username.Text.ToLower();
                String pword = password.Text;
            
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "select count(*) from admin where ausername='" + uname + "' and apassword='" + pword+"'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                long a=0;
                String cn="",cn2="";
                long b;
                
               while (dr.Read())
                {

                   cn=dr.GetValue(0).ToString();
                    
                }
                    a =Convert.ToInt64(cn);


                //Query for Session User
                 cmd.CommandText = "select ano from admin where ausername='" + uname + "' and apassword='" + pword+"'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr2 = cmd.ExecuteReader();
                  while (dr2.Read())
                {

                   cn2=dr2.GetValue(0).ToString();
                    
                }
                    b =Convert.ToInt64(cn2);

                    sessionName = uname;

                if (a==1)
                {
                    loader.Show();
                    text = b;
                    Form1 f = new Form1();
                    this.Hide();
                    f.Show();
                }
                else
                {
                    errormessage.Text = "username or password incorrect";
                }



            }
            catch (Exception ae)
            {
                errormessage.Text = "username or password incorrect";
            }
            finally
            {
                con.Close();
            }
        }

        private void LoginFocus(object sender, EventArgs e)
        {
            logincnt++;
            if (logincnt == 1)
            {
                username.Text = "";
            }
            errormessage.Text = "";
        }

        private void passwordfocus(object sender, EventArgs e)
        {
            passcnt++;
            if (passcnt == 1)
            {
                password.Text = "";
            }
            errormessage.Text = "";
         
        }

     

        

        private void bunifuCheckBox2_Click(object sender, EventArgs e)
        {
            if (bunifuCheckBox2.Checked)
            {
                password.isPassword = false;
            }
            else
            {
                password.isPassword = true;
            }
        }




        private void Login_Load(object sender, EventArgs e)
        {
            UserLogo.Top = -50;
            LoginButton.Left = 450;
            loader.Hide();
        }

        private void LogoAnim_Tick(object sender, EventArgs e)
        {
            UserLogo.Top += 5;
            if (UserLogo.Top == 50)
            {
                LogoAnim.Stop();
                LoginAnim.Start();
            }
        }


        private void LoginAnim_Tick(object sender, EventArgs e)
        {
            LoginButton.Left -= 5;
            if (LoginButton.Left == 305)
            {
                LoginAnim.Stop();
            }
        }

        
    }
}
