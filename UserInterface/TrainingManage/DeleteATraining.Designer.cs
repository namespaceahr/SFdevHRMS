namespace UserInterface.TrainingManage
{
    partial class DeleteATraining
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
            this.deletetrainingidcomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trainingdelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deletetrainingidcomboBox
            // 
            this.deletetrainingidcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletetrainingidcomboBox.FormattingEnabled = true;
            this.deletetrainingidcomboBox.Location = new System.Drawing.Point(185, 87);
            this.deletetrainingidcomboBox.Name = "deletetrainingidcomboBox";
            this.deletetrainingidcomboBox.Size = new System.Drawing.Size(160, 33);
            this.deletetrainingidcomboBox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Training ID";
            // 
            // trainingdelete
            // 
            this.trainingdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainingdelete.Location = new System.Drawing.Point(206, 188);
            this.trainingdelete.Name = "trainingdelete";
            this.trainingdelete.Size = new System.Drawing.Size(108, 34);
            this.trainingdelete.TabIndex = 22;
            this.trainingdelete.Text = "Delete";
            this.trainingdelete.UseVisualStyleBackColor = true;
            this.trainingdelete.Click += new System.EventHandler(this.trainingdelete_Click);
            // 
            // DeleteATraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 261);
            this.Controls.Add(this.trainingdelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deletetrainingidcomboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DeleteATraining";
            this.Text = "Delete A Training";
            this.Load += new System.EventHandler(this.DeleteATraining_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox deletetrainingidcomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button trainingdelete;
    }
}