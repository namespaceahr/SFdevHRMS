namespace UserInterface.EmployeeManage
{
    partial class DeleteAnEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.deleteadmin = new System.Windows.Forms.Button();
            this.deleteemployeeidcomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Id To Delete";
            // 
            // deleteadmin
            // 
            this.deleteadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteadmin.Location = new System.Drawing.Point(227, 199);
            this.deleteadmin.Name = "deleteadmin";
            this.deleteadmin.Size = new System.Drawing.Size(131, 40);
            this.deleteadmin.TabIndex = 2;
            this.deleteadmin.Text = "Delete";
            this.deleteadmin.UseVisualStyleBackColor = true;
            this.deleteadmin.Click += new System.EventHandler(this.deleteadmin_Click);
            // 
            // deleteemployeeidcomboBox
            // 
            this.deleteemployeeidcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteemployeeidcomboBox.FormattingEnabled = true;
            this.deleteemployeeidcomboBox.Location = new System.Drawing.Point(214, 102);
            this.deleteemployeeidcomboBox.Name = "deleteemployeeidcomboBox";
            this.deleteemployeeidcomboBox.Size = new System.Drawing.Size(157, 33);
            this.deleteemployeeidcomboBox.TabIndex = 3;
             // 
            // DeleteAnEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 261);
            this.Controls.Add(this.deleteemployeeidcomboBox);
            this.Controls.Add(this.deleteadmin);
            this.Controls.Add(this.label1);
            this.Name = "DeleteAnEmployee";
            this.Text = "DeleteAnEmployee";
            this.Load += new System.EventHandler(this.DeleteAnEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteadmin;
        private System.Windows.Forms.ComboBox deleteemployeeidcomboBox;
    }
}