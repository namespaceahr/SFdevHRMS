namespace UserInterface
{
    partial class AddNewAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.admininsertid = new System.Windows.Forms.TextBox();
            this.admininsertname = new System.Windows.Forms.TextBox();
            this.admininsertpassword = new System.Windows.Forms.TextBox();
            this.insertadmin = new System.Windows.Forms.Button();
            this.admininsertclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Admin Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Admin Password";
            // 
            // admininsertid
            // 
            this.admininsertid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admininsertid.Location = new System.Drawing.Point(294, 63);
            this.admininsertid.Name = "admininsertid";
            this.admininsertid.Size = new System.Drawing.Size(161, 29);
            this.admininsertid.TabIndex = 3;
            // 
            // admininsertname
            // 
            this.admininsertname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admininsertname.Location = new System.Drawing.Point(294, 131);
            this.admininsertname.Name = "admininsertname";
            this.admininsertname.Size = new System.Drawing.Size(161, 29);
            this.admininsertname.TabIndex = 4;
            // 
            // admininsertpassword
            // 
            this.admininsertpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admininsertpassword.Location = new System.Drawing.Point(294, 193);
            this.admininsertpassword.Name = "admininsertpassword";
            this.admininsertpassword.Size = new System.Drawing.Size(161, 29);
            this.admininsertpassword.TabIndex = 5;
            // 
            // insertadmin
            // 
            this.insertadmin.Location = new System.Drawing.Point(294, 249);
            this.insertadmin.Name = "insertadmin";
            this.insertadmin.Size = new System.Drawing.Size(104, 40);
            this.insertadmin.TabIndex = 6;
            this.insertadmin.Text = "Save";
            this.insertadmin.UseVisualStyleBackColor = true;
            // 
            // admininsertclear
            // 
            this.admininsertclear.Location = new System.Drawing.Point(501, 249);
            this.admininsertclear.Name = "admininsertclear";
            this.admininsertclear.Size = new System.Drawing.Size(105, 40);
            this.admininsertclear.TabIndex = 7;
            this.admininsertclear.Text = "Clear ";
            this.admininsertclear.UseVisualStyleBackColor = true;
            this.admininsertclear.Click += new System.EventHandler(this.admininsertclear_Click);
            // 
            // AddNewAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(697, 301);
            this.Controls.Add(this.admininsertclear);
            this.Controls.Add(this.insertadmin);
            this.Controls.Add(this.admininsertpassword);
            this.Controls.Add(this.admininsertname);
            this.Controls.Add(this.admininsertid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewAdmin";
            this.Text = "AddNewAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox admininsertid;
        private System.Windows.Forms.TextBox admininsertname;
        private System.Windows.Forms.TextBox admininsertpassword;
        private System.Windows.Forms.Button insertadmin;
        private System.Windows.Forms.Button admininsertclear;
    }
}