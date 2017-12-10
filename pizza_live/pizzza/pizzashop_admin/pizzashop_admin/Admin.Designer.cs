namespace pizzashop_admin
{
    partial class Admin
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
            this.adbtn1 = new System.Windows.Forms.Button();
            this.adbtn2 = new System.Windows.Forms.Button();
            this.adbtn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adbtn1
            // 
            this.adbtn1.Location = new System.Drawing.Point(189, 34);
            this.adbtn1.Name = "adbtn1";
            this.adbtn1.Size = new System.Drawing.Size(101, 37);
            this.adbtn1.TabIndex = 0;
            this.adbtn1.Text = "REPORT";
            this.adbtn1.UseVisualStyleBackColor = true;
            this.adbtn1.Click += new System.EventHandler(this.adbtn1_Click);
            // 
            // adbtn2
            // 
            this.adbtn2.Location = new System.Drawing.Point(189, 116);
            this.adbtn2.Name = "adbtn2";
            this.adbtn2.Size = new System.Drawing.Size(101, 43);
            this.adbtn2.TabIndex = 1;
            this.adbtn2.Text = "ADD PRODUCT";
            this.adbtn2.UseVisualStyleBackColor = true;
            this.adbtn2.Click += new System.EventHandler(this.adbtn2_Click);
            // 
            // adbtn3
            // 
            this.adbtn3.Location = new System.Drawing.Point(189, 199);
            this.adbtn3.Name = "adbtn3";
            this.adbtn3.Size = new System.Drawing.Size(101, 37);
            this.adbtn3.TabIndex = 2;
            this.adbtn3.Text = "STOCK";
            this.adbtn3.UseVisualStyleBackColor = true;
            this.adbtn3.Click += new System.EventHandler(this.adbtn3_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 290);
            this.Controls.Add(this.adbtn3);
            this.Controls.Add(this.adbtn2);
            this.Controls.Add(this.adbtn1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adbtn1;
        private System.Windows.Forms.Button adbtn2;
        private System.Windows.Forms.Button adbtn3;
    }
}