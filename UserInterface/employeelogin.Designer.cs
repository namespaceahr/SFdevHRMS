namespace UserInterface
{
    partial class employeelogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employeelogin));
            this.ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeid = new System.Windows.Forms.TextBox();
            this.employeepassword = new System.Windows.Forms.TextBox();
            this.employeeloginbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(151, 34);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(27, 24);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // employeeid
            // 
            this.employeeid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeid.Location = new System.Drawing.Point(236, 34);
            this.employeeid.Name = "employeeid";
            this.employeeid.Size = new System.Drawing.Size(123, 29);
            this.employeeid.TabIndex = 2;
            // 
            // employeepassword
            // 
            this.employeepassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeepassword.Location = new System.Drawing.Point(236, 106);
            this.employeepassword.Name = "employeepassword";
            this.employeepassword.Size = new System.Drawing.Size(123, 29);
            this.employeepassword.TabIndex = 3;
            this.employeepassword.TextChanged += new System.EventHandler(this.employeepassword_TextChanged);
            // 
            // employeeloginbutton
            // 
            this.employeeloginbutton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.employeeloginbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeloginbutton.Location = new System.Drawing.Point(246, 160);
            this.employeeloginbutton.Name = "employeeloginbutton";
            this.employeeloginbutton.Size = new System.Drawing.Size(98, 38);
            this.employeeloginbutton.TabIndex = 4;
            this.employeeloginbutton.Text = "Login";
            this.employeeloginbutton.UseVisualStyleBackColor = false;
            this.employeeloginbutton.Click += new System.EventHandler(this.employeeloginbutton_Click);
            // 
            // employeelogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.employeeloginbutton);
            this.Controls.Add(this.employeepassword);
            this.Controls.Add(this.employeeid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID);
            this.Name = "employeelogin";
            this.Size = new System.Drawing.Size(445, 229);
          this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox employeeid;
        private System.Windows.Forms.TextBox employeepassword;
        private System.Windows.Forms.Button employeeloginbutton;
    }
}
