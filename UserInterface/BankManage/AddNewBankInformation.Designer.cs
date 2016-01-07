namespace UserInterface.BankManage
{
    partial class AddNewBankInformation
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
            this.addbankidtext = new System.Windows.Forms.TextBox();
            this.addbankmoneytext = new System.Windows.Forms.TextBox();
            this.addnewbanksave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bank ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bank Money";
            // 
            // addbankidtext
            // 
            this.addbankidtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbankidtext.Location = new System.Drawing.Point(239, 58);
            this.addbankidtext.Name = "addbankidtext";
            this.addbankidtext.Size = new System.Drawing.Size(254, 31);
            this.addbankidtext.TabIndex = 2;
            // 
            // addbankmoneytext
            // 
            this.addbankmoneytext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbankmoneytext.Location = new System.Drawing.Point(239, 108);
            this.addbankmoneytext.Name = "addbankmoneytext";
            this.addbankmoneytext.Size = new System.Drawing.Size(254, 31);
            this.addbankmoneytext.TabIndex = 3;
            // 
            // addnewbanksave
            // 
            this.addnewbanksave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnewbanksave.Location = new System.Drawing.Point(239, 191);
            this.addnewbanksave.Name = "addnewbanksave";
            this.addnewbanksave.Size = new System.Drawing.Size(89, 35);
            this.addnewbanksave.TabIndex = 4;
            this.addnewbanksave.Text = "Save";
            this.addnewbanksave.UseVisualStyleBackColor = true;
            this.addnewbanksave.Click += new System.EventHandler(this.addnewbanksave_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(392, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNewBankInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addnewbanksave);
            this.Controls.Add(this.addbankmoneytext);
            this.Controls.Add(this.addbankidtext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddNewBankInformation";
            this.Text = "Add New Bank Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addbankidtext;
        private System.Windows.Forms.TextBox addbankmoneytext;
        private System.Windows.Forms.Button addnewbanksave;
        private System.Windows.Forms.Button button1;
    }
}