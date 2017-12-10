using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace pizzashop
{

    public partial class Form2 : Form
    {
        private DatabaseManager dbmanager = new DatabaseManager();

        Label[] lbl_item_menu = new Label[50];
        Label[] lbl_bill_item = new Label[50];
        Label[] lbl_bill_item1 = new Label[50];
        int[] lbl_bill_size = new int [50];
        String[] lbl_bill_catg = new String[50];
        Label[] lbl_bill_total = new Label[50];
        TextBox[] tm = new TextBox[50];
        TextBox[] tl = new TextBox[50];
        int stockinsert,stockbox;
        string statusoforder;
        int flagprint = 0,m = 0;

        public Form2()
        {
            InitializeComponent();
            //this.StateChanged += Form2_Resize ;
            this.SizeChanged += new EventHandler(Form2_sizeeventhandler);
        }

        private void refresh()
        {
            for (int j = 0; j < 50; j++)
            {
                lbl_item_menu[j].Text = "";
                lbl_item_menu[j].Refresh();
                lbl_item_menu[j].Visible = false;
                tm[j].Hide();
                tm[j].Text = " ";
                tm[j].Visible = false;
                tm[j].Refresh();
                tl[j].Text = " ";
                tl[j].Hide();
                tl[j].Visible = false;
                tl[j].Refresh();
            }
        }

        private void show_all_menu(string item)
        {
            lbllarge.Text = "L";
            refresh();
            lbldisplaymenu.Visible = true;
            lbldisplaymenu.Text = item;
            lbllarge.Visible = true;
            lblmedium.Visible = true;
            pnlsimply.Visible = true;

            try
            {
                string[] item_names = dbmanager.getItems(item);
                for (i = 0 ; i <= item_names.Length-1; i++)
                {
                    lbl_item_menu[i].Text = item_names[i];
                    lbl_item_menu[i].Visible = true;
                    lbl_item_menu[i].Refresh();
                    
                    tm[i].Visible = true;
                    tm[i].Refresh();
                    
                    tl[i].Visible = true;
                    tl[i].Refresh();
                    
                    pnlsimply.Refresh();
                    pnlsimply.AutoSize = false;
                    pnlsimply.AutoScroll = true;
                }
            }
            catch
            {
                MessageBox.Show("Internal Error! Please try again.");
            }
        }

        private void showallamenu(string item)
        {
            lbllarge.Text = "";
            lbllarge.Refresh();
            i = 0;
            x = 85;
            lbldisplaymenu.Visible = true;
            lbldisplaymenu.Text = item;
            lbllarge.Visible = true;
            lblmedium.Visible = true;
            for (int j = 0; j < 50; j++)
            {
                lbl_item_menu[j].Text = "";
                lbl_item_menu[j].Refresh();
                lbl_item_menu[j].Visible = false;
                tm[j].Hide();
                tm[j].Text = " ";
                tm[j].Visible = false;
                tm[j].Refresh();
                tl[j].Text = " ";
                tl[j].Hide();
                tl[j].Visible = false;
                tl[j].Refresh();
            }
            pnlsimply.Visible = true;

            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=pizza;Integrated Security=True");
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM [pizza].[dbo].[item] where itemcateg = '" + item + "'; ", conn);
                conn.Open();
                //cmd.Parameters.Add(new SqlParameter("Name", "1"));
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = Convert.ToString(reader.GetSqlString(1));
                    //l1[i] = new Label();
                    //l1[i].Location = new Point(60, x);
                    //l1[i].Refresh();
                    //l1[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lbl_item_menu[i].Text = name;
                    lbl_item_menu[i].Visible = true;
                    lbl_item_menu[i].Refresh();
                    tm[i].Text = " ";
                    tm[i].Visible = true;
                    tm[i].Refresh();
                    /*tl[i].Text = " ";
                    tl[i].Visible = true;
                    tl[i].Refresh();*/
                    // pnlsimply.Controls.Add(l1[i]);
                    pnlsimply.Refresh();
                    pnlsimply.AutoSize = false;
                    pnlsimply.AutoScroll = true;
                    i++;
                    x = x + 30;
                    //MessageBox.Show(Convert.ToString(i));
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
            //i = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int custid = 0,s = 0, co = 0;
            int orderno = 0;

            String[] values = new String[5];
            DateTime d = DateTime.Now;
            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=pizza;Integrated Security=True");
            try
            {
                SqlCommand cmd = new SqlCommand("select max(orderno) from [pizza].[dbo].[order]",conn);
                conn.Open();
                co = (int)cmd.ExecuteScalar() + 1;
                MessageBox.Show(Convert.ToString(co));
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                conn.Close();
            }
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from [pizza].[dbo].[order] ", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                int co1 = Convert.ToInt16(co);
                DataTable dt = new DataTable();
                da.Fill(dt);
                orderno = Convert.ToInt16(dt.Rows[co1][1]);
                orderno++;
                MessageBox.Show(Convert.ToString(orderno));
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            

            for (int q = 0; q < m; q++)
            {
                string cmbill = lbl_bill_item1[q].Text;
                string[] splitbill = cmbill.Split('@');
                if(cmbill.CompareTo(null) == 0)
                {
                    break;
                }
                foreach (string word in splitbill)
                {
                    values[s] = word;
                   // MessageBox.Show(values[s]);
                    s++;
                }
               // SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=pizza;Integrated Security=True");
                try
                {
                    SqlCommand cm = new SqlCommand("(select * from [pizza].[dbo].[order] where [phone] = " + txtPhone.Text + " ;", conn);
                    conn.Open();
                    SqlDataReader reader = cm.ExecuteReader();
                    while (reader.Read())
                    {
                        custid = Convert.ToInt16(reader.GetValue(0));
                    }
                    //SqlCommand cm = new SqlCommand("INSERT INTO [pizza].[dbo].[order]([custid],[orderno],[itemname],[itemsize],[itemprice],[date],[itemcateg],[ordtype]) values ('" );
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    conn.Close();
                }

                try
                {
  
                    SqlCommand cm = new SqlCommand("INSERT INTO [pizza].[dbo].[order]([custid],[orderno],[itemname],[itemsize],[itemprice],[date],[itemcateg],[ordtype]) values (" + custid + "," + orderno + ",'" + values[0] + "'," + lbl_bill_size[q] + "," + values[3] + ",'" + d  +"','" + lbl_bill_catg[q] +"','" + values[4] + "');",conn);
                    conn.Open();
                    cm.ExecuteNonQuery();
                    MessageBox.Show("inserted");
                    s = 0;
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    conn.Close();
                }
            }
            
            //((Form1)MdiParent).backtomdi();
            //this.Hide();
            //print the bill
            //Update the sql
            //this.Close();
        }
        private void Form2_sizeeventhandler(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                ((Form1)MdiParent).backtomdi();
            }
            if (this.WindowState == FormWindowState.Maximized)
            {
                ((Form1)MdiParent).backtoform();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            x = 85;
            this.WindowState = FormWindowState.Maximized;
            pnlorder.Visible = false;
            pnllbl.Visible = false;
            pnlpizza.Visible = false;
            pnlmenu.Visible = false;
            pnlsimply.Visible = false;
            // pnlvigge.Visible = false;
            for (int j = 0; j < 50; j++)
            {
                lbl_item_menu[j] = new Label();
                lbl_item_menu[j].Text = " ";
                lbl_item_menu[j].Visible = false;
                lbl_item_menu[j].Location = new Point(60, x);
                tm[j] = new TextBox();
                tm[j].Text = " ";
                tm[j].Visible = false;
                tm[j].Location = new Point(216, x);
                tm[j].Size = new Size(51, 20);
                tl[j] = new TextBox();
                tl[j].Text = " ";
                tl[j].Visible = false;
                tl[j].Location = new Point(306, x);
                tl[j].Size = new Size(51, 20);
                pnlsimply.Controls.Add(lbl_item_menu[j]);
                pnlsimply.Controls.Add(tm[j]);
                pnlsimply.Controls.Add(tl[j]);
                x = x + 30;
            }

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            /*lbl1.Text = txtName.Text;
            lbl2.Text = txtPhone.Text;
            lbl3.Text = txtAddress.Text;
            lbl6.Text = txtEmail.Text;
            try{
                if (dbmanager.addCust(txtName.Text, txtAddress.Text, Convert.ToInt64(txtPhone.Text), txtEmail.Text))
                {
                    MessageBox.Show("Customer added");*/
                    pnllbl.Visible = true;
                    pnlorder.Visible = false;
                    pnlmenu.Visible = true;
                /*}
                else
                    MessageBox.Show("Database out of reach. Please restart the application.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("please");
            }*/
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            pnlpizza.Visible = true;
        }



        private void btnPizzaSpecialtreat_Click(object sender, EventArgs e)
        {
            //pnlsimply.Visible = false;
            //pnlVeggieTreat.Visible = false;

        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            //x = 85;
            pnlpizza.Visible = true;
            pnlpizzza.Visible = true;
            pnlsimply.Visible = false;
            lbldisplaymenu.Hide();
            lbllarge.Hide();
            lblmedium.Hide();

            /*for (int j = 0; j < 50; j++)
            {
                l1[j] = new Label();
                l1[j].Text = " ";
                l1[j].Visible = false;
                l1[j].Location = new Point(60, x);
                pnlsimply.Controls.Add(l1[j]);
                x = x + 30;
            }*/

        }
        int x;
        int i;
        private void btnsimplyTreat_Click(object sender, EventArgs e)
        {
            //showpizzamenu("SIMPLE TREAT");
            show_all_menu("SIMPLE TREAT");
        }

        private void btnviggieTreat_Click(object sender, EventArgs e)
        {
            //showpizzamenu("VEGGIE PIZZA");
            show_all_menu("VEGGIE PIZZA");
        }
        private void btnyummyTreat_Click(object sender, EventArgs e)
        {
            //showpizzamenu("YUMMY TREAT");
            show_all_menu("YUMMY TREAT");
        }

        private void btnPizzaSpecialtreat_Click_1(object sender, EventArgs e)
        {
            //showpizzamenu("SPECIAL TREAT");
            show_all_menu("SPECIAL TREAT");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            pnlpizza.Visible = false;
            showallamenu("BURGER TREAT");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            pnlpizza.Visible = false;
            showallamenu("GARLIC BREAD TREAT");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            pnlpizza.Visible = false;
            showallamenu("FRENCH FRIES");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            pnlpizza.Visible = false;
            showallamenu("GRILLED SANDWICH TREAT");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            pnlpizza.Visible = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            pnlpizza.Visible = false;
            showallamenu("DESERT TREAT");
        }
        int y = 43;
        private void btnsubmitmenu_Click(object sender, EventArgs e)
        {
            string[] pizzname = new string[50];
            int[] price = new int[50];
            int[] total = new int[50];
            Int16[] qt = new Int16[50];

            pnlsubmit.Visible = true;
            for (int k = 0; k < i; k++)
            {
                string pizza = lbldisplaymenu.Text;
                if (pizza == "SIMPLE TREAT" || pizza == "VEGGIE PIZZA" || pizza == "YUMMY TREAT" || pizza == "SPECIAL TREAT")
                {
                    if (tm[k].Text != " ")
                    {//take order for tm[k]
                        string cpizz = lbl_item_menu[k].Text;
                        string qt1 = tm[k].Text;
                        //MessageBox.Show(l1[k].Text +"  "+qt1);
                        qt[k] = Convert.ToInt16(qt1);
                        SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=pizza;Integrated Security=True");
                        SqlConnection conn1 = new SqlConnection("Data Source=(local);Initial Catalog=pizza;Integrated Security=True");
                        SqlConnection conn2 = new SqlConnection("Data Source=(local);Initial Catalog=pizza;Integrated Security=True");
                        SqlConnection conn3 = new SqlConnection("Data Source=(local);Initial Catalog=pizza;Integrated Security=True");
                        SqlConnection conn4 = new SqlConnection("Data Source=(local);Initial Catalog=pizza;Integrated Security=True");
                        try
                        {
                            //MessageBox.Show("inside try b4 sql com");
                            SqlCommand cmd = new SqlCommand("SELECT * FROM [pizza].[dbo].[item] where itemname = '" + cpizz + "' and itemsize = 8 ; ", conn);
                            conn.Open();
                            //MessageBox.Show("after conn open");
                            SqlDataReader reader = cmd.ExecuteReader();
                            //MessageBox.Show("execute reader done");
                            while (reader.Read())
                            {
                                //MessageBox.Show("inside reader");
                                pizzname[k] = Convert.ToString(reader.GetSqlString(1));
                                price[k] = Convert.ToInt16(reader.GetValue(4));
                                total[k] = (qt[k] * price[k]);
                                //MessageBox.Show(pizzname +"in while loop");

                                try
                                {

                                    SqlCommand cmd1 = new SqlCommand("SELECT * FROM [pizza].[dbo].[stock] where item = 'PIZZA BASE 8';", conn1);
                                    conn1.Open();
                                    SqlDataReader reader1 = cmd1.ExecuteReader();
                                    while (reader1.Read())
                                    {
                                        int check = Convert.ToInt16(reader1.GetValue(1));
                                        if (check >= qt[k])
                                        {
                                            stockinsert = check - qt[k];
                                            //.Show(Convert.ToString(stockinsert));
                                            try
                                            {
                                                SqlCommand cmd2 = new SqlCommand("update [pizza].[dbo].[stock] set  quantity = " + stockinsert + " where item = 'PIZZA BASE 8';", conn2);
                                                conn2.Open();
                                                cmd2.ExecuteNonQuery();
                                               
                                                //MessageBox.Show("updated");
                                            }
                                            catch (Exception)
                                            {

                                            }
                                            finally
                                            {
                                                conn2.Close();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("pizza bread 8 is finished");
                                            tm[k].Text = " ";
                                            flagprint = 1;
                                            break;
                                        }

                                       

                                    }
                                }
                                catch (Exception)
                                {

                                }
                                finally
                                {
                                    conn1.Close();
                                }

                                if (statusoforder.CompareTo("takeaway") == 0 || statusoforder.CompareTo("delivery") == 0)
                                {
                                    try
                                    {
                                        SqlCommand cmd3 = new SqlCommand("SELECT * FROM [pizza].[dbo].[stock] where item = 'BOX 8';", conn3);
                                        conn3.Open();
                                        SqlDataReader reader2 = cmd3.ExecuteReader();
                                        while (reader2.Read())
                                        {
                                            int checq = Convert.ToInt16(reader2.GetValue(1));
                                            {
                                                if (checq >= qt[k])
                                                {
                                                    stockbox = checq - qt[k];
                                                    try
                                                    {
                                                        SqlCommand cmd4 = new SqlCommand("update [pizza].[dbo].[stock] set  quantity = " + stockbox + " where item = 'PIZZA BASE 8';", conn4);
                                                        conn4.Open();
                                                        cmd4.ExecuteNonQuery();

                                                        //MessageBox.Show("updated");
                                                    }
                                                    catch (Exception)
                                                    {

                                                    }
                                                    finally
                                                    {
                                                        conn4.Close();
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("pizza box 8 is finished");
                                                    tm[k].Text = " ";
                                                    flagprint = 1;
                                                    break;
                                                }
                                            }
                                        }

                                    }
                                    catch (Exception ex)
                                    {
                                    }
                                    finally
                                    {
                                        conn3.Close();
                                    }
                                }

                                if (flagprint == 0)
                                {
                                    
                                    lbl_bill_item[m] = new Label();
                                    lbl_bill_item[m].Text = pizzname[k] + "           " + qt[k] + "           " + price[k] + "           " + total[k] + "           " + statusoforder;
                                    lbl_bill_item[m].Size = new Size(500, 13);
                                    lbl_bill_item[m].Location = new Point(52, y);
                                    lbl_bill_size[m] = 8;
                                    lbl_bill_catg[m] = pizza;
                                    lbl_bill_item1[m] = new Label();
                                    lbl_bill_item1[m].Text = pizzname[k] + "@" + qt[k] + "@" + price[k] + "@" + total[k] + "@" + statusoforder;
                                    lbl_bill_item1[m].Size = new Size(500, 13);
                                    lbl_bill_item1[m].Location = new Point(52, y);

                                    pnlsubmit.Controls.Add(lbl_bill_item[m]);
                                    /*pnlsubmit.Controls.Add(lbl_bill_qty[bill]);
                                    pnlsubmit.Controls.Add(lbl_bill_price[bill]);
                                    pnlsubmit.Controls.Add(lbl_bill_total[bill]);*/
                                    pnlsubmit.AutoScroll = true;
                                    pnlsubmit.AutoSize = false;
                                    y = y + 20;
                                    tm[k].Text = " ";
                                    m++;
                                }

                            }

                        }
                        catch (Exception)
                        {

                        }
                        finally
                        {
                            conn.Close();
                        }

                       
                    }

                    if (tl[k].Text != " ")
                    {//take order for tm[k]
                        string cpizz = lbl_item_menu[k].Text;
                        string qt1 = tl[k].Text;
                        //MessageBox.Show(l1[k].Text +"  "+qt1);;
                        qt[k] = Convert.ToInt16(qt1);
                        SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=pizza;Integrated Security=True");
                        SqlConnection conn1 = new SqlConnection("Data Source=(local);Initial Catalog=pizza;Integrated Security=True");
                        SqlConnection conn2 = new SqlConnection("Data Source=(local);Initial Catalog=pizza;Integrated Security=True");
                        SqlConnection conn3 = new SqlConnection("Data Source=(local);Initial Catalog=pizza;Integrated Security=True");
                        SqlConnection conn4 = new SqlConnection("Data Source=(local);Initial Catalog=pizza;Integrated Security=True");
                        try
                        {
                            //MessageBox.Show("inside try b4 sql com");
                            SqlCommand cmd = new SqlCommand("SELECT * FROM [pizza].[dbo].[item] where itemname = '" + cpizz + "' and itemsize = 12 ; ", conn);
                            conn.Open();
                            //MessageBox.Show("after conn open");
                            SqlDataReader reader = cmd.ExecuteReader();
                            //MessageBox.Show("execute reader done");
                            while (reader.Read())
                            {
                                //MessageBox.Show("inside reader");
                                pizzname[k] = Convert.ToString(reader.GetSqlString(1));
                                price[k] = Convert.ToInt16(reader.GetValue(4));
                                total[k] = (qt[k] * price[k]);
                                //MessageBox.Show(pizzname +"in while loop");

                                try
                                {

                                    SqlCommand cmd1 = new SqlCommand("SELECT * FROM [pizza].[dbo].[stock] where item = 'PIZZA BASE 12';", conn1);
                                    conn1.Open();
                                    SqlDataReader reader1 = cmd1.ExecuteReader();
                                    while (reader1.Read())
                                    {
                                        int check = Convert.ToInt16(reader1.GetValue(1));
                                        if (check >= qt[k])
                                        {
                                            stockinsert = check - qt[k];
                                            //.Show(Convert.ToString(stockinsert));
                                            try
                                            {
                                                SqlCommand cmd2 = new SqlCommand("update [pizza].[dbo].[stock] set  quantity = " + stockinsert + " where item = 'PIZZA BASE 12';", conn2);
                                                conn2.Open();
                                                cmd2.ExecuteNonQuery();

                                                //MessageBox.Show("updated");
                                            }
                                            catch (Exception)
                                            {

                                            }
                                            finally
                                            {
                                                conn2.Close();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("pizza bread 12 is finished");
                                            tl[k].Text = " ";
                                            flagprint = 1;
                                            break;
                                        }



                                    }
                                }
                                catch (Exception)
                                {

                                }
                                finally
                                {
                                    conn1.Close();
                                }

                                if (statusoforder.CompareTo("takeaway") == 0 || statusoforder.CompareTo("delivery") == 0)
                                {
                                    try
                                    {
                                        SqlCommand cmd3 = new SqlCommand("SELECT * FROM [pizza].[dbo].[stock] where item = 'BOX 12';", conn3);
                                        conn3.Open();
                                        SqlDataReader reader2 = cmd3.ExecuteReader();
                                        while (reader2.Read())
                                        {
                                            int checq = Convert.ToInt16(reader2.GetValue(1));
                                            {
                                                if (checq >= qt[k])
                                                {
                                                    stockbox = checq - qt[k];
                                                    try
                                                    {
                                                        SqlCommand cmd4 = new SqlCommand("update [pizza].[dbo].[stock] set  quantity = " + stockbox + " where item = 'PIZZA BASE 12';", conn4);
                                                        conn4.Open();
                                                        cmd4.ExecuteNonQuery();

                                                        //MessageBox.Show("updated");
                                                    }
                                                    catch (Exception)
                                                    {

                                                    }
                                                    finally
                                                    {
                                                        conn4.Close();
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("pizza box 12 is finished");
                                                    tl[k].Text = " ";
                                                    flagprint = 1;
                                                    break;
                                                }
                                            }
                                        }

                                    }
                                    catch (Exception ex)
                                    {
                                    }
                                    finally
                                    {
                                        conn3.Close();
                                    }
                                }

                                if (flagprint == 0)
                                {
                                    lbl_bill_item[m] = new Label();
                                    lbl_bill_item[m].Text = pizzname[k] + "           " + qt[k] + "           " + price[k] + "           " + total[k] + "           "+statusoforder;
                                    lbl_bill_item[m].Size = new Size(500, 13);
                                    lbl_bill_item[m].Location = new Point(52, y);
                                    lbl_bill_size[m] = 8;
                                    lbl_bill_catg[m] = pizza;
                                    lbl_bill_item1[m] = new Label();
                                    lbl_bill_item1[m].Text = pizzname[k] + "@" + qt[k] + "@" + price[k] + "@" + total[k] + "@" + statusoforder;
                                    lbl_bill_item1[m].Size = new Size(500, 13);
                                    lbl_bill_item1[m].Location = new Point(52, y);

                                    pnlsubmit.Controls.Add(lbl_bill_item[m]);
                                    /*pnlsubmit.Controls.Add(lbl_bill_qty[bill]);
                                    pnlsubmit.Controls.Add(lbl_bill_price[bill]);
                                    pnlsubmit.Controls.Add(lbl_bill_total[bill]);*/
                                    pnlsubmit.AutoScroll = true;
                                    pnlsubmit.AutoSize = false;
                                    y = y + 20;
                                    tl[k].Text = " ";
                                    m++;
                                }

                            }

                        }
                        catch (Exception)
                        {

                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
                else
                {
                    if (tm[k].Text != " ")
                    {//take order for tm[k]
                        string cpizz = lbl_item_menu[k].Text;
                        string qt1 = tm[k].Text;
                        //MessageBox.Show(l1[k].Text +"  "+qt1);
                        qt[k] = Convert.ToInt16(qt1);
                        SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=pizza;Integrated Security=True");
                        try
                        {
                            //MessageBox.Show("inside try b4 sql com");
                            SqlCommand cmd = new SqlCommand("SELECT * FROM [pizza].[dbo].[item] where itemname = '" + cpizz + "'; ", conn);
                            conn.Open();
                            //MessageBox.Show("after conn open");
                            SqlDataReader reader = cmd.ExecuteReader();
                            //MessageBox.Show("execute reader done");
                            while (reader.Read())
                            {
                                //MessageBox.Show("inside reader");
                                pizzname[k] = Convert.ToString(reader.GetSqlString(1));
                                price[k] = Convert.ToInt16(reader.GetValue(4));
                                total[k] = (qt[k] * price[k]);
                                //MessageBox.Show(pizzname +"in while loop");

                                lbl_bill_item[m] = new Label();
                                lbl_bill_item[m].Text = pizzname[k] + "           " + qt[k] + "            " + price[k] + "                  " + total[k];
                                lbl_bill_item[m].Size = new Size(500, 13);
                                lbl_bill_item[m].Location = new Point(52, y);
                                lbl_bill_size[m] = 8;
                                lbl_bill_catg[m] = pizza;
                                lbl_bill_item1[m] = new Label();
                                lbl_bill_item1[m].Text = pizzname[k] + "@" + qt[k] + "@" + price[k] + "@" + total[k] + "@" + statusoforder;
                                lbl_bill_item1[m].Size = new Size(500, 13);
                                lbl_bill_item1[m].Location = new Point(52, y);


                                pnlsubmit.Controls.Add(lbl_bill_item[m]);
                                pnlsubmit.AutoScroll = true;
                                pnlsubmit.AutoSize = false;
                                y = y + 20;
                                m++;

                            }

                        }
                        catch (Exception)
                        {

                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            pnlpizza.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            statusoforder = "dine";
            panel1.Visible = false;
            pnlorder.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            statusoforder = "takeaway";
            panel1.Visible = false;
            pnlorder.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            statusoforder = "delivery";
            panel1.Visible = false;
            pnlorder.Visible = true;
        }
    }
}
