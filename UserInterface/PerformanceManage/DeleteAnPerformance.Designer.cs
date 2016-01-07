namespace UserInterface.PerformanceManage
{
    partial class DeleteAnPerformance
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
            this.deleteevaluateemployeeidcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteevaluateperformanceidcomboBox = new System.Windows.Forms.ComboBox();
            this.deleteevaluateperformancesave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee ID";
            // 
            // deleteevaluateemployeeidcomboBox
            // 
            this.deleteevaluateemployeeidcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteevaluateemployeeidcomboBox.FormattingEnabled = true;
            this.deleteevaluateemployeeidcomboBox.Location = new System.Drawing.Point(180, 45);
            this.deleteevaluateemployeeidcomboBox.Name = "deleteevaluateemployeeidcomboBox";
            this.deleteevaluateemployeeidcomboBox.Size = new System.Drawing.Size(149, 33);
            this.deleteevaluateemployeeidcomboBox.TabIndex = 6;
            this.deleteevaluateemployeeidcomboBox.SelectedValueChanged += new System.EventHandler(this.deleteevaluateemployeeidcomboBox_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Performance ID";
            // 
            // deleteevaluateperformanceidcomboBox
            // 
            this.deleteevaluateperformanceidcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteevaluateperformanceidcomboBox.FormattingEnabled = true;
            this.deleteevaluateperformanceidcomboBox.Location = new System.Drawing.Point(180, 107);
            this.deleteevaluateperformanceidcomboBox.Name = "deleteevaluateperformanceidcomboBox";
            this.deleteevaluateperformanceidcomboBox.Size = new System.Drawing.Size(149, 33);
            this.deleteevaluateperformanceidcomboBox.TabIndex = 8;
            // 
            // deleteevaluateperformancesave
            // 
            this.deleteevaluateperformancesave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteevaluateperformancesave.Location = new System.Drawing.Point(180, 179);
            this.deleteevaluateperformancesave.Name = "deleteevaluateperformancesave";
            this.deleteevaluateperformancesave.Size = new System.Drawing.Size(92, 48);
            this.deleteevaluateperformancesave.TabIndex = 15;
            this.deleteevaluateperformancesave.Text = "Delete";
            this.deleteevaluateperformancesave.UseVisualStyleBackColor = true;
            this.deleteevaluateperformancesave.Click += new System.EventHandler(this.deleteevaluateperformancesave_Click);
            // 
            // DeleteAnPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 261);
            this.Controls.Add(this.deleteevaluateperformancesave);
            this.Controls.Add(this.deleteevaluateperformanceidcomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteevaluateemployeeidcomboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DeleteAnPerformance";
            this.Text = "Delete An Performance";
            this.Load += new System.EventHandler(this.DeleteAnPerformance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox deleteevaluateemployeeidcomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox deleteevaluateperformanceidcomboBox;
        private System.Windows.Forms.Button deleteevaluateperformancesave;
    }
}