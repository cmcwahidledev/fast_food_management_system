using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace fast_food
{
    public partial class order : Form
    {
        public order()
        {
            InitializeComponent();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            new employee().Show(); this.Hide(); 
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            new login().Show(); this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            new customer().Show(); this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            new food().Show(); this.Hide(); 
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            new category().Show(); this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            new dashboard().Show(); this.Hide();
        }
        void ord()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-T9JSR89;Integrated Security=SSPI;Initial Catalog=fast_food;Integrated Security=true");
            SqlDataAdapter da = new SqlDataAdapter("select * from orders ", conn);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void guna2Button9_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-T9JSR89;Integrated Security=SSPI;Initial Catalog=fast_food;Integrated Security=true");
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO orders(customer_id, totalAmount) VALUES (@custid, @amount)", conn);

                cmd.Parameters.AddWithValue("@custid", txtid.Text);
                cmd.Parameters.AddWithValue("@amount", txtamount.Text);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("orders saved success", "200", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ord();
                txtid.Clear();
                txtamount.Clear();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-T9JSR89;Integrated Security=SSPI;Initial Catalog=fast_food;Integrated Security=true");

                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);


                SqlCommand cmd = new SqlCommand("update orders set customer_id=@custid, totalAmount=@amount where id=@ID", conn);

                cmd.Parameters.AddWithValue("@custid", txtid.Text);
                cmd.Parameters.AddWithValue("@amount", txtamount.Text);
                cmd.Parameters.AddWithValue("@ID", id);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update orders success", "200", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                ord();

                txtid.Clear();
                txtamount.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-T9JSR89;Integrated Security=SSPI;Initial Catalog=fast_food;Integrated Security=true");

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);


            SqlCommand cmd = new SqlCommand("delete from orders where id=@ID", conn);

            cmd.Parameters.AddWithValue("@ID", id);
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("delete orders success", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
            ord();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-T9JSR89;Integrated Security=SSPI;Initial Catalog=fast_food;Integrated Security=true");

            SqlCommand cmd = new SqlCommand("select * from orders where id='" + txtsearch.Text + "'", conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void order_Load(object sender, EventArgs e)
        {
            ord();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ord();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            new payment().Show(); this.Hide();
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            new Reports().Show(); this.Hide();
        }
    }
}
