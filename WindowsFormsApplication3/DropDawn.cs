
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DropDownPanelDemo
{
    public partial class DropDawn : Form
    {
        private bool isCollapsed;
        public DropDawn()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
               // button5.Image = Resources.Collapse_Arrow_20px;
                panelDropDown.Height += 10;
                if (panelDropDown.Size == panelDropDown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
               // button5.Image = Resources.Expand_Arrow_20px;
                panelDropDown.Height -= 10;
                if (panelDropDown.Size == panelDropDown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                // button5.Image = Resources.Collapse_Arrow_20px;
                dropdawnpanel2.Height += 10;
                if (dropdawnpanel2.Size == dropdawnpanel2.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                // button5.Image = Resources.Expand_Arrow_20px;
                dropdawnpanel2.Height -= 10;
                if (dropdawnpanel2.Size == dropdawnpanel2.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed = true;
                }
            }
        }
    }
}
