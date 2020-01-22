using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class crystalReports : UserControl
    {
        public crystalReports()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void crystalReports_Load(object sender, EventArgs e)
        {
           // this.PRODUCTTableAdapter.Fill(this.reportViewer1.SALE);
            this.reportViewer1.RefreshReport();
        }
    }
}
