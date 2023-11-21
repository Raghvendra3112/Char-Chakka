using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CharChakka
{
    public partial class Customer_login : Form
    {
        public Customer_login()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection(@"Data Source=RAJ-PC\SQLEXPRESS;Initial Catalog=DBMS_Project;Integrated Security=True");

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Conn.Open();
            string query = "select count(*) from CUSTOMER where cu_name='" + Uname.Text + "' and password='" + Upassword.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                customer_main customer_Main = new customer_main();
                customer_Main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
                Uname.Clear();
                Upassword.Clear();
                Uname.Focus();
            }
            Conn.Close();
        }
    }
}
