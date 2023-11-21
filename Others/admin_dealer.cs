using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlClient;
using System.Net;
using System.Xml.Linq;

namespace CharChakka
{
    public partial class admin_dealer : Form
    {
        public admin_dealer()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection(@"Data Source=RAJ-PC\SQLEXPRESS;Initial Catalog=DBMS_Project;Integrated Security=True");

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            dealer_main main = new dealer_main();
            main.Show();
            this.Hide();
        }

        private void populate()
        {
            Conn.Open();
            string query = "select d_id, cmpny_name, username from DEALER";
            SqlDataAdapter da = new SqlDataAdapter(query, Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DealerDGV.DataSource = ds.Tables[0];
            Conn.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (D_id.Text == "" || Cmpny_name.Text == "" || D_username.Text == "" || D_password.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = "insert into DEALER values(" + D_id.Text + ",'" + Cmpny_name.Text + "','" + D_username.Text + "','" + D_password.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dealer Successfully Added");
                    D_id.Clear();
                    Cmpny_name.Clear();
                    D_username.Clear();
                    D_password.Clear();
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
            if (D_id.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = "delete from DEALER where d_id = " + D_id.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dealer Deleted Successfully");
                    D_id.Clear();
                    Cmpny_name.Clear();
                    D_username.Clear();
                    D_password.Clear();
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
            if (D_id.Text == "" || Cmpny_name.Text == "" || D_username.Text == "" || D_password.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = "update DEALER set cmpny_name='" + Cmpny_name.Text + "',username='" + D_username.Text + "',password='" + D_password.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dealer Successfully Updated");
                    D_id.Clear();
                    Cmpny_name.Clear();
                    D_username.Clear();
                    D_password.Clear();
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

        private void admin_dealer_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
