using fast_food;
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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }
        void empl()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-T9JSR89;Integrated Security=SSPI;Initial Catalog=fast_food;Integrated Security=true");

            SqlDataAdapter da = new SqlDataAdapter("select * from employee", conn);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void guna2Button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            new login().Show();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            emp();
            empl();
            cust();
            pay();
        }
        private void emp()
        {

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-T9JSR89;Integrated Security=SSPI;Initial Catalog=fast_food;Integrated Security=true");

            SqlCommand cmd = new SqlCommand("select count(*)from food", conn);
            conn.Open();
            object result = cmd.ExecuteScalar();
            if (result != DBNull.Value)
            {
                lblemp.Text = result.ToString();
            }
            else
            {
                lblemp.Text = "0";
            }
            conn.Close();
        }

        private void cust()
        {

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-T9JSR89;Integrated Security=SSPI;Initial Catalog=fast_food;Integrated Security=true");

            SqlCommand cmd = new SqlCommand("select count(*)from customers", conn);
            conn.Open();
            object result = cmd.ExecuteScalar();
            if (result != DBNull.Value)
            {
                label7.Text = result.ToString();
            }
            else
            {
                label7.Text = "0";
            }
            conn.Close();
        }

        private void pay()
        {

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-T9JSR89;Integrated Security=SSPI;Initial Catalog=fast_food;Integrated Security=true");

            SqlCommand cmd = new SqlCommand("select count(*)from payments", conn);
            conn.Open();
            object result = cmd.ExecuteScalar();
            if (result != DBNull.Value)
            {
                label10.Text = result.ToString();
            }
            else
            {
                label10.Text = "0";
            }
            conn.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            new category().Show(); this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            empl();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            new food().Show(); this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            new customer().Show(); this.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            new order().Show(); this.Hide();
        }

        private void guna2Button8_Click_1(object sender, EventArgs e)
        {
            new login().Show(); this.Hide();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            new Reports().Show(); this.Hide();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            new employee().Show(); this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            new payment().Show(); this.Hide();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
