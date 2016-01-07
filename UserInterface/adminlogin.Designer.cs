namespace UserInterface
{
    partial class adminlogin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminlogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adminid = new System.Windows.Forms.TextBox();
            this.adminpassword = new System.Windows.Forms.TextBox();
            this.adminloginbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // adminid
            // 
            this.adminid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminid.Location = new System.Drawing.Point(235, 19);
            this.adminid.Name = "adminid";
            this.adminid.Size = new System.Drawing.Size(131, 29);
            this.adminid.TabIndex = 2;
            this.adminid.TextChanged += new System.EventHandler(this.adminid_TextChanged);
            // 
            // adminpassword
            // 
            this.adminpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminpassword.Location = new System.Drawing.Point(235, 67);
            this.adminpassword.Name = "adminpassword";
            this.adminpassword.Size = new System.Drawing.Size(131, 29);
            this.adminpassword.TabIndex = 3;
            this.adminpassword.TextChanged += new System.EventHandler(this.adminpassword_TextChanged);
            // 
            // adminloginbutton
            // 
            this.adminloginbutton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.adminloginbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminloginbutton.Location = new System.Drawing.Point(269, 142);
            this.adminloginbutton.Name = "adminloginbutton";
            this.adminloginbutton.Size = new System.Drawing.Size(75, 37);
            this.adminloginbutton.TabIndex = 4;
            this.adminloginbutton.Text = "Login";
            this.adminloginbutton.UseVisualStyleBackColor = false;
            this.adminloginbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.adminloginbutton);
            this.Controls.Add(this.adminpassword);
            this.Controls.Add(this.adminid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "adminlogin";
            this.Size = new System.Drawing.Size(445, 229);
     
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adminid;
        private System.Windows.Forms.TextBox adminpassword;
        private System.Windows.Forms.Button adminloginbutton;
    }
}
