namespace UserInterface.PayrollManage
{
    partial class DeleteASalaryBonus
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
            this.payrolldeleteemployeeidcomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.payrolldeletedepartmentidcomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.payrolldelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // payrolldeleteemployeeidcomboBox
            // 
            this.payrolldeleteemployeeidcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payrolldeleteemployeeidcomboBox.FormattingEnabled = true;
            this.payrolldeleteemployeeidcomboBox.Location = new System.Drawing.Point(254, 63);
            this.payrolldeleteemployeeidcomboBox.Name = "payrolldeleteemployeeidcomboBox";
            this.payrolldeleteemployeeidcomboBox.Size = new System.Drawing.Size(157, 33);
            this.payrolldeleteemployeeidcomboBox.TabIndex = 6;
            this.payrolldeleteemployeeidcomboBox.SelectedValueChanged += new System.EventHandler(this.payrolldeleteemployeeidcomboBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Employee ID";
            // 
            // payrolldeletedepartmentidcomboBox
            // 
            this.payrolldeletedepartmentidcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payrolldeletedepartmentidcomboBox.FormattingEnabled = true;
            this.payrolldeletedepartmentidcomboBox.Location = new System.Drawing.Point(254, 132);
            this.payrolldeletedepartmentidcomboBox.Name = "payrolldeletedepartmentidcomboBox";
            this.payrolldeletedepartmentidcomboBox.Size = new System.Drawing.Size(157, 33);
            this.payrolldeletedepartmentidcomboBox.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Department ID For Payroll";
            // 
            // payrolldelete
            // 
            this.payrolldelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payrolldelete.Location = new System.Drawing.Point(300, 201);
            this.payrolldelete.Name = "payrolldelete";
            this.payrolldelete.Size = new System.Drawing.Size(97, 34);
            this.payrolldelete.TabIndex = 23;
            this.payrolldelete.Text = "Delete";
            this.payrolldelete.UseVisualStyleBackColor = true;
            this.payrolldelete.Click += new System.EventHandler(this.payrolldelete_Click);
            // 
            // DeleteASalaryBonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 261);
            this.Controls.Add(this.payrolldelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.payrolldeletedepartmentidcomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.payrolldeleteemployeeidcomboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DeleteASalaryBonus";
            this.Text = "Delete A Salary Bonus";
            this.Load += new System.EventHandler(this.DeleteASalaryBonus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox payrolldeleteemployeeidcomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox payrolldeletedepartmentidcomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button payrolldelete;
    }
}