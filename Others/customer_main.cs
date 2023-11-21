using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharChakka
{
    public partial class customer_main : Form
    {
        public customer_main()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {
            main main = new main();
            main.Show();
            this.Hide();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            customer_tax customer_Tax = new customer_tax();
            customer_Tax.Show();
            this.Hide();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            customer_complaint customer_Complaint = new customer_complaint();
            customer_Complaint.Show();
            this.Hide();
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            customer_cars customer_Cars = new customer_cars();
            customer_Cars.Show();
            this.Hide();
        }
    }
}
