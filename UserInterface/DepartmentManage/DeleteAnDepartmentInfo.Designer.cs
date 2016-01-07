namespace UserInterface.DepartmentManage
{
    partial class DeleteAnDepartmentInfo
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
            this.deletedepartmentidcomboBox = new System.Windows.Forms.ComboBox();
            this.deletedepartmentsave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Department ID";
            // 
            // deletedepartmentidcomboBox
            // 
            this.deletedepartmentidcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletedepartmentidcomboBox.FormattingEnabled = true;
            this.deletedepartmentidcomboBox.Location = new System.Drawing.Point(228, 117);
            this.deletedepartmentidcomboBox.Name = "deletedepartmentidcomboBox";
            this.deletedepartmentidcomboBox.Size = new System.Drawing.Size(177, 33);
            this.deletedepartmentidcomboBox.TabIndex = 6;
            // 
            // deletedepartmentsave
            // 
            this.deletedepartmentsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletedepartmentsave.Location = new System.Drawing.Point(266, 220);
            this.deletedepartmentsave.Name = "deletedepartmentsave";
            this.deletedepartmentsave.Size = new System.Drawing.Size(102, 36);
            this.deletedepartmentsave.TabIndex = 7;
            this.deletedepartmentsave.Text = "Delete";
            this.deletedepartmentsave.UseVisualStyleBackColor = true;
            this.deletedepartmentsave.Click += new System.EventHandler(this.deletedepartmentsave_Click);
            // 
            // DeleteAnDepartmentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 286);
            this.Controls.Add(this.deletedepartmentsave);
            this.Controls.Add(this.deletedepartmentidcomboBox);
            this.Controls.Add(this.label1);
            this.Name = "DeleteAnDepartmentInfo";
            this.Text = "Delete An DepartmentInfo";
            this.Load += new System.EventHandler(this.DeleteAnDepartmentInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox deletedepartmentidcomboBox;
        private System.Windows.Forms.Button deletedepartmentsave;
    }
}