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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {/*
            rectangleShape2.Width += 5;
            if (rectangleShape2.Width >= 670)
            {
                timer1.Stop();
                MessageBox.Show("ok");
            }*/
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Top -= 5;
            if (label2.Top <= 75)
            {
                timer2.Stop();
                timer5.Start();
            }
        }



        private void timer5_Tick(object sender, EventArgs e)
        {
            label3.Top -= 5;
            if (label3.Top <= 75)
            {
                timer5.Stop();
                timer6.Start();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            label5.Top -= 5;
            if (label5.Top <= 80)
            {
                timer6.Stop();
                timer4.Start();

            }
        }

        private void ProgressbarTimer_Tick(object sender, EventArgs e)
        {
            bunifuProgressBar1.Value += 1;
            if (bunifuProgressBar1.Value == 100)
            {
                ProgressbarTimer.Stop();
                Login l = new Login();
                this.Hide();
                l.Show();


            }

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
           /* label4.Top += 5;
            if (label4.Top >= 230)
            {
                timer4.Stop();
            }*/
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            this.LoadingLabel.Visible = !this.LoadingLabel.Visible;
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer7.Interval = 250;
            timer7.Start();
        }

       

        
    }
}
