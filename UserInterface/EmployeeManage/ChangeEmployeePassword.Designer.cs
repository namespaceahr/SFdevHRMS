namespace UserInterface.EmployeeManage
{
    partial class ChangeEmployeePassword
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
            this.label3 = new System.Windows.Forms.Label();
            this.changeemployeepasswordtext = new System.Windows.Forms.TextBox();
            this.passwordemployeesave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Employee Password";
            // 
            // changeemployeepasswordtext
            // 
            this.changeemployeepasswordtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeemployeepasswordtext.Location = new System.Drawing.Point(266, 96);
            this.changeemployeepasswordtext.Name = "changeemployeepasswordtext";
            this.changeemployeepasswordtext.Size = new System.Drawing.Size(157, 31);
            this.changeemployeepasswordtext.TabIndex = 11;
            // 
            // passwordemployeesave
            // 
            this.passwordemployeesave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordemployeesave.Location = new System.Drawing.Point(308, 174);
            this.passwordemployeesave.Name = "passwordemployeesave";
            this.passwordemployeesave.Size = new System.Drawing.Size(75, 34);
            this.passwordemployeesave.TabIndex = 17;
            this.passwordemployeesave.Text = "Save";
            this.passwordemployeesave.UseVisualStyleBackColor = true;
            this.passwordemployeesave.Click += new System.EventHandler(this.passwordemployeesave_Click);
            // 
            // ChangeEmployeePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 238);
            this.Controls.Add(this.passwordemployeesave);
            this.Controls.Add(this.changeemployeepasswordtext);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChangeEmployeePassword";
            this.Text = "Change Your Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox changeemployeepasswordtext;
        private System.Windows.Forms.Button passwordemployeesave;
    }
}