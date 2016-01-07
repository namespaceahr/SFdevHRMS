namespace UserInterface.TrainingManage
{
    partial class UpdateATrainingInformation
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
            this.label3 = new System.Windows.Forms.Label();
            this.updatetrainingtopictext = new System.Windows.Forms.TextBox();
            this.updatetrainingreviewtext = new System.Windows.Forms.TextBox();
            this.addtrainingsave = new System.Windows.Forms.Button();
            this.updatetrainingidcomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Training ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Training Topic";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Training Review";
            // 
            // updatetrainingtopictext
            // 
            this.updatetrainingtopictext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatetrainingtopictext.Location = new System.Drawing.Point(225, 93);
            this.updatetrainingtopictext.Name = "updatetrainingtopictext";
            this.updatetrainingtopictext.Size = new System.Drawing.Size(160, 29);
            this.updatetrainingtopictext.TabIndex = 7;
            // 
            // updatetrainingreviewtext
            // 
            this.updatetrainingreviewtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatetrainingreviewtext.Location = new System.Drawing.Point(225, 139);
            this.updatetrainingreviewtext.Name = "updatetrainingreviewtext";
            this.updatetrainingreviewtext.Size = new System.Drawing.Size(160, 29);
            this.updatetrainingreviewtext.TabIndex = 8;
            // 
            // addtrainingsave
            // 
            this.addtrainingsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtrainingsave.Location = new System.Drawing.Point(266, 205);
            this.addtrainingsave.Name = "addtrainingsave";
            this.addtrainingsave.Size = new System.Drawing.Size(75, 34);
            this.addtrainingsave.TabIndex = 18;
            this.addtrainingsave.Text = "Save";
            this.addtrainingsave.UseVisualStyleBackColor = true;
            this.addtrainingsave.Click += new System.EventHandler(this.addtrainingsave_Click);
            // 
            // updatetrainingidcomboBox
            // 
            this.updatetrainingidcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatetrainingidcomboBox.FormattingEnabled = true;
            this.updatetrainingidcomboBox.Location = new System.Drawing.Point(225, 39);
            this.updatetrainingidcomboBox.Name = "updatetrainingidcomboBox";
            this.updatetrainingidcomboBox.Size = new System.Drawing.Size(160, 33);
            this.updatetrainingidcomboBox.TabIndex = 19;
            this.updatetrainingidcomboBox.SelectedValueChanged += new System.EventHandler(this.updatetrainingidcomboBox_SelectedValueChanged);
            // 
            // UpdateATrainingInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 261);
            this.Controls.Add(this.updatetrainingidcomboBox);
            this.Controls.Add(this.addtrainingsave);
            this.Controls.Add(this.updatetrainingreviewtext);
            this.Controls.Add(this.updatetrainingtopictext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UpdateATrainingInformation";
            this.Text = "Update A Training Information";
            this.Load += new System.EventHandler(this.UpdateATrainingInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox updatetrainingtopictext;
        private System.Windows.Forms.TextBox updatetrainingreviewtext;
        private System.Windows.Forms.Button addtrainingsave;
        private System.Windows.Forms.ComboBox updatetrainingidcomboBox;
    }
}