using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;
using CrystalDecisions.Windows.Forms;

namespace pizzashop
{
    public partial class Report : Form
    {
        CrystalReportViewer crystalReportViewer1 = new CrystalReportViewer();
        String type;
        private static string con_str = "Data Source=(local);Initial Catalog=pizza;Integrated Security=True";
        private SqlConnection con = new SqlConnection(con_str);
        public Report()
        {
            InitializeComponent();
        }

        private void rbtn9_Click(object sender, EventArgs e)
        {
            rpnl3.Visible = true;
            rpnl4.Visible = false;
        }

        private void rbtn7_Click(object sender, EventArgs e)
        {
            rpnl4.Visible = true;
            rpnl3.Visible = false;
            DateTime x = DateTime.Now;
            String date = x.ToString("yyyy-MM-dd");
            //String date = "2014-11-02";
            String cm = "";
            if (type.CompareTo("all") == 0)
            {
                cm = "SELECT * FROM [pizza].[dbo].[order] where date = '" + date + "'; ";
            }
            else if (type.CompareTo("takeaway") == 0)
            {
                cm = "SELECT * FROM [pizza].[dbo].[order] where date = '" + date + "' and ordtype = '" + type + "'; ";
            }
            else if (type.CompareTo("dine") == 0)
            {
                cm = "SELECT * FROM [pizza].[dbo].[order] where date = '" + date + "' and ordtype = '" + type + "'; ";
            }
            else if (type.CompareTo("delivery") == 0)
            {
                cm = "SELECT * FROM [pizza].[dbo].[order] where date = '" + date + "' and ordtype = '" + type + "'; ";
            }
            else if (type.CompareTo("category") == 0)
            {
                cm = "SELECT * FROM [pizza].[dbo].[order] where date = '" + date + "' and itemcateg = '" + rcmb1.SelectedItem.ToString() + "'; ";
            }
            else if (type == "item")
            {
                String selitem = rcmb1.SelectedItem.ToString();
                int siz = 0;
                if (selitem.Contains(" 8"))
                {
                    siz = 8;
                    selitem = selitem.Replace(" 8","");
                    cm = "SELECT * FROM [pizza].[dbo].[order] where date = '" + date + "' and itemname = '" + selitem + "' and itemsize = " + siz + "; ";
                }
                else if (selitem.Contains(" 12"))
                {
                    siz = 12;
                    selitem = selitem.Replace(" 12", "");
                    cm = "SELECT * FROM [pizza].[dbo].[order] where date = '" + date + "' and itemname = '" + selitem + "' and itemsize = " + siz + "; ";
                }
                else
                {
                    cm = "SELECT * FROM [pizza].[dbo].[order] where date = '" + date + "' and itemname = '" + selitem + "'; ";
                }
            }
            SqlCommand cmd = new SqlCommand(cm, con); 
            con.Open();
            //MessageBox.Show(cm);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            
            
            todayreport obj = new todayreport();
            obj.SetDataSource(dt);
            crystalReportViewer1.ReportSource = obj;
            crystalReportViewer1.Size = new Size(2000, 2000);
            crystalReportViewer1.Refresh();
            rpnl4.Controls.Add(crystalReportViewer1);
            con.Close();
        }

        private void rbtn11_Click(object sender, EventArgs e)
        {
            Admin a1 = new Admin();
            a1.Show();
            this.Hide();
        }
        
        private void rbtn10_Click(object sender, EventArgs e)
        {
            rpnl4.Visible = true;
            string fromDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string toDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            //MessageBox.Show(fromDate +"  to  " + toDate);
            String cm = "";
            if (type.CompareTo("all") == 0)
            {
                cm = "SELECT * FROM [pizza].[dbo].[order] where date between '" + fromDate + "' and '" + toDate + "';";
            }
            else if (type.CompareTo("takeaway") == 0)
            {
                cm = "SELECT * FROM [pizza].[dbo].[order] where date between '" + fromDate + "' and '" + toDate + "' and ordtype = '" + type + "'; ";
            }
            else if (type.CompareTo("dine") == 0)
            {
                cm = "SELECT * FROM [pizza].[dbo].[order] where date between '" + fromDate + "' and '" + toDate + "' and ordtype = '" + type + "'; ";
            }
            else if (type.CompareTo("delivery") == 0)
            {
                cm = "SELECT * FROM [pizza].[dbo].[order] where date between '" + fromDate + "' and '" + toDate + "' and ordtype = '" + type + "'; ";
            }
            else if (type.CompareTo("category") == 0)
            {
                cm = "SELECT * FROM [pizza].[dbo].[order] where date between '" + fromDate + "' and '" + toDate + "' and itemcateg = '" + rcmb1.SelectedItem.ToString() + "'; ";
            }
            else if (type == "item")
            {
                String selitem = rcmb1.SelectedItem.ToString();
                int siz = 0;
                if (selitem.Contains(" 8"))
                {
                    siz = 8;
                    selitem = selitem.Replace(" 8", "");
                    cm = "SELECT * FROM [pizza].[dbo].[order] where date between '" + fromDate + "' and '" + toDate + "' and itemname = '" + selitem + "' and itemsize = " + siz + "; ";                
                }
                else if (selitem.Contains(" 12"))
                {
                    siz = 12;
                    selitem = selitem.Replace(" 12", "");
                    cm = "SELECT * FROM [pizza].[dbo].[order] where date between '" + fromDate + "' and '" + toDate + "' and itemname = '" + selitem + "' and itemsize = " + siz + "; ";
                }
                else
                {
                    cm = "SELECT * FROM [pizza].[dbo].[order] where date between '" + fromDate + "' and '" + toDate + "'  and itemname = '" + selitem + "'; ";
                }
            }
            SqlCommand cmd = new SqlCommand(cm, con);
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            todayreport obj = new todayreport();
            obj.SetDataSource(dt);
            crystalReportViewer1.ReportSource = obj;
            crystalReportViewer1.Size = new Size(2000, 2000);
            crystalReportViewer1.Refresh();
            rpnl4.Controls.Add(crystalReportViewer1);
            con.Close();
        }

        private void Report_Load_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            rpnl2.Visible = false;
            rpnl3.Visible = false;
            rpnl4.Visible = false;
            rpnl5.Visible = false;
            cmbtype.Items.Add("ALL");
            cmbtype.Items.Add("TAKE-AWAY");
            cmbtype.Items.Add("DINE");
            cmbtype.Items.Add("DELIVERY");
            cmbtype.Items.Add("CATEGORY");
            cmbtype.Items.Add("ITEM");
            cmbtype.Refresh();
        }

        private void cmbtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            rpnl4.Visible = false;
            rpnl3.Visible = false;
            if (cmbtype.SelectedItem.ToString() == "ALL")
            {
                rpnl2.Visible = true;
                rpnl5.Visible = false;
                type = "all";
            }
            else if (cmbtype.SelectedItem.ToString() == "TAKE-AWAY")
            {
                rpnl2.Visible = true;
                rpnl5.Visible = false;
                type = "takeaway";
            }
            else if (cmbtype.SelectedItem.ToString() == "DINE")
            {
                rpnl2.Visible = true;
                rpnl5.Visible = false;
                type = "dine";
            }
            else if (cmbtype.SelectedItem.ToString() == "DELIVERY")
            {
                rpnl2.Visible = true;
                rpnl5.Visible = false;
                type = "delivery";
            }
            else if (cmbtype.SelectedItem.ToString() == "CATEGORY")
            {
                rpnl2.Visible = false;
                rpnl5.Visible = true;
                type = "category";
                DatabaseManager dbmanager = new DatabaseManager();
                string[] cate = dbmanager.getCategory();
                rcmb1.Items.Clear();
                rcmb1.Text = "Select a Category";
                try
                {
                    for (int i = 0; i <= cate.Length; i++)
                    {
                        rcmb1.Items.Add(cate[i]);
                    }
                }
                catch
                {
                }
            }
            else if (cmbtype.SelectedItem.ToString() == "ITEM")
            {
                rpnl2.Visible = false;
                rpnl5.Visible = true;
                type = "item";
                rcmb1.Items.Clear();
                rcmb1.Text = "Select an Item";
                DatabaseManager dbmanager = new DatabaseManager();
                string[] items = dbmanager.rgetitems();
                try
                {
                    for (int j = 0; j < items.Length; j++)
                    {
                        rcmb1.Items.Add(items[j]);
                        rcmb1.Refresh();
                    }
                }
                catch { }
            }
        }

        private void rcmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            rpnl2.Visible = true;
        }
    }
}
