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
    public partial class HomeMenu : UserControl
    {
        public HomeMenu()
        {
            InitializeComponent();
           
        }


        

       /* private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure want to close", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
        }*/

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            int a = 5, b = 8;
            dataGridView1.Rows[n].Cells[0].Value = "1";
            dataGridView1.Rows[n].Cells[1].Value = "vaibhav";
            dataGridView1.Rows[n].Cells[2].Value = "456";
            dataGridView1.Rows[n].Cells[3].Value = "5";
            dataGridView1.Rows[n].Cells[4].Value = a * b;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeMenu_Load(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            int a = 5, b = 8;
            dataGridView1.Rows[n].Cells[0].Value = "1";
            dataGridView1.Rows[n].Cells[1].Value = "vaibhav";
            dataGridView1.Rows[n].Cells[2].Value = "456";
            dataGridView1.Rows[n].Cells[3].Value = "5";
            dataGridView1.Rows[n].Cells[4].Value = a * b;






           // dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
           // dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


        }

       

        

    }
}
