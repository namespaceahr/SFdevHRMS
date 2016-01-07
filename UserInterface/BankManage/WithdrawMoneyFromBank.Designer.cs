namespace UserInterface.BankManage
{
    partial class WithdrawMoneyFromBank
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
            this.withdrawbankidcombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.totalbankmoneytext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.withdrawmoneytext = new System.Windows.Forms.TextBox();
            this.addnewbanksave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bank ID";
            // 
            // withdrawbankidcombobox
            // 
            this.withdrawbankidcombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawbankidcombobox.FormattingEnabled = true;
            this.withdrawbankidcombobox.Location = new System.Drawing.Point(217, 38);
            this.withdrawbankidcombobox.Name = "withdrawbankidcombobox";
            this.withdrawbankidcombobox.Size = new System.Drawing.Size(305, 33);
            this.withdrawbankidcombobox.TabIndex = 4;
            this.withdrawbankidcombobox.SelectedValueChanged += new System.EventHandler(this.withdrawbankidcombobox_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bank Balance";
            // 
            // totalbankmoneytext
            // 
            this.totalbankmoneytext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalbankmoneytext.Location = new System.Drawing.Point(217, 101);
            this.totalbankmoneytext.Name = "totalbankmoneytext";
            this.totalbankmoneytext.Size = new System.Drawing.Size(305, 31);
            this.totalbankmoneytext.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "WithDraw Amount";
            // 
            // withdrawmoneytext
            // 
            this.withdrawmoneytext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawmoneytext.Location = new System.Drawing.Point(217, 151);
            this.withdrawmoneytext.Name = "withdrawmoneytext";
            this.withdrawmoneytext.Size = new System.Drawing.Size(305, 31);
            this.withdrawmoneytext.TabIndex = 8;
            // 
            // addnewbanksave
            // 
            this.addnewbanksave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnewbanksave.Location = new System.Drawing.Point(217, 214);
            this.addnewbanksave.Name = "addnewbanksave";
            this.addnewbanksave.Size = new System.Drawing.Size(124, 35);
            this.addnewbanksave.TabIndex = 9;
            this.addnewbanksave.Text = "Withdraw";
            this.addnewbanksave.UseVisualStyleBackColor = true;
            this.addnewbanksave.Click += new System.EventHandler(this.addnewbanksave_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(398, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WithdrawMoneyFromBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addnewbanksave);
            this.Controls.Add(this.withdrawmoneytext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalbankmoneytext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.withdrawbankidcombobox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WithdrawMoneyFromBank";
            this.Text = "Withdraw Money From Bank";
            this.Load += new System.EventHandler(this.WithdrawMoneyFromBank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox withdrawbankidcombobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalbankmoneytext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox withdrawmoneytext;
        private System.Windows.Forms.Button addnewbanksave;
        private System.Windows.Forms.Button button1;
    }
}