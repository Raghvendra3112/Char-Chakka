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
    public partial class admin_customers : Form
    {
        public admin_customers()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection(@"Data Source=RAJ-PC\SQLEXPRESS;Initial Catalog=DBMS_Project;Integrated Security=True");

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            admin_main admin_Main = new admin_main();
            admin_Main.Show();
            this.Hide();
        }

        private void populate()
        {
            Conn.Open();
            string query = "select cu_id, cu_name, co_num, address from CUSTOMER";
            SqlDataAdapter da = new SqlDataAdapter(query, Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CustomerDGV.DataSource = ds.Tables[0];
            Conn.Close();
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (C_id.Text == "" || C_name.Text == "" || C_no.Text == "" || C_gender.Text == "" || C_password.Text == "" || C_address.Text == "" || C_mailid.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = "insert into CUSTOMER values(" + C_id.Text + ",'" + C_name.Text + "'," + C_no.Text + ",'" + C_gender.Text + "','" + C_password.Text + "','" + C_address.Text + "','" + C_mailid.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Successfully Added");
                    C_id.Clear();
                    C_name.Clear();
                    C_no.Clear();
                    C_gender.Clear();
                    C_password.Clear();
                    C_address.Clear();
                    C_mailid.Clear();
                    Conn.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Conn.Close();
                }
            }
        }

        private void admin_customers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (C_id.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = "delete from CUSTOMER where cu_id = " + C_id.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Deleted Successfully");
                    C_id.Clear();
                    C_name.Clear();
                    C_no.Clear();
                    C_gender.Clear();
                    C_password.Clear();
                    C_address.Clear();
                    C_mailid.Clear();
                    Conn.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Conn.Close();
                }
            }
        }

        private void CustomerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (C_id.Text == "" || C_name.Text == "" || C_no.Text == "" || C_gender.Text == "" || C_password.Text == "" || C_address.Text == "" || C_mailid.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = "update CUSTOMER set cu_name='" + C_name.Text + "',co_num=" + C_no.Text + ",gender='" + C_gender.Text + "',password='" + C_password.Text + "',address='" + C_address.Text + "',mail_id='" + C_mailid.Text + "' where cu_id=" + C_id.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Successfully Updated");
                    C_id.Clear();
                    C_name.Clear();
                    C_no.Clear();
                    C_gender.Clear();
                    C_password.Clear();
                    C_address.Clear();
                    C_mailid.Clear();
                    Conn.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Conn.Close();
                }
            }
        }
    }
}
