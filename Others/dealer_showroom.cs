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
    public partial class dealer_showroom : Form
    {
        public dealer_showroom()
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
            string query = "select sh_id, d_id, sh_name, contact from SHOWROOM";
            SqlDataAdapter da = new SqlDataAdapter(query, Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ShowroomDGV.DataSource = ds.Tables[0];
            Conn.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (Sh_id.Text == "" || D_id.Text == "" || Sh_name.Text == "" || address.Text == "" || contact.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = "insert into SHOWROOM values(" + Sh_id.Text + "," + D_id.Text + ",'" + Sh_name.Text + "','" + address.Text + "'," + contact.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Showroom Successfully Added");
                    Sh_id.Clear();
                    D_id.Clear();
                    Sh_name.Clear();
                    address.Clear();
                    contact.Clear();
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
            if (Sh_id.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = "delete from SHOWROOM where sh_id = " + Sh_id.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Showroom Deleted Successfully");
                    Sh_id.Clear();
                    D_id.Clear();
                    Sh_name.Clear();
                    address.Clear();
                    contact.Clear();
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
            if (Sh_id.Text == "" || D_id.Text == "" || Sh_name.Text == "" || contact.Text == "" || address.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = "update SHOWROOM set sh_name='" + Sh_name.Text + "',address='" + address.Text + "',contact=" + contact.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Showroom Successfully Updated");
                    Sh_id.Clear();
                    D_id.Clear();
                    Sh_name.Clear();
                    address.Clear();
                    contact.Clear();
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

        private void dealer_showroom_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
