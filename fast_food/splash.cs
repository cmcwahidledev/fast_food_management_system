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
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //guna2CircleProgressBar1.Value = label1.ToString("%");
            guna2CircleProgressBar1.Value += 3;
            if(guna2CircleProgressBar1.Value == 100)
            {
                timer1.Stop();
                new login().Show(); this.Hide();
            }
        
        }

        private void splash_Load(object sender, EventArgs e)
        {

        }
    }
}
