using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace pizzashop
{
    class DatabaseManager
    {
        private static string con_str = "Data Source=(local);Initial Catalog=pizza;Integrated Security=True";
        private SqlConnection con = new SqlConnection(con_str);
        public bool change(string name, string oldpass, string newpass)
        {
            try
            {
                if (checkPass(name, oldpass))
                {
                    SqlCommand cmd = new SqlCommand("update Passwords set password = '" + newpass + "' where username = '" + name + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                con.Close();
            }

        }

        public bool checkPass(string name, string password)
        {

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select count(*) from Passwords where username = '" + name + "' and password = '" + password + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public string[] getItems(string itemName)
        {
            string[] items = new string[row_affected(itemName)];
            int i = -1;
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM [pizza].[dbo].[item] where itemcateg = '" + itemName + "' and itemsize = 8; ", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    i++;
                    items[i] = Convert.ToString(reader.GetSqlString(1));                    
                }
                return items;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        //needs to be modified
        public int row_affected(string name)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT count(*) FROM [pizza].[dbo].[item] where itemcateg = '" + name + "' and itemsize = 8; ", con);
                con.Open();
                int rows = (int)cmd.ExecuteScalar();
                return rows;
            }
            catch
            {
                return 0;
            }
            finally 
            {
                con.Close();
            }
        }

        public int row_affected()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT count(*) FROM [pizza].[dbo].[item]; ", con);
                con.Open();
                int rows = (int)cmd.ExecuteScalar();
                return rows;
            }
            catch
            {
                return 0;
            }
            finally
            {
                con.Close();
            }
        }
        public string[] getCategory()
        {
            string[] items = new string[row_affected()];
            int i = -1;
            bool flag = true;
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT itemcateg FROM [pizza].[dbo].[item] ; ", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    for (int j = 0; j <= i; j++)
                    {
                        if (items[j] == Convert.ToString(reader.GetSqlString(0)))
                        {
                            flag = false;
                        }
                    }
                    if (flag)
                    {
                        i++;
                        items[i] = Convert.ToString(reader.GetSqlString(0));
                    }
                    flag = true;
                }
                return items;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public bool addProduct(int id, string itemName, string ingre, string categ, int price, int size)
        {
            try
            {
                if (size == 0)
                {
                    SqlCommand cmd = new SqlCommand("insert into [pizza].[dbo].[item] values (" + id + " , '" + itemName + "' ,'" + ingre + "', '" + categ + "'," + price + ",null); ", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into [pizza].[dbo].[item] values (" + id + " , '" + itemName + "' ,'" + ingre + "', '" + categ + "'," + price + "," + size + "); ", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return true;
                }                
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public bool addCust(string name , string addr , Int64 phone, string email)
        {
            int id = getCustId() + 1;
            try
            {
                SqlCommand cmd = new SqlCommand("insert into [pizza].[dbo].[cust] values ("+ id +",'" + name + "' ,'" + addr + "', " + phone + ",'" + email + "'); ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch{
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public int getCustId()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT count(*) FROM [pizza].[dbo].[cust]; ", con);
                con.Open();
                int rows = (int)cmd.ExecuteScalar();
                return rows;
            }
            catch
            {
                return 0;
            }
            finally
            {
                con.Close();
            }
        }
       // report funcs below
        /*
        public int reptoday(String date , String type) 
        {
            String cm="";
            if(type.CompareTo("all")==0)
            {
                cm = "SELECT * FROM [pizza].[dbo].[order] where date = '" + date + "'; ";
            }
            else if (type.CompareTo("takeaway") == 0)
            {
                cm = "SELECT * FROM [pizza].[dbo].[order] where date = '" + date + "' and ordtype = '"+ type +"'; ";
            }
            else if (type.CompareTo("dine") == 0)
            {
                cm = "SELECT * FROM [pizza].[dbo].[order] where date = '" + date + "' and ordtype = '" + type + "'; ";
            }
            else if (type.CompareTo("delivery") == 0)
            {
                cm = "SELECT * FROM [pizza].[dbo].[order] where date = '" + date + "' and ordtype = '" + type + "'; ";
            }
            
            try
            {
                SqlCommand cmd = new SqlCommand(cm, con);
                MessageBox.Show(cm);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                con.Open();
                int count = dt.Rows.Count;
                int sale = 0;
                for (int i = 0; i < count; i++ )
                {
                    sale = sale + Convert.ToInt16(dt.Rows[i][4]);
                    //MessageBox.Show(""+dt.Rows[i][4]);
                }
                return sale;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
            finally
            {
                con.Close();
            }
        }

        public int reptoday(String date, String type , String param , int size)
        {
            String cm = "";
            if (type.CompareTo("category") == 0)
            {
                cm = "SELECT * FROM [pizza].[dbo].[order] where date = '" + date + "' and itemcateg = '" + param + "'; ";
            }
            else if (type.CompareTo("item") == 0)
            {
                if (size == 0)
                {
                    cm = "SELECT * FROM [pizza].[dbo].[order] where date = '" + date + "' and itemname = '" + param + "'; ";
                }
                else
                {
                    cm = "SELECT * FROM [pizza].[dbo].[order] where date = '" + date + "' and itemname = '" + param + "' and itemsize = " + size + "; ";
                }
            }           

            try
            {
                SqlCommand cmd = new SqlCommand(cm, con);
                MessageBox.Show(cm);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                con.Open();
                int count = dt.Rows.Count;
                int sale = 0;
                for (int i = 0; i < count; i++)
                {
                    sale = sale + Convert.ToInt16(dt.Rows[i][4]);
                }
                return sale;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
            finally
            {
                con.Close();
            }
        }
        public int reptofrom(String type , String fromDate , String toDate)
        {
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

            try
            {
                SqlCommand cmd = new SqlCommand(cm, con);
                MessageBox.Show(cm);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                con.Open();
                int count = dt.Rows.Count;
                int sale = 0;
                for (int i = 0; i < count; i++)
                {
                    sale = sale + Convert.ToInt16(dt.Rows[i][4]);
                    //MessageBox.Show(""+dt.Rows[i][4]);
                }
                return sale;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
            finally
            {
                con.Close();
            }
        }
        public int reptofrom(String type, String fromDate , String toDate, String param, int size)
        {
            String cm = "";
            if (type.CompareTo("category") == 0)
            {
                cm = "SELECT * FROM [pizza].[dbo].[order] where date between '" + fromDate + "' and '" + toDate + "' and itemcateg = '" + param + "'; ";
            }
            else if (type.CompareTo("item") == 0)
            {
                if (size == 0)
                {
                    cm = "SELECT * FROM [pizza].[dbo].[order] where date between '" + fromDate + "' and '" + toDate + "' and itemname = '" + param + "'; ";
                }
                else
                {
                    cm = "SELECT * FROM [pizza].[dbo].[order] where date between '" + fromDate + "' and '" + toDate + "' and itemname = '" + param + "' and itemsize = " + size + "; ";
                }
            }

            try
            {
                SqlCommand cmd = new SqlCommand(cm, con);
                MessageBox.Show(cm);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                con.Open();
                int count = dt.Rows.Count;
                int sale = 0;
                for (int i = 0; i < count; i++)
                {
                    sale = sale + Convert.ToInt16(dt.Rows[i][4]);
                }
                return sale;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
            finally
            {
                con.Close();
            }
        }
        */
        public string[] rgetitems()
        {
            string[] cate = this.getCategory();
            int i = -1;
            int size = 0;
            for (int x = 0; x < cate.Length; x++)
            {
                size = size + rep_no_of_rows_aff(cate[x]);
            }
            string[] items = new string[size];
            for (int y = 0; y < cate.Length; y++)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT itemname , itemsize FROM [pizza].[dbo].[item] where itemcateg = '" + cate[y] + "'; ", con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        i++;
                        if (reader.GetSqlInt32(1) >= 0)
                        {
                            items[i] = Convert.ToString(reader.GetSqlString(0)) + " " + Convert.ToString(reader.GetSqlInt32(1));
                        }
                        else
                            items[i] = Convert.ToString(reader.GetSqlString(0));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return null;
                }
                finally
                {
                    con.Close();
                }
            }
            return items;
        }
        public int rep_no_of_rows_aff(String name)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT count(*) FROM [pizza].[dbo].[item] where itemcateg = '" + name + "'; ", con);
                con.Open();
                int rows = (int)cmd.ExecuteScalar();
                return rows;
            }
            catch
            {
                return 0;
            }
            finally
            {
                con.Close();
            }
        }

       
    }
}

