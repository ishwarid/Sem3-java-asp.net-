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
    public partial class Products : Form
    {
        
        DatabaseManager dbmanager = new DatabaseManager();
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            refresh();
        }
        
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
            
        }

        private void refresh()
        {
            txtName.Text = "";
            txtIngre.Text = " ";
            txtPrice.Text = "";
            txtSize.Text = "NULL";
            lblItemId.Text = Convert.ToString(dbmanager.row_affected() + 1);
            string[] cate = dbmanager.getCategory();
            cmboCategory.Items.Clear();
            cmboCategory.Text = "Select a Category";
            try
            {
                for (int i = 0; i <= cate.Length; i++)
                {
                    cmboCategory.Items.Add(cate[i]);
                }
            }
            catch
            {
                
            }
        }

        private void b_Click(object sender, EventArgs e)
        {
            bool flag = true;
            try
            {
                int id = Convert.ToInt16(lblItemId.Text);
                string name = txtName.Text.ToUpper();
                string ingre = txtIngre.Text.ToUpper();
                string cate = cmboCategory.SelectedItem.ToString();
                int price;
                int size=0;
                string sizeCheck = txtSize.Text;
                if (name.Trim().Length == 0)
                {
                    MessageBox.Show("Please fill the Item Name.");
                    flag = false;
                }

                if (!int.TryParse(txtPrice.Text, out price))
                {
                    MessageBox.Show("Please fill the Item price.");
                    flag = false;
                }
                    
                if (sizeCheck != "NULL" && sizeCheck.Trim().Length != 0)
                {
                    if (!int.TryParse(txtSize.Text, out size))
                    {
                        size = 0;
                    }
                }
                if (flag)
                {
                    DialogResult result = MessageBox.Show("The following product will be added- \n Name: \t\t"+ name + "\n Category: \t"+cate+"\n Price: \t\t"+price, "Important Message", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        if (dbmanager.addProduct(id, name, ingre, cate, price, size))
                        {
                            MessageBox.Show("The product has been added.");
                            refresh();
                        }
                        else
                        {
                            MessageBox.Show("Cannot Accessing Database!");
                        }
                    }
                    else
                        refresh();
                }

            }
            catch
            {
                MessageBox.Show("Please Enter a Category.");
            }
            
        }

        private void cmboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        
        
    }
}
