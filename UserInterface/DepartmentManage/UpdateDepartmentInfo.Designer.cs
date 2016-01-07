namespace UserInterface.DepartmentManage
{
    partial class UpdateDepartmentInfo
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
            this.label2 = new System.Windows.Forms.Label();
            this.updatedepartmentnametext = new System.Windows.Forms.TextBox();
            this.updatedepartmentidcomboBox = new System.Windows.Forms.ComboBox();
            this.updatedepartmentsave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Department ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Department Name";
            // 
            // updatedepartmentnametext
            // 
            this.updatedepartmentnametext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedepartmentnametext.Location = new System.Drawing.Point(219, 124);
            this.updatedepartmentnametext.Name = "updatedepartmentnametext";
            this.updatedepartmentnametext.Size = new System.Drawing.Size(177, 31);
            this.updatedepartmentnametext.TabIndex = 4;
            // 
            // updatedepartmentidcomboBox
            // 
            this.updatedepartmentidcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedepartmentidcomboBox.FormattingEnabled = true;
            this.updatedepartmentidcomboBox.Location = new System.Drawing.Point(219, 74);
            this.updatedepartmentidcomboBox.Name = "updatedepartmentidcomboBox";
            this.updatedepartmentidcomboBox.Size = new System.Drawing.Size(177, 33);
            this.updatedepartmentidcomboBox.TabIndex = 5;
            this.updatedepartmentidcomboBox.SelectedValueChanged += new System.EventHandler(this.updatedepartmentidcomboBox_SelectedValueChanged);
            // 
            // updatedepartmentsave
            // 
            this.updatedepartmentsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedepartmentsave.Location = new System.Drawing.Point(236, 201);
            this.updatedepartmentsave.Name = "updatedepartmentsave";
            this.updatedepartmentsave.Size = new System.Drawing.Size(75, 36);
            this.updatedepartmentsave.TabIndex = 6;
            this.updatedepartmentsave.Text = "Save";
            this.updatedepartmentsave.UseVisualStyleBackColor = true;
            this.updatedepartmentsave.Click += new System.EventHandler(this.updatedepartmentsave_Click);
            // 
            // UpdateDepartmentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 261);
            this.Controls.Add(this.updatedepartmentsave);
            this.Controls.Add(this.updatedepartmentidcomboBox);
            this.Controls.Add(this.updatedepartmentnametext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateDepartmentInfo";
            this.Text = "Update Department Info";
            this.Load += new System.EventHandler(this.UpdateDepartmentInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox updatedepartmentnametext;
        private System.Windows.Forms.ComboBox updatedepartmentidcomboBox;
        private System.Windows.Forms.Button updatedepartmentsave;
    }
}