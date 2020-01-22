using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 :Form
    {

        
        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            managemedicine1.BringToFront();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            
        }

   /*
                                        //Window resize code
        private const int cGrip = 16;
        private const int cCaption = 32;
          protected override void WndProc(ref Message m)
        {

            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);

                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }

                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;

                }
            
            }
            base.WndProc(ref m);
        }



                 //resize code end   */ 

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
               WindowState = FormWindowState.Normal;
            }
            else if (WindowState == FormWindowState.Normal)
            {
               WindowState = FormWindowState.Maximized;
            }

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

      /*  private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }*/

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
           
            notification1.BringToFront();
        }

      /*  private void home1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }*/

        private void stock_Click(object sender, EventArgs e)
        {
           
            homeMenu1.BringToFront();
            bunifuCustomLabel1.Text = "Stock";
        }

  

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            //timer1.Start();
        }

       

      


        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            updateEmployee1.BringToFront();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  metroLabel1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            label2.Text = DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToLongDateString();
            SessionUser.Text = Login.sessionName;
           

           // this.reportViewer1.RefreshReport();
        }

        private void notification2_Load(object sender, EventArgs e)  
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

            bunifuCustomLabel1.Text="HomeMenu";
            homeMenu3.BringToFront();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Are you Sure to Logout ?","Logout",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Login l = new Login();
                this.Hide();
                l.Show();
            }

          
            //customDialog c = new customDialog();
            //c.ShowDialog(this);
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            
        }

        private void addmedicine_Click(object sender, EventArgs e)
        {
            addMedicine1.BringToFront();
            bunifuCustomLabel1.Text = "Add Medicine";
           

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            managemedicine1.BringToFront();
           
        }

        private void addCompany_Click(object sender, EventArgs e)
        {
            addCompany1.BringToFront();
        }

        private void homeMenu3_Load(object sender, EventArgs e)
        {

        }

        private void showmedicine_Click(object sender, EventArgs e)
        {
         
          showMedicine1.BringToFront();

        }

        private void updatemedicine_Click(object sender, EventArgs e)
        {
            updateMedicine1.BringToFront();
        }

        private void deletemedicine_Click(object sender, EventArgs e)
        {
            deleteMedicine1.BringToFront();
        }

        private void viewCompany_Click(object sender, EventArgs e)
        {
            showCompany1.BringToFront();
        }

        private void deleteCompany_Click(object sender, EventArgs e)
        {
            deleteCompany1.BringToFront();
        }

        private void updateCompany_Click(object sender, EventArgs e)
        {
            updateCompany1.BringToFront();
        }

        private void updateCompany1_Load(object sender, EventArgs e)
        {

        }

        private void AddCategory_Click(object sender, EventArgs e)
        {
            addCategory1.BringToFront();
        }

        private void ShowCategory_Click(object sender, EventArgs e)
        {
            showCategory1.BringToFront();
        }

        private void UpadateCategory_Click(object sender, EventArgs e)
        {
            updateCategory1.BringToFront();
        }

        private void DeleteCategory_Click(object sender, EventArgs e)
        {
            deleteCategory1.BringToFront();
        }

        private void showCategory1_Load(object sender, EventArgs e)
        {

        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            addEmployee1.BringToFront();
        }

        private void ShowEmployee_Click(object sender, EventArgs e)
        {
            showEmployee1.BringToFront();
        }

        private void DeleteEmployee_Click(object sender, EventArgs e)
        {
            deleteEmployee1.BringToFront();
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Excel.exe");
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("wordpad.exe");
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            addCompany1.BringToFront();
        }

        private void addStock_Click(object sender, EventArgs e)
        {
            addMedicine1.BringToFront();
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            addEmployee1.BringToFront();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            managemedicine1.BringToFront();
        }

        private void YearlyReports_Click(object sender, EventArgs e)
        {
            crystalReports1.BringToFront();
        }

       

      

     

        }

      

        
    }

