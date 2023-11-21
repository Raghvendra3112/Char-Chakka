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
using System.Net;

namespace CharChakka
{
    public partial class dealer_sales : Form
    {
        public dealer_sales()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection(@"Data Source=RAJ-PC\SQLEXPRESS;Initial Catalog=DBMS_Project;Integrated Security=True");

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            dealer_main dealer_Main = new dealer_main();
            dealer_Main.Show();
            this.Hide();
        }

        private void populate()
        {
            Conn.Open();
            string query = "select * from SALES";
            SqlDataAdapter da = new SqlDataAdapter(query, Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            SalesDGV.DataSource = ds.Tables[0];
            Conn.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (S_id.Text == "" || C_id.Text == "" || Cust_id.Text == "" || Sh_id.Text == "" || Car_cost.Text == "" || ord_date.Text == "" || del_date.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = "insert into SALES values(" + S_id.Text + "," + C_id.Text + "," + Cust_id.Text + "," + Sh_id.Text + "," + Car_cost.Text + ",'" + ord_date.Text + "', '" + del_date.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sales Information Successfully Added");
                    S_id.Clear();
                    C_id.Clear();
                    Cust_id.Clear();
                    Sh_id.Clear();
                    Car_cost.Clear();
                    ord_date.Clear();
                    del_date.Clear();
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

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (S_id.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = "delete from SALES where sal_id = " + S_id.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sales Information Deleted Successfully");
                    S_id.Clear();
                    C_id.Clear();
                    Cust_id.Clear();
                    Sh_id.Clear();
                    Car_cost.Clear();
                    ord_date.Clear();
                    del_date.Clear();
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

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (S_id.Text == "" || C_id.Text == "" || Cust_id.Text == "" || Sh_id.Text == "" || Car_cost.Text == "" || ord_date.Text == "" || del_date.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = "update SALES set v_cost=" + Car_cost.Text + ",ord_dat='" + ord_date.Text + "',del_dat='" + del_date.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sales Information Successfully Updated");
                    S_id.Clear();
                    C_id.Clear();
                    Cust_id.Clear();
                    Sh_id.Clear();
                    Car_cost.Clear();
                    ord_date.Clear();
                    del_date.Clear();
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

        private void dealer_sales_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
