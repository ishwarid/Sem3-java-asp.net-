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
    public partial class ChangePassword : Form
    {
        DatabaseManager dbmanager = new DatabaseManager();
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btn_admin_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_shop_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_admin_change_Click(object sender, EventArgs e)
        {
            if (txt_admin_new_pass.Text == txt_admin_new_pass_r.Text) 
            {
                if (dbmanager.change("admin", txt_admin_old_pass.Text, txt_admin_new_pass.Text))
                    MessageBox.Show("Password successfully changed");
                else
                    MessageBox.Show("Please enter the correct old password.");
            }
            else
                MessageBox.Show("Passwords do not match!");
        }

        private void btn_shop_change_Click(object sender, EventArgs e)
        {
            if ((txt_shop_new_pass.Text == txt_shop_new_pass_r.Text) || (txt_shop_new_pass.Text != ""))
            {
                if (dbmanager.change("shop", txt_shop_old_pass.Text, txt_shop_new_pass.Text))
                    MessageBox.Show("Passward successfully changed");
                else
                    MessageBox.Show("Please enter the correct old password.");
            }
            else
                MessageBox.Show("Passwords do not match!");
        }
    }
}
