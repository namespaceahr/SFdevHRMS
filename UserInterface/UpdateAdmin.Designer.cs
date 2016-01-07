namespace UserInterface
{
    partial class UpdateAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateAdmin));
            this.updateadminid = new System.Windows.Forms.Label();
            this.updateadminname = new System.Windows.Forms.Label();
            this.updateadminpassword = new System.Windows.Forms.Label();
            this.updateadminidtextbox = new System.Windows.Forms.TextBox();
            this.updateadminnametextbox = new System.Windows.Forms.TextBox();
            this.updateadminpasswordtextbox = new System.Windows.Forms.TextBox();
            this.updateadminsave = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // updateadminid
            // 
            this.updateadminid.AutoSize = true;
            this.updateadminid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateadminid.Location = new System.Drawing.Point(167, 61);
            this.updateadminid.Name = "updateadminid";
            this.updateadminid.Size = new System.Drawing.Size(98, 25);
            this.updateadminid.TabIndex = 0;
            this.updateadminid.Text = "Admin ID";
            // 
            // updateadminname
            // 
            this.updateadminname.AutoSize = true;
            this.updateadminname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateadminname.Location = new System.Drawing.Point(131, 125);
            this.updateadminname.Name = "updateadminname";
            this.updateadminname.Size = new System.Drawing.Size(134, 25);
            this.updateadminname.TabIndex = 1;
            this.updateadminname.Text = "Admin Name";
            // 
            // updateadminpassword
            // 
            this.updateadminpassword.AutoSize = true;
            this.updateadminpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateadminpassword.Location = new System.Drawing.Point(93, 191);
            this.updateadminpassword.Name = "updateadminpassword";
            this.updateadminpassword.Size = new System.Drawing.Size(172, 25);
            this.updateadminpassword.TabIndex = 2;
            this.updateadminpassword.Text = "Admin Password";
            // 
            // updateadminidtextbox
            // 
            this.updateadminidtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateadminidtextbox.Location = new System.Drawing.Point(370, 61);
            this.updateadminidtextbox.Name = "updateadminidtextbox";
            this.updateadminidtextbox.Size = new System.Drawing.Size(138, 31);
            this.updateadminidtextbox.TabIndex = 3;
            // 
            // updateadminnametextbox
            // 
            this.updateadminnametextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateadminnametextbox.Location = new System.Drawing.Point(370, 125);
            this.updateadminnametextbox.Name = "updateadminnametextbox";
            this.updateadminnametextbox.Size = new System.Drawing.Size(138, 31);
            this.updateadminnametextbox.TabIndex = 4;
            // 
            // updateadminpasswordtextbox
            // 
            this.updateadminpasswordtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateadminpasswordtextbox.Location = new System.Drawing.Point(370, 185);
            this.updateadminpasswordtextbox.Name = "updateadminpasswordtextbox";
            this.updateadminpasswordtextbox.Size = new System.Drawing.Size(138, 31);
            this.updateadminpasswordtextbox.TabIndex = 5;
            // 
            // updateadminsave
            // 
            this.updateadminsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateadminsave.Location = new System.Drawing.Point(370, 261);
            this.updateadminsave.Name = "updateadminsave";
            this.updateadminsave.Size = new System.Drawing.Size(106, 34);
            this.updateadminsave.TabIndex = 6;
            this.updateadminsave.Text = "Update";
            this.updateadminsave.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(558, 261);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(113, 34);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // UpdateAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 307);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.updateadminsave);
            this.Controls.Add(this.updateadminpasswordtextbox);
            this.Controls.Add(this.updateadminnametextbox);
            this.Controls.Add(this.updateadminidtextbox);
            this.Controls.Add(this.updateadminpassword);
            this.Controls.Add(this.updateadminname);
            this.Controls.Add(this.updateadminid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateAdmin";
            this.Text = "UpdateAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label updateadminid;
        private System.Windows.Forms.Label updateadminname;
        private System.Windows.Forms.Label updateadminpassword;
        private System.Windows.Forms.TextBox updateadminidtextbox;
        private System.Windows.Forms.TextBox updateadminnametextbox;
        private System.Windows.Forms.TextBox updateadminpasswordtextbox;
        private System.Windows.Forms.Button updateadminsave;
        private System.Windows.Forms.Button Clear;
    }
}