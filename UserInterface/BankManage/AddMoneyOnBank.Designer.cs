namespace UserInterface.BankManage
{
    partial class AddMoneyOnBank
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
            this.addmoneybankidcombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addbankonmoneytext = new System.Windows.Forms.TextBox();
            this.addmoneybanksave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bank ID";
            // 
            // addmoneybankidcombobox
            // 
            this.addmoneybankidcombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addmoneybankidcombobox.FormattingEnabled = true;
            this.addmoneybankidcombobox.Location = new System.Drawing.Point(241, 59);
            this.addmoneybankidcombobox.Name = "addmoneybankidcombobox";
            this.addmoneybankidcombobox.Size = new System.Drawing.Size(305, 33);
            this.addmoneybankidcombobox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add Bank Money";
            // 
            // addbankonmoneytext
            // 
            this.addbankonmoneytext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbankonmoneytext.Location = new System.Drawing.Point(241, 129);
            this.addbankonmoneytext.Name = "addbankonmoneytext";
            this.addbankonmoneytext.Size = new System.Drawing.Size(305, 31);
            this.addbankonmoneytext.TabIndex = 4;
            // 
            // addmoneybanksave
            // 
            this.addmoneybanksave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addmoneybanksave.Location = new System.Drawing.Point(264, 192);
            this.addmoneybanksave.Name = "addmoneybanksave";
            this.addmoneybanksave.Size = new System.Drawing.Size(89, 35);
            this.addmoneybanksave.TabIndex = 5;
            this.addmoneybanksave.Text = "Save";
            this.addmoneybanksave.UseVisualStyleBackColor = true;
            this.addmoneybanksave.Click += new System.EventHandler(this.addmoneybanksave_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(433, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddMoneyOnBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addmoneybanksave);
            this.Controls.Add(this.addbankonmoneytext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addmoneybankidcombobox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddMoneyOnBank";
            this.Text = "Add Money On Bank";
            this.Load += new System.EventHandler(this.AddMoneyOnBank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox addmoneybankidcombobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addbankonmoneytext;
        private System.Windows.Forms.Button addmoneybanksave;
        private System.Windows.Forms.Button button1;
    }
}