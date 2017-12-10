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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string custname;
            custname = txtbcustname.Text;
            //button1.Hide();
            
            Form child = new Form2();
            child.Text = custname;
            child.MdiParent = this;
            child.Name = custname;
            child.Show();
            button1.Hide();
            label1.Hide();
            txtbcustname.Hide();
            //child.BringToFront();
        }
        public void backtomdi()
        {
            txtbcustname.Text = "";
            button1.Show();
            label1.Show();
            txtbcustname.Show();
        }
        public void backtoform()
        {
            txtbcustname.Text = "";
            button1.Hide();
            label1.Hide();
            txtbcustname.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}