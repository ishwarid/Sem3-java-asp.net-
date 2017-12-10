namespace pizzashop
{
    partial class Stock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.stpnl1 = new System.Windows.Forms.Panel();
            this.btnstok = new System.Windows.Forms.Button();
            this.txtqun = new System.Windows.Forms.TextBox();
            this.txtstname = new System.Windows.Forms.TextBox();
            this.lblqun = new System.Windows.Forms.Label();
            this.lblstitem = new System.Windows.Forms.Label();
            this.lblqty = new System.Windows.Forms.Label();
            this.stbtn3 = new System.Windows.Forms.Button();
            this.stbtn2 = new System.Windows.Forms.Button();
            this.stbtn1 = new System.Windows.Forms.Button();
            this.stdatagrid1 = new System.Windows.Forms.DataGridView();
            this.stbtnupdate = new System.Windows.Forms.Button();
            this.stpnl2 = new System.Windows.Forms.Panel();
            this.stbtnupdateok = new System.Windows.Forms.Button();
            this.sttxtquan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbitem = new System.Windows.Forms.ComboBox();
            this.stpnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stdatagrid1)).BeginInit();
            this.stpnl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // stpnl1
            // 
            this.stpnl1.Controls.Add(this.btnstok);
            this.stpnl1.Controls.Add(this.txtqun);
            this.stpnl1.Controls.Add(this.txtstname);
            this.stpnl1.Controls.Add(this.lblqun);
            this.stpnl1.Controls.Add(this.lblstitem);
            this.stpnl1.Controls.Add(this.lblqty);
            this.stpnl1.Location = new System.Drawing.Point(167, 12);
            this.stpnl1.Name = "stpnl1";
            this.stpnl1.Size = new System.Drawing.Size(294, 202);
            this.stpnl1.TabIndex = 8;
            this.stpnl1.Visible = false;
            // 
            // btnstok
            // 
            this.btnstok.Location = new System.Drawing.Point(111, 162);
            this.btnstok.Name = "btnstok";
            this.btnstok.Size = new System.Drawing.Size(75, 23);
            this.btnstok.TabIndex = 5;
            this.btnstok.Text = "OK";
            this.btnstok.UseVisualStyleBackColor = true;
            this.btnstok.Click += new System.EventHandler(this.btnstok_Click);
            // 
            // txtqun
            // 
            this.txtqun.Location = new System.Drawing.Point(111, 107);
            this.txtqun.Name = "txtqun";
            this.txtqun.Size = new System.Drawing.Size(100, 20);
            this.txtqun.TabIndex = 4;
            // 
            // txtstname
            // 
            this.txtstname.Location = new System.Drawing.Point(111, 60);
            this.txtstname.Name = "txtstname";
            this.txtstname.Size = new System.Drawing.Size(100, 20);
            this.txtstname.TabIndex = 3;
            // 
            // lblqun
            // 
            this.lblqun.AutoSize = true;
            this.lblqun.Location = new System.Drawing.Point(27, 107);
            this.lblqun.Name = "lblqun";
            this.lblqun.Size = new System.Drawing.Size(62, 13);
            this.lblqun.TabIndex = 2;
            this.lblqun.Text = "QUANTITY";
            // 
            // lblstitem
            // 
            this.lblstitem.AutoSize = true;
            this.lblstitem.Location = new System.Drawing.Point(27, 63);
            this.lblstitem.Name = "lblstitem";
            this.lblstitem.Size = new System.Drawing.Size(38, 13);
            this.lblstitem.TabIndex = 1;
            this.lblstitem.Text = "NAME";
            // 
            // lblqty
            // 
            this.lblqty.AutoSize = true;
            this.lblqty.Location = new System.Drawing.Point(92, 18);
            this.lblqty.Name = "lblqty";
            this.lblqty.Size = new System.Drawing.Size(109, 13);
            this.lblqty.TabIndex = 0;
            this.lblqty.Text = "ITEM TO BE ADDED";
            // 
            // stbtn3
            // 
            this.stbtn3.Location = new System.Drawing.Point(57, 149);
            this.stbtn3.Name = "stbtn3";
            this.stbtn3.Size = new System.Drawing.Size(75, 23);
            this.stbtn3.TabIndex = 7;
            this.stbtn3.Text = "BACK";
            this.stbtn3.UseVisualStyleBackColor = true;
            this.stbtn3.Click += new System.EventHandler(this.stbtn3_Click);
            // 
            // stbtn2
            // 
            this.stbtn2.Location = new System.Drawing.Point(57, 65);
            this.stbtn2.Name = "stbtn2";
            this.stbtn2.Size = new System.Drawing.Size(75, 23);
            this.stbtn2.TabIndex = 6;
            this.stbtn2.Text = "ADD";
            this.stbtn2.UseVisualStyleBackColor = true;
            this.stbtn2.Click += new System.EventHandler(this.stbtn2_Click);
            // 
            // stbtn1
            // 
            this.stbtn1.Location = new System.Drawing.Point(57, 25);
            this.stbtn1.Name = "stbtn1";
            this.stbtn1.Size = new System.Drawing.Size(75, 23);
            this.stbtn1.TabIndex = 4;
            this.stbtn1.Text = "CHECK";
            this.stbtn1.UseVisualStyleBackColor = true;
            this.stbtn1.Click += new System.EventHandler(this.stbtn1_Click);
            // 
            // stdatagrid1
            // 
            this.stdatagrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stdatagrid1.Location = new System.Drawing.Point(12, 326);
            this.stdatagrid1.Name = "stdatagrid1";
            this.stdatagrid1.Size = new System.Drawing.Size(821, 274);
            this.stdatagrid1.TabIndex = 5;
            this.stdatagrid1.Visible = false;
            // 
            // stbtnupdate
            // 
            this.stbtnupdate.Location = new System.Drawing.Point(57, 109);
            this.stbtnupdate.Name = "stbtnupdate";
            this.stbtnupdate.Size = new System.Drawing.Size(75, 23);
            this.stbtnupdate.TabIndex = 9;
            this.stbtnupdate.Text = "UPDATE";
            this.stbtnupdate.UseVisualStyleBackColor = true;
            this.stbtnupdate.Click += new System.EventHandler(this.stbtnupdate_Click);
            // 
            // stpnl2
            // 
            this.stpnl2.Controls.Add(this.cmbitem);
            this.stpnl2.Controls.Add(this.stbtnupdateok);
            this.stpnl2.Controls.Add(this.sttxtquan);
            this.stpnl2.Controls.Add(this.label1);
            this.stpnl2.Controls.Add(this.label2);
            this.stpnl2.Controls.Add(this.label3);
            this.stpnl2.Location = new System.Drawing.Point(510, 12);
            this.stpnl2.Name = "stpnl2";
            this.stpnl2.Size = new System.Drawing.Size(294, 202);
            this.stpnl2.TabIndex = 10;
            this.stpnl2.Visible = false;
            // 
            // stbtnupdateok
            // 
            this.stbtnupdateok.Location = new System.Drawing.Point(111, 162);
            this.stbtnupdateok.Name = "stbtnupdateok";
            this.stbtnupdateok.Size = new System.Drawing.Size(75, 23);
            this.stbtnupdateok.TabIndex = 5;
            this.stbtnupdateok.Text = "UPDATE";
            this.stbtnupdateok.UseVisualStyleBackColor = true;
            this.stbtnupdateok.Click += new System.EventHandler(this.stbtnupdateok_Click);
            // 
            // sttxtquan
            // 
            this.sttxtquan.Location = new System.Drawing.Point(111, 107);
            this.sttxtquan.Name = "sttxtquan";
            this.sttxtquan.Size = new System.Drawing.Size(100, 20);
            this.sttxtquan.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUANTITY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "QTY TO BE ADDED";
            // 
            // cmbitem
            // 
            this.cmbitem.FormattingEnabled = true;
            this.cmbitem.Location = new System.Drawing.Point(95, 58);
            this.cmbitem.Name = "cmbitem";
            this.cmbitem.Size = new System.Drawing.Size(177, 21);
            this.cmbitem.TabIndex = 6;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 502);
            this.Controls.Add(this.stpnl2);
            this.Controls.Add(this.stbtnupdate);
            this.Controls.Add(this.stdatagrid1);
            this.Controls.Add(this.stpnl1);
            this.Controls.Add(this.stbtn3);
            this.Controls.Add(this.stbtn2);
            this.Controls.Add(this.stbtn1);
            this.Name = "Stock";
            this.stpnl1.ResumeLayout(false);
            this.stpnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stdatagrid1)).EndInit();
            this.stpnl2.ResumeLayout(false);
            this.stpnl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel stpnl1;
        private System.Windows.Forms.TextBox txtqun;
        private System.Windows.Forms.TextBox txtstname;
        private System.Windows.Forms.Label lblqun;
        private System.Windows.Forms.Label lblstitem;
        private System.Windows.Forms.Label lblqty;
        private System.Windows.Forms.Button stbtn3;
        private System.Windows.Forms.Button stbtn2;
        private System.Windows.Forms.Button stbtn1;
        private System.Windows.Forms.DataGridView stdatagrid1;
        private System.Windows.Forms.Button btnstok;
        private System.Windows.Forms.Button stbtnupdate;
        private System.Windows.Forms.Panel stpnl2;
        private System.Windows.Forms.Button stbtnupdateok;
        private System.Windows.Forms.TextBox sttxtquan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbitem;

    }
}