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
    public partial class customer_tax : Form
    {
        public customer_tax()
        {
            InitializeComponent();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            customer_main customer_Main = new customer_main();
            customer_Main.Show();
            this.Hide();
        }
    }
}
