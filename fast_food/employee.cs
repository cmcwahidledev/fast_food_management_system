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

namespace fast_food
{
    public partial class employee : Form
    {
        public employee()
        {
            InitializeComponent();
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

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            new login().Show(); this.Hide();
        }
        void emp()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-T9JSR89;Integrated Security=SSPI;Initial Catalog=fast_food;Integrated Security=true");
            SqlDataAdapter da = new SqlDataAdapter("select * from employee ", conn);

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
                SqlCommand cmd = new SqlCommand("INSERT INTO employee(fullname, phone, email, position, salary) VALUES (@name, @ph, @em, @pos, @sal)", conn);

                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@ph", txtphone.Text);
                cmd.Parameters.AddWithValue("@em", txtemail.Text);
                cmd.Parameters.AddWithValue("@pos", txtpos.Text);
                cmd.Parameters.AddWithValue("@sal", txtsalary.Text);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("employee saved success", "200", MessageBoxButtons.OK, MessageBoxIcon.Information);
                emp();
                txtname.Clear();
                txtphone.Clear();
                txtemail.Clear();
                txtpos.Clear();
                txtsalary.Clear();

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


                SqlCommand cmd = new SqlCommand("update employee set fullname=@name, phone=@ph, email=@em, position=@pos, salary=@sal where id=@ID", conn);

                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@ph", txtphone.Text);
                cmd.Parameters.AddWithValue("@em", txtemail.Text);
                cmd.Parameters.AddWithValue("@pos", txtpos.Text);
                cmd.Parameters.AddWithValue("@sal", txtsalary.Text);
                cmd.Parameters.AddWithValue("@ID", id);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update employee success", "200", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                emp();
                txtname.Clear();
                txtphone.Clear();
                txtemail.Clear();
                txtpos.Clear();
                txtsalary.Clear();
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


            SqlCommand cmd = new SqlCommand("delete from employee where id=@ID", conn);

            cmd.Parameters.AddWithValue("@ID", id);
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("delete employee success", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
            emp();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-T9JSR89;Integrated Security=SSPI;Initial Catalog=fast_food;Integrated Security=true");

            SqlCommand cmd = new SqlCommand("select * from employee where id='" + txtsearch.Text + "'", conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            new order().Show(); this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            new payment().Show(); this.Hide();
        }

        private void employee_Load(object sender, EventArgs e)
        {
            emp();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            new Reports().Show(); this.Hide();
        }
    }
}
