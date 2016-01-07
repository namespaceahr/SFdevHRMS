namespace UserInterface
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.leftlogo = new System.Windows.Forms.Panel();
            this.LoginBox = new System.Windows.Forms.Panel();
            this.adminloginboxbutton = new System.Windows.Forms.Button();
            this.employeloginboxbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // leftlogo
            // 
            this.leftlogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leftlogo.BackgroundImage")));
            this.leftlogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftlogo.Location = new System.Drawing.Point(12, 12);
            this.leftlogo.Name = "leftlogo";
            this.leftlogo.Size = new System.Drawing.Size(121, 100);
            this.leftlogo.TabIndex = 0;
            this.leftlogo.Visible = false;
            // 
            // LoginBox
            // 
            this.LoginBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginBox.BackgroundImage")));
            this.LoginBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LoginBox.Location = new System.Drawing.Point(194, 29);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(445, 229);
            this.LoginBox.TabIndex = 1;
            // 
            // adminloginboxbutton
            // 
            this.adminloginboxbutton.Location = new System.Drawing.Point(258, 277);
            this.adminloginboxbutton.Name = "adminloginboxbutton";
            this.adminloginboxbutton.Size = new System.Drawing.Size(88, 23);
            this.adminloginboxbutton.TabIndex = 2;
            this.adminloginboxbutton.Text = "Admin Login";
            this.adminloginboxbutton.UseVisualStyleBackColor = true;
            this.adminloginboxbutton.Click += new System.EventHandler(this.adminloginbox_Click);
            // 
            // employeloginboxbutton
            // 
            this.employeloginboxbutton.Location = new System.Drawing.Point(489, 277);
            this.employeloginboxbutton.Name = "employeloginboxbutton";
            this.employeloginboxbutton.Size = new System.Drawing.Size(96, 23);
            this.employeloginboxbutton.TabIndex = 3;
            this.employeloginboxbutton.Text = "Employee Login";
            this.employeloginboxbutton.UseVisualStyleBackColor = true;
            this.employeloginboxbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(672, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Build Version 1.0.0.0";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 312);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeloginboxbutton);
            this.Controls.Add(this.adminloginboxbutton);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.leftlogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SFdev HRMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel leftlogo;
        private System.Windows.Forms.Panel LoginBox;
        private System.Windows.Forms.Button adminloginboxbutton;
        private System.Windows.Forms.Button employeloginboxbutton;
        private System.Windows.Forms.Label label1;
    }
}

