using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace pizzashop
{
    public partial class Stock : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=pizza;Integrated Security=True");
        public Stock()
        {
            InitializeComponent();
        }
        private void stbtn3_Click(object sender, EventArgs e)
        {
            Admin a1 = new Admin();
            a1.Show();
            this.Hide();
        }

        private void stbtn1_Click(object sender, EventArgs e)
        {
            stdatagrid1.Visible = true;
            stpnl1.Visible = false;
            stpnl2.Visible = false;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from stock ", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            stdatagrid1.DataSource = dt;
            con.Close();

        }

        private void stbtn2_Click(object sender, EventArgs e)
        {
            stdatagrid1.Visible = false;
            stpnl1.Visible = true;
            stpnl2.Visible = false;
            stdatagrid1.Visible = false;
        }

        private void btnstok_Click(object sender, EventArgs e)
        {
            try
            {
                String name = txtstname.Text;
                int quantity = Convert.ToInt32(txtqun.Text);
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=pizza;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into stock values('"+name+"', "+quantity+");", con);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                con.Close();
            }
            catch { }
        }

        private void stbtnupdate_Click(object sender, EventArgs e)
        {
            stpnl1.Visible = false;
            stpnl2.Visible = true;
            stdatagrid1.Visible = false;
            stpnl1.Visible = false;
            try
            {               
                
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from stock", con);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                //cmbitem.Items.Clear();
                cmbitem.Text = "Select An Item";
                String name = "";
                for (int i = 0; i < dt.Rows.Count; i++)
                {                    
                    name = Convert.ToString(dt.Rows[i][0]);
                    cmbitem.Items.Add(name);
                }
                //cmbitem.Refresh();
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void stbtnupdateok_Click(object sender, EventArgs e)
        {
            String name = cmbitem.SelectedItem.ToString();
            int prevquan = 0;
            try
            {

                SqlCommand cmd = new SqlCommand("select quantity from stock where item = '" + name + "';", con);
                con.Open();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                prevquan = Convert.ToInt32(dt.Rows[0][0]);
                MessageBox.Show("prev " + prevquan);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            int quantity = Convert.ToInt32(sttxtquan.Text) + prevquan;
            MessageBox.Show("new " + quantity);
            try
            {
                
                SqlCommand cmd = new SqlCommand("update stock set quantity = " + quantity + " where item = '" + name + "';", con);
                con.Open();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                con.Close();
            }
            catch { }

        }

    }
}
        

        

       

       
    

