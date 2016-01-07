namespace UserInterface.BankManage
{
    partial class TotalEmployeePaymentAndBankMoney
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
            this.totalemployeepaymenttext = new System.Windows.Forms.TextBox();
            this.totalbankbalancetext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nbstatus = new System.Windows.Forms.Label();
            this.Nbb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Employee Payment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Bank Balance";
            // 
            // totalemployeepaymenttext
            // 
            this.totalemployeepaymenttext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalemployeepaymenttext.Location = new System.Drawing.Point(314, 94);
            this.totalemployeepaymenttext.Name = "totalemployeepaymenttext";
            this.totalemployeepaymenttext.Size = new System.Drawing.Size(305, 31);
            this.totalemployeepaymenttext.TabIndex = 5;
            // 
            // totalbankbalancetext
            // 
            this.totalbankbalancetext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalbankbalancetext.Location = new System.Drawing.Point(314, 30);
            this.totalbankbalancetext.Name = "totalbankbalancetext";
            this.totalbankbalancetext.Size = new System.Drawing.Size(305, 31);
            this.totalbankbalancetext.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(331, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Withdraw Money  For Pay Now";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nbstatus
            // 
            this.nbstatus.AutoSize = true;
            this.nbstatus.ForeColor = System.Drawing.Color.DarkRed;
            this.nbstatus.Location = new System.Drawing.Point(311, 147);
            this.nbstatus.Name = "nbstatus";
            this.nbstatus.Size = new System.Drawing.Size(19, 13);
            this.nbstatus.TabIndex = 8;
            this.nbstatus.Text = "nb";
            // 
            // Nbb
            // 
            this.Nbb.AutoSize = true;
            this.Nbb.ForeColor = System.Drawing.Color.DarkRed;
            this.Nbb.Location = new System.Drawing.Point(311, 160);
            this.Nbb.Name = "Nbb";
            this.Nbb.Size = new System.Drawing.Size(19, 13);
            this.Nbb.TabIndex = 9;
            this.Nbb.Text = "nb";
            // 
            // TotalEmployeePaymentAndBankMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 261);
            this.Controls.Add(this.Nbb);
            this.Controls.Add(this.nbstatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.totalbankbalancetext);
            this.Controls.Add(this.totalemployeepaymenttext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TotalEmployeePaymentAndBankMoney";
            this.Text = "Total Employee Payment And Bank Money";
            this.Load += new System.EventHandler(this.TotalEmployeePaymentAndBankMoney_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalemployeepaymenttext;
        private System.Windows.Forms.TextBox totalbankbalancetext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label nbstatus;
        private System.Windows.Forms.Label Nbb;
    }
}