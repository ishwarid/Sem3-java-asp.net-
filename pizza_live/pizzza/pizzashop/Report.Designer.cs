namespace pizzashop
{
    partial class Report
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
            this.rcmb1 = new System.Windows.Forms.ComboBox();
            this.rbtn11 = new System.Windows.Forms.Button();
            this.rpnl4 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rlbl1 = new System.Windows.Forms.Label();
            this.rbtn9 = new System.Windows.Forms.Button();
            this.rbtn10 = new System.Windows.Forms.Button();
            this.rbtn7 = new System.Windows.Forms.Button();
            this.rpnl5 = new System.Windows.Forms.Panel();
            this.rpnl2 = new System.Windows.Forms.Panel();
            this.rpnl3 = new System.Windows.Forms.Panel();
            this.cmbtype = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rpnl5.SuspendLayout();
            this.rpnl2.SuspendLayout();
            this.rpnl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rcmb1
            // 
            this.rcmb1.FormattingEnabled = true;
            this.rcmb1.Location = new System.Drawing.Point(14, 32);
            this.rcmb1.Name = "rcmb1";
            this.rcmb1.Size = new System.Drawing.Size(208, 21);
            this.rcmb1.TabIndex = 6;
            this.rcmb1.SelectedIndexChanged += new System.EventHandler(this.rcmb1_SelectedIndexChanged);
            // 
            // rbtn11
            // 
            this.rbtn11.Location = new System.Drawing.Point(870, 56);
            this.rbtn11.Name = "rbtn11";
            this.rbtn11.Size = new System.Drawing.Size(75, 50);
            this.rbtn11.TabIndex = 11;
            this.rbtn11.Text = "BACK";
            this.rbtn11.UseVisualStyleBackColor = true;
            this.rbtn11.Click += new System.EventHandler(this.rbtn11_Click);
            // 
            // rpnl4
            // 
            this.rpnl4.AutoScroll = true;
            this.rpnl4.Location = new System.Drawing.Point(12, 154);
            this.rpnl4.Name = "rpnl4";
            this.rpnl4.Size = new System.Drawing.Size(1167, 577);
            this.rpnl4.TabIndex = 10;
            this.rpnl4.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(85, 66);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TO DATE: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(85, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // rlbl1
            // 
            this.rlbl1.AutoSize = true;
            this.rlbl1.Location = new System.Drawing.Point(3, 21);
            this.rlbl1.Name = "rlbl1";
            this.rlbl1.Size = new System.Drawing.Size(76, 13);
            this.rlbl1.TabIndex = 0;
            this.rlbl1.Text = "FROM DATE: ";
            // 
            // rbtn9
            // 
            this.rbtn9.Location = new System.Drawing.Point(21, 72);
            this.rbtn9.Name = "rbtn9";
            this.rbtn9.Size = new System.Drawing.Size(75, 31);
            this.rbtn9.TabIndex = 2;
            this.rbtn9.Text = "FROM-TO";
            this.rbtn9.UseVisualStyleBackColor = true;
            this.rbtn9.Click += new System.EventHandler(this.rbtn9_Click);
            // 
            // rbtn10
            // 
            this.rbtn10.Location = new System.Drawing.Point(85, 104);
            this.rbtn10.Name = "rbtn10";
            this.rbtn10.Size = new System.Drawing.Size(75, 23);
            this.rbtn10.TabIndex = 4;
            this.rbtn10.Text = "OK";
            this.rbtn10.UseVisualStyleBackColor = true;
            this.rbtn10.Click += new System.EventHandler(this.rbtn10_Click);
            // 
            // rbtn7
            // 
            this.rbtn7.Location = new System.Drawing.Point(21, 21);
            this.rbtn7.Name = "rbtn7";
            this.rbtn7.Size = new System.Drawing.Size(75, 32);
            this.rbtn7.TabIndex = 0;
            this.rbtn7.Text = "TODAY";
            this.rbtn7.UseVisualStyleBackColor = true;
            this.rbtn7.Click += new System.EventHandler(this.rbtn7_Click);
            // 
            // rpnl5
            // 
            this.rpnl5.Controls.Add(this.rcmb1);
            this.rpnl5.Location = new System.Drawing.Point(586, 12);
            this.rpnl5.Name = "rpnl5";
            this.rpnl5.Size = new System.Drawing.Size(234, 136);
            this.rpnl5.TabIndex = 12;
            this.rpnl5.Visible = false;
            // 
            // rpnl2
            // 
            this.rpnl2.Controls.Add(this.rbtn9);
            this.rpnl2.Controls.Add(this.rbtn7);
            this.rpnl2.Location = new System.Drawing.Point(209, 12);
            this.rpnl2.Name = "rpnl2";
            this.rpnl2.Size = new System.Drawing.Size(116, 127);
            this.rpnl2.TabIndex = 8;
            this.rpnl2.Visible = false;
            // 
            // rpnl3
            // 
            this.rpnl3.Controls.Add(this.rbtn10);
            this.rpnl3.Controls.Add(this.dateTimePicker2);
            this.rpnl3.Controls.Add(this.label1);
            this.rpnl3.Controls.Add(this.dateTimePicker1);
            this.rpnl3.Controls.Add(this.rlbl1);
            this.rpnl3.Location = new System.Drawing.Point(340, 12);
            this.rpnl3.Name = "rpnl3";
            this.rpnl3.Size = new System.Drawing.Size(229, 136);
            this.rpnl3.TabIndex = 9;
            this.rpnl3.Visible = false;
            // 
            // cmbtype
            // 
            this.cmbtype.FormattingEnabled = true;
            this.cmbtype.Location = new System.Drawing.Point(22, 72);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.Size = new System.Drawing.Size(181, 21);
            this.cmbtype.TabIndex = 13;
            this.cmbtype.Text = "Select Type of Report";
            this.cmbtype.SelectedIndexChanged += new System.EventHandler(this.cmbtype_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Select Report Type";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 735);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbtype);
            this.Controls.Add(this.rbtn11);
            this.Controls.Add(this.rpnl4);
            this.Controls.Add(this.rpnl5);
            this.Controls.Add(this.rpnl2);
            this.Controls.Add(this.rpnl3);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load_1);
            this.rpnl5.ResumeLayout(false);
            this.rpnl2.ResumeLayout(false);
            this.rpnl3.ResumeLayout(false);
            this.rpnl3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox rcmb1;
        private System.Windows.Forms.Button rbtn11;
        private System.Windows.Forms.Panel rpnl4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label rlbl1;
        private System.Windows.Forms.Button rbtn9;
        private System.Windows.Forms.Button rbtn10;
        private System.Windows.Forms.Button rbtn7;
        private System.Windows.Forms.Panel rpnl5;
        private System.Windows.Forms.Panel rpnl2;
        private System.Windows.Forms.Panel rpnl3;
        private System.Windows.Forms.ComboBox cmbtype;
        private System.Windows.Forms.Label label2;
    }
}