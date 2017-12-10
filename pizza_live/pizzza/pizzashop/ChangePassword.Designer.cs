namespace pizzashop
{
    partial class ChangePassword
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Admin_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Shop_lbl = new System.Windows.Forms.Label();
            this.txt_admin_old_pass = new System.Windows.Forms.TextBox();
            this.txt_admin_new_pass = new System.Windows.Forms.TextBox();
            this.txt_admin_new_pass_r = new System.Windows.Forms.TextBox();
            this.txt_shop_old_pass = new System.Windows.Forms.TextBox();
            this.txt_shop_new_pass = new System.Windows.Forms.TextBox();
            this.txt_shop_new_pass_r = new System.Windows.Forms.TextBox();
            this.btn_admin_change = new System.Windows.Forms.Button();
            this.btn_shop_change = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btn_admin_change);
            this.splitContainer1.Panel1.Controls.Add(this.txt_admin_new_pass_r);
            this.splitContainer1.Panel1.Controls.Add(this.txt_admin_new_pass);
            this.splitContainer1.Panel1.Controls.Add(this.txt_admin_old_pass);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.Admin_lbl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.btn_shop_change);
            this.splitContainer1.Panel2.Controls.Add(this.txt_shop_new_pass_r);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.txt_shop_new_pass);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.txt_shop_old_pass);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.Shop_lbl);
            this.splitContainer1.Size = new System.Drawing.Size(448, 450);
            this.splitContainer1.SplitterDistance = 215;
            this.splitContainer1.TabIndex = 0;
            // 
            // Admin_lbl
            // 
            this.Admin_lbl.AutoSize = true;
            this.Admin_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_lbl.Location = new System.Drawing.Point(41, 26);
            this.Admin_lbl.Name = "Admin_lbl";
            this.Admin_lbl.Size = new System.Drawing.Size(54, 18);
            this.Admin_lbl.TabIndex = 0;
            this.Admin_lbl.Text = "Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Old Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Retype Password ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Retype Password ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "New Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Old Password";
            // 
            // Shop_lbl
            // 
            this.Shop_lbl.AutoSize = true;
            this.Shop_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shop_lbl.Location = new System.Drawing.Point(41, 29);
            this.Shop_lbl.Name = "Shop_lbl";
            this.Shop_lbl.Size = new System.Drawing.Size(47, 18);
            this.Shop_lbl.TabIndex = 4;
            this.Shop_lbl.Text = "Shop";
            // 
            // txt_admin_old_pass
            // 
            this.txt_admin_old_pass.Location = new System.Drawing.Point(215, 58);
            this.txt_admin_old_pass.Name = "txt_admin_old_pass";
            this.txt_admin_old_pass.PasswordChar = '*';
            this.txt_admin_old_pass.Size = new System.Drawing.Size(128, 20);
            this.txt_admin_old_pass.TabIndex = 1;
            // 
            // txt_admin_new_pass
            // 
            this.txt_admin_new_pass.Location = new System.Drawing.Point(215, 94);
            this.txt_admin_new_pass.Name = "txt_admin_new_pass";
            this.txt_admin_new_pass.PasswordChar = '*';
            this.txt_admin_new_pass.Size = new System.Drawing.Size(128, 20);
            this.txt_admin_new_pass.TabIndex = 2;
            // 
            // txt_admin_new_pass_r
            // 
            this.txt_admin_new_pass_r.Location = new System.Drawing.Point(215, 133);
            this.txt_admin_new_pass_r.Name = "txt_admin_new_pass_r";
            this.txt_admin_new_pass_r.PasswordChar = '*';
            this.txt_admin_new_pass_r.Size = new System.Drawing.Size(128, 20);
            this.txt_admin_new_pass_r.TabIndex = 3;
            // 
            // txt_shop_old_pass
            // 
            this.txt_shop_old_pass.Location = new System.Drawing.Point(215, 61);
            this.txt_shop_old_pass.Name = "txt_shop_old_pass";
            this.txt_shop_old_pass.PasswordChar = '*';
            this.txt_shop_old_pass.Size = new System.Drawing.Size(128, 20);
            this.txt_shop_old_pass.TabIndex = 1;
            // 
            // txt_shop_new_pass
            // 
            this.txt_shop_new_pass.Location = new System.Drawing.Point(215, 97);
            this.txt_shop_new_pass.Name = "txt_shop_new_pass";
            this.txt_shop_new_pass.PasswordChar = '*';
            this.txt_shop_new_pass.Size = new System.Drawing.Size(128, 20);
            this.txt_shop_new_pass.TabIndex = 2;
            // 
            // txt_shop_new_pass_r
            // 
            this.txt_shop_new_pass_r.Location = new System.Drawing.Point(215, 136);
            this.txt_shop_new_pass_r.Name = "txt_shop_new_pass_r";
            this.txt_shop_new_pass_r.PasswordChar = '*';
            this.txt_shop_new_pass_r.Size = new System.Drawing.Size(128, 20);
            this.txt_shop_new_pass_r.TabIndex = 3;
            // 
            // btn_admin_change
            // 
            this.btn_admin_change.Location = new System.Drawing.Point(163, 172);
            this.btn_admin_change.Name = "btn_admin_change";
            this.btn_admin_change.Size = new System.Drawing.Size(91, 31);
            this.btn_admin_change.TabIndex = 4;
            this.btn_admin_change.Text = "Change";
            this.btn_admin_change.UseVisualStyleBackColor = true;
            this.btn_admin_change.Click += new System.EventHandler(this.btn_admin_change_Click);
            // 
            // btn_shop_change
            // 
            this.btn_shop_change.Location = new System.Drawing.Point(163, 178);
            this.btn_shop_change.Name = "btn_shop_change";
            this.btn_shop_change.Size = new System.Drawing.Size(91, 31);
            this.btn_shop_change.TabIndex = 4;
            this.btn_shop_change.Text = "Change";
            this.btn_shop_change.UseVisualStyleBackColor = true;
            this.btn_shop_change.Click += new System.EventHandler(this.btn_shop_change_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(345, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "*";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_admin_change;
        private System.Windows.Forms.TextBox txt_admin_new_pass_r;
        private System.Windows.Forms.TextBox txt_admin_new_pass;
        private System.Windows.Forms.TextBox txt_admin_old_pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Admin_lbl;
        private System.Windows.Forms.Button btn_shop_change;
        private System.Windows.Forms.TextBox txt_shop_new_pass_r;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_shop_new_pass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_shop_old_pass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Shop_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
    }
}