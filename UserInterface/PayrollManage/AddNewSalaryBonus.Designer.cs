namespace UserInterface.PayrollManage
{
    partial class AddNewSalaryBonus
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
            this.payrolladdemployeeidcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.payrolladdsalaryamounttext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.payrolladdbonusamounttext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.payrolladdsave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.payrolladddepartmentidcomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee ID";
            // 
            // payrolladdemployeeidcomboBox
            // 
            this.payrolladdemployeeidcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payrolladdemployeeidcomboBox.FormattingEnabled = true;
            this.payrolladdemployeeidcomboBox.Location = new System.Drawing.Point(212, 39);
            this.payrolladdemployeeidcomboBox.Name = "payrolladdemployeeidcomboBox";
            this.payrolladdemployeeidcomboBox.Size = new System.Drawing.Size(157, 33);
            this.payrolladdemployeeidcomboBox.TabIndex = 4;
            this.payrolladdemployeeidcomboBox.SelectedValueChanged += new System.EventHandler(this.payrolladdemployeeidcomboBox_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Salary Amount ";
            // 
            // payrolladdsalaryamounttext
            // 
            this.payrolladdsalaryamounttext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payrolladdsalaryamounttext.Location = new System.Drawing.Point(212, 107);
            this.payrolladdsalaryamounttext.Name = "payrolladdsalaryamounttext";
            this.payrolladdsalaryamounttext.Size = new System.Drawing.Size(157, 31);
            this.payrolladdsalaryamounttext.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bonus Amount ";
            // 
            // payrolladdbonusamounttext
            // 
            this.payrolladdbonusamounttext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payrolladdbonusamounttext.Location = new System.Drawing.Point(212, 159);
            this.payrolladdbonusamounttext.Name = "payrolladdbonusamounttext";
            this.payrolladdbonusamounttext.Size = new System.Drawing.Size(157, 31);
            this.payrolladdbonusamounttext.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Department ID";
            // 
            // payrolladdsave
            // 
            this.payrolladdsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payrolladdsave.Location = new System.Drawing.Point(222, 278);
            this.payrolladdsave.Name = "payrolladdsave";
            this.payrolladdsave.Size = new System.Drawing.Size(75, 34);
            this.payrolladdsave.TabIndex = 17;
            this.payrolladdsave.Text = "Save";
            this.payrolladdsave.UseVisualStyleBackColor = true;
            this.payrolladdsave.Click += new System.EventHandler(this.payrolladdsave_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(354, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 18;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // payrolladddepartmentidcomboBox
            // 
            this.payrolladddepartmentidcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payrolladddepartmentidcomboBox.FormattingEnabled = true;
            this.payrolladddepartmentidcomboBox.Location = new System.Drawing.Point(212, 209);
            this.payrolladddepartmentidcomboBox.Name = "payrolladddepartmentidcomboBox";
            this.payrolladddepartmentidcomboBox.Size = new System.Drawing.Size(157, 33);
            this.payrolladddepartmentidcomboBox.TabIndex = 19;
            // 
            // AddNewSalaryBonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 324);
            this.Controls.Add(this.payrolladddepartmentidcomboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.payrolladdsave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.payrolladdbonusamounttext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.payrolladdsalaryamounttext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.payrolladdemployeeidcomboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddNewSalaryBonus";
            this.Text = "Add New Salary And Bonus";
            this.Load += new System.EventHandler(this.AddNewSalaryBonus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox payrolladdemployeeidcomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox payrolladdsalaryamounttext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox payrolladdbonusamounttext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button payrolladdsave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox payrolladddepartmentidcomboBox;
    }
}