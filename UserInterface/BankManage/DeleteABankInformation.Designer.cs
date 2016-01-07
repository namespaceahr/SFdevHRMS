namespace UserInterface.BankManage
{
    partial class DeleteABankInformation
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
            this.deletebankidcombobox = new System.Windows.Forms.ComboBox();
            this.bankdelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bank ID";
            // 
            // deletebankidcombobox
            // 
            this.deletebankidcombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebankidcombobox.FormattingEnabled = true;
            this.deletebankidcombobox.Location = new System.Drawing.Point(130, 72);
            this.deletebankidcombobox.Name = "deletebankidcombobox";
            this.deletebankidcombobox.Size = new System.Drawing.Size(305, 33);
            this.deletebankidcombobox.TabIndex = 3;
            // 
            // bankdelete
            // 
            this.bankdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankdelete.Location = new System.Drawing.Point(216, 149);
            this.bankdelete.Name = "bankdelete";
            this.bankdelete.Size = new System.Drawing.Size(89, 35);
            this.bankdelete.TabIndex = 6;
            this.bankdelete.Text = "Delete";
            this.bankdelete.UseVisualStyleBackColor = true;
            this.bankdelete.Click += new System.EventHandler(this.bankdelete_Click);
            // 
            // DeleteABankInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 217);
            this.Controls.Add(this.bankdelete);
            this.Controls.Add(this.deletebankidcombobox);
            this.Controls.Add(this.label1);
            this.Name = "DeleteABankInformation";
            this.Text = "DeleteABankInformation";
            this.Load += new System.EventHandler(this.DeleteABankInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox deletebankidcombobox;
        private System.Windows.Forms.Button bankdelete;
    }
}