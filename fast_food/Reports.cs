using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fast_food
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            new dashboard().Show(); this.Hide();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox1.SelectedItem.ToString() == "Categories")
            {
                Cato_report rpt = new Cato_report();
                crystalReportViewer1.ReportSource = rpt;
            }else if(guna2ComboBox1.SelectedItem.ToString() == "Food")
            {
                foodReport rpt = new foodReport();
                crystalReportViewer1.ReportSource = rpt;
            }else if(guna2ComboBox1.SelectedItem.ToString() == "Customer")
            {
                custReport rpt = new custReport();
                crystalReportViewer1.ReportSource = rpt;
            }
            else if(guna2ComboBox1.SelectedItem.ToString() == "Order")
            {
                orderReport rpt = new orderReport();
                crystalReportViewer1.ReportSource = rpt;
            }
            else if(guna2ComboBox1.SelectedItem.ToString() == "Payment")
            {
                payReport rpt = new payReport();
                crystalReportViewer1.ReportSource = rpt;
            }
            else if(guna2ComboBox1.SelectedItem.ToString() == "Employee")
            {
                empReport rpt = new empReport();
                crystalReportViewer1.ReportSource = rpt;
            }
           
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            guna2ComboBox1.Items.Insert(0, "Choose select");
            guna2ComboBox1.SelectedIndex = 0;
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            new employee().Show(); this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            new payment().Show(); this.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            new order().Show(); this.Hide();
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            new customer().Show(); this.Hide();
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            new food().Show(); this.Hide();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            new category().Show(); this.Hide();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            new dashboard().Show(); this.Hide();
        }
    }
}
