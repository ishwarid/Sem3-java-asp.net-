using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pizzashop_admin
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void rbtn1_Click(object sender, EventArgs e)
        {
            rpnl2.Visible = true;

        }

        private void rbtn9_Click(object sender, EventArgs e)
        {
            rpnl3.Visible = true;
        }

        private void rbtn2_Click(object sender, EventArgs e)
        {
            rpnl2.Visible = true;
        }

        private void rbtn3_Click(object sender, EventArgs e)
        {
            rpnl2.Visible = true;
        }

        private void rbtn4_Click(object sender, EventArgs e)
        {
            rpnl2.Visible = true;
        }

        private void rbtn5_Click(object sender, EventArgs e)
        {
            rpnl5.Visible = false;
            
        }

        private void rbtn6_Click(object sender, EventArgs e)
        {
            rpnl2.Visible = true;
        }

        private void rbtn7_Click(object sender, EventArgs e)
        {
            rpnl4.Visible = true;
        }

        private void rbtn11_Click(object sender, EventArgs e)
        {
            Admin a1 = new Admin();
            a1.Show();
            this.Hide();

        }

        private void rcmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            rcmb1.Items.Add("item 1");
            rcmb1.Items.Add("item 2");
            rcmb1.Items.Add("item 3");

        }

       

        

      



    }
}
