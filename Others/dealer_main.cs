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
    public partial class dealer_main : Form
    {
        public dealer_main()
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
            dealer_cars dealer_Cars = new dealer_cars();
            dealer_Cars.Show();
            this.Hide();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            dealer_showroom dealer_Showroom = new dealer_showroom();
            dealer_Showroom.Show();
            this.Hide();
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            dealer_sales dealer_Sales = new dealer_sales();
            dealer_Sales.Show();
            this.Hide();
        }
    }
}
