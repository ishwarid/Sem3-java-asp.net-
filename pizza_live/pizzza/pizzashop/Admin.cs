using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pizzashop
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void adbtn1_Click(object sender, EventArgs e)
        {
            Report r1 = new Report();
            r1.Show();
            this.Hide();
        }

        private void adbtn2_Click(object sender, EventArgs e)
        {
            Products p = new Products();
            p.Show();
        }

        private void adbtn3_Click(object sender, EventArgs e)
        {
            Stock s1 = new Stock();
            s1.Show();
        }

        private void btn_chng_pass_Click(object sender, EventArgs e)
        {
            ChangePassword chg = new ChangePassword();
            chg.Show();
        }

    }
}
