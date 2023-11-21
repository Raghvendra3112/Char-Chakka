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
    public partial class dealer_cars : Form
    {
        public dealer_cars()
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
            string query = "select * from VEHICLE";
            SqlDataAdapter da = new SqlDataAdapter(query, Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CarDGV.DataSource = ds.Tables[0];
            Conn.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (C_id.Text == "" || D_id.Text == "" || C_name.Text == "" || C_model.Text == "" || C_type.Text == "" || C_cost.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = "insert into VEHICLE values(" + C_id.Text + "," + D_id.Text + ",'" + C_name.Text + "','" + C_model.Text + "','" + C_type.Text + "'," + C_cost.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Added");
                    C_id.Clear();
                    D_id.Clear();
                    C_name.Clear();
                    C_model.Clear();
                    C_type.Clear();
                    C_cost.Clear();
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
            if (C_id.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = "delete from VEHICLE where v_id = " + C_id.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Deleted Successfully");
                    C_id.Clear();
                    D_id.Clear();
                    C_name.Clear();
                    C_model.Clear();
                    C_type.Clear();
                    C_cost.Clear();
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
            if (C_id.Text == "" || D_id.Text == "" || C_name.Text == "" || C_model.Text == "" || C_type.Text == "" || C_cost.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = "update VEHICLE set v_name='" + C_name.Text + "',v_model='" + C_model.Text + "',v_type='" + C_type.Text + "',v_cost=" + C_cost.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Updated");
                    C_id.Clear();
                    D_id.Clear();
                    C_name.Clear();
                    C_model.Clear();
                    C_type.Clear();
                    C_cost.Clear();
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

        private void dealer_cars_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
