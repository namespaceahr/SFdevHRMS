namespace UserInterface.JobAssign
{
    partial class DeleteAnAssignJob
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
            this.deleteanassignjobidcomboBox = new System.Windows.Forms.ComboBox();
            this.deleteanassignjobdelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job Id To Delete";
            // 
            // deleteanassignjobidcomboBox
            // 
            this.deleteanassignjobidcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteanassignjobidcomboBox.FormattingEnabled = true;
            this.deleteanassignjobidcomboBox.Location = new System.Drawing.Point(210, 93);
            this.deleteanassignjobidcomboBox.Name = "deleteanassignjobidcomboBox";
            this.deleteanassignjobidcomboBox.Size = new System.Drawing.Size(154, 33);
            this.deleteanassignjobidcomboBox.TabIndex = 1;
            // 
            // deleteanassignjobdelete
            // 
            this.deleteanassignjobdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteanassignjobdelete.Location = new System.Drawing.Point(238, 188);
            this.deleteanassignjobdelete.Name = "deleteanassignjobdelete";
            this.deleteanassignjobdelete.Size = new System.Drawing.Size(126, 38);
            this.deleteanassignjobdelete.TabIndex = 2;
            this.deleteanassignjobdelete.Text = "Delete";
            this.deleteanassignjobdelete.UseVisualStyleBackColor = true;
            this.deleteanassignjobdelete.Click += new System.EventHandler(this.deleteanassignjobdelete_Click);
            // 
            // DeleteAnAssignJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 261);
            this.Controls.Add(this.deleteanassignjobdelete);
            this.Controls.Add(this.deleteanassignjobidcomboBox);
            this.Controls.Add(this.label1);
            this.Name = "DeleteAnAssignJob";
            this.Text = "DeleteAnAssignJob";
            this.Load += new System.EventHandler(this.DeleteAnAssignJob_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox deleteanassignjobidcomboBox;
        private System.Windows.Forms.Button deleteanassignjobdelete;
    }
}