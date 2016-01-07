namespace UserInterface.EmployeeJobInformation
{
    partial class AddNewOrUpdateJobStatus
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
            this.label2 = new System.Windows.Forms.Label();
            this.jobstatusjobidcomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.jobstatustext = new System.Windows.Forms.TextBox();
            this.jobstatussave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Job ID";
            // 
            // jobstatusjobidcomboBox
            // 
            this.jobstatusjobidcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobstatusjobidcomboBox.FormattingEnabled = true;
            this.jobstatusjobidcomboBox.Location = new System.Drawing.Point(230, 49);
            this.jobstatusjobidcomboBox.Name = "jobstatusjobidcomboBox";
            this.jobstatusjobidcomboBox.Size = new System.Drawing.Size(187, 33);
            this.jobstatusjobidcomboBox.TabIndex = 4;
            this.jobstatusjobidcomboBox.SelectedValueChanged += new System.EventHandler(this.jobstatusjobidcomboBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Job Status";
            // 
            // jobstatustext
            // 
            this.jobstatustext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobstatustext.Location = new System.Drawing.Point(230, 123);
            this.jobstatustext.Name = "jobstatustext";
            this.jobstatustext.Size = new System.Drawing.Size(187, 31);
            this.jobstatustext.TabIndex = 6;
            // 
            // jobstatussave
            // 
            this.jobstatussave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobstatussave.Location = new System.Drawing.Point(256, 193);
            this.jobstatussave.Name = "jobstatussave";
            this.jobstatussave.Size = new System.Drawing.Size(138, 35);
            this.jobstatussave.TabIndex = 28;
            this.jobstatussave.Text = "Save";
            this.jobstatussave.UseVisualStyleBackColor = true;
            this.jobstatussave.Click += new System.EventHandler(this.jobstatussave_Click);
            // 
            // AddNewOrUpdateJobStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 261);
            this.Controls.Add(this.jobstatussave);
            this.Controls.Add(this.jobstatustext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jobstatusjobidcomboBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddNewOrUpdateJobStatus";
            this.Text = "Add New Or Update Job Status";
            this.Load += new System.EventHandler(this.AddNewOrUpdateJobStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox jobstatusjobidcomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox jobstatustext;
        private System.Windows.Forms.Button jobstatussave;

    }
}