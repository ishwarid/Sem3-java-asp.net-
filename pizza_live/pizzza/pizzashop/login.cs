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
    public partial class login : Form
    {
        private DatabaseManager dbmanager = new DatabaseManager();
        public login()
        {
            InitializeComponent();
        }
        //string pass;
        //int flag = 0;
        private void btnadmin_Click(object sender, EventArgs e)
        {
            shape2.Visible = false;
            pnlloginshop.Visible = false;
            pnlloginadd.Visible = true;
            shape1.Visible = true;
            lbluser.Text = "ADMIN LOGIN";
            //pnllogin.Visible = true;
            //flag = 1;*/
        }

        private void btnshop_Click(object sender, EventArgs e)
        {
            pnlloginadd.Visible = false;
            shape1.Visible = false;
            shape2.Visible = true;
            pnlloginshop.Visible = true;
            lbshop.Text = "SHOP LOGIN";
            //pnllogin.Visible = true;
            //flag = 2;*/
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            string passin = Convert.ToString(txtbpass.Text);
            if (dbmanager.checkPass("admin", passin))
            {
                Admin admin = new Admin();
                admin.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Invalid Password!");
        }

        private void pblogo_Click(object sender, EventArgs e)
        {
            /*pnllogin.Visible = false;
            txtbpass.Text = "";*/
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnshoplog_Click(object sender, EventArgs e)
        {
            string passin = Convert.ToString(txtpass1.Text);
            if (dbmanager.checkPass("shop", passin))
            {
                var myform = new Form1();
                myform.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Invalid Password!");
            }
        }



    }
}

