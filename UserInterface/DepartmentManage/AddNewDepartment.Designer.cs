namespace UserInterface.DepartmentManage
{
    partial class AddNewDepartment
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
            this.addnewdepartmentidtext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addnewdepartmentnametext = new System.Windows.Forms.TextBox();
            this.addnewdepartmentsave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department ID";
            // 
            // addnewdepartmentidtext
            // 
            this.addnewdepartmentidtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnewdepartmentidtext.Location = new System.Drawing.Point(273, 65);
            this.addnewdepartmentidtext.Name = "addnewdepartmentidtext";
            this.addnewdepartmentidtext.Size = new System.Drawing.Size(177, 31);
            this.addnewdepartmentidtext.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Department Name";
            // 
            // addnewdepartmentnametext
            // 
            this.addnewdepartmentnametext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnewdepartmentnametext.Location = new System.Drawing.Point(273, 130);
            this.addnewdepartmentnametext.Name = "addnewdepartmentnametext";
            this.addnewdepartmentnametext.Size = new System.Drawing.Size(177, 31);
            this.addnewdepartmentnametext.TabIndex = 3;
            // 
            // addnewdepartmentsave
            // 
            this.addnewdepartmentsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnewdepartmentsave.Location = new System.Drawing.Point(273, 222);
            this.addnewdepartmentsave.Name = "addnewdepartmentsave";
            this.addnewdepartmentsave.Size = new System.Drawing.Size(75, 36);
            this.addnewdepartmentsave.TabIndex = 4;
            this.addnewdepartmentsave.Text = "Save";
            this.addnewdepartmentsave.UseVisualStyleBackColor = true;
            this.addnewdepartmentsave.Click += new System.EventHandler(this.addnewdepartmentsave_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(416, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNewDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 287);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addnewdepartmentsave);
            this.Controls.Add(this.addnewdepartmentnametext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addnewdepartmentidtext);
            this.Controls.Add(this.label1);
            this.Name = "AddNewDepartment";
            this.Text = "Add New Department";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addnewdepartmentidtext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addnewdepartmentnametext;
        private System.Windows.Forms.Button addnewdepartmentsave;
        private System.Windows.Forms.Button button1;
    }
}