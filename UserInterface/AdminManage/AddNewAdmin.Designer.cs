namespace UserInterface.AdminManage
{
    partial class AddNewAdmin
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
            this.adminidadd = new System.Windows.Forms.Label();
            this.adminidaddtext = new System.Windows.Forms.TextBox();
            this.adminnameadd = new System.Windows.Forms.Label();
            this.adminnametext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adminpasswordtext = new System.Windows.Forms.TextBox();
            this.buttonadmininsert = new System.Windows.Forms.Button();
            this.clearadminadd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminidadd
            // 
            this.adminidadd.AutoSize = true;
            this.adminidadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminidadd.Location = new System.Drawing.Point(163, 43);
            this.adminidadd.Name = "adminidadd";
            this.adminidadd.Size = new System.Drawing.Size(98, 25);
            this.adminidadd.TabIndex = 0;
            this.adminidadd.Text = "Admin ID";
            // 
            // adminidaddtext
            // 
            this.adminidaddtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminidaddtext.Location = new System.Drawing.Point(329, 37);
            this.adminidaddtext.Name = "adminidaddtext";
            this.adminidaddtext.Size = new System.Drawing.Size(284, 31);
            this.adminidaddtext.TabIndex = 1;
            // 
            // adminnameadd
            // 
            this.adminnameadd.AutoSize = true;
            this.adminnameadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminnameadd.Location = new System.Drawing.Point(127, 108);
            this.adminnameadd.Name = "adminnameadd";
            this.adminnameadd.Size = new System.Drawing.Size(134, 25);
            this.adminnameadd.TabIndex = 2;
            this.adminnameadd.Text = "Admin Name";
            // 
            // adminnametext
            // 
            this.adminnametext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminnametext.Location = new System.Drawing.Point(329, 108);
            this.adminnametext.Name = "adminnametext";
            this.adminnametext.Size = new System.Drawing.Size(284, 31);
            this.adminnametext.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Admin Password";
            // 
            // adminpasswordtext
            // 
            this.adminpasswordtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminpasswordtext.Location = new System.Drawing.Point(329, 175);
            this.adminpasswordtext.Name = "adminpasswordtext";
            this.adminpasswordtext.Size = new System.Drawing.Size(284, 31);
            this.adminpasswordtext.TabIndex = 5;
            // 
            // buttonadmininsert
            // 
            this.buttonadmininsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonadmininsert.Location = new System.Drawing.Point(329, 265);
            this.buttonadmininsert.Name = "buttonadmininsert";
            this.buttonadmininsert.Size = new System.Drawing.Size(112, 38);
            this.buttonadmininsert.TabIndex = 6;
            this.buttonadmininsert.Text = "Save";
            this.buttonadmininsert.UseVisualStyleBackColor = true;
            this.buttonadmininsert.Click += new System.EventHandler(this.buttonadmininsert_Click);
            // 
            // clearadminadd
            // 
            this.clearadminadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearadminadd.Location = new System.Drawing.Point(501, 265);
            this.clearadminadd.Name = "clearadminadd";
            this.clearadminadd.Size = new System.Drawing.Size(112, 38);
            this.clearadminadd.TabIndex = 7;
            this.clearadminadd.Text = "Clear";
            this.clearadminadd.UseVisualStyleBackColor = true;
            this.clearadminadd.Click += new System.EventHandler(this.clearadminadd_Click);
            // 
            // AddNewAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(729, 319);
            this.Controls.Add(this.clearadminadd);
            this.Controls.Add(this.buttonadmininsert);
            this.Controls.Add(this.adminpasswordtext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminnametext);
            this.Controls.Add(this.adminnameadd);
            this.Controls.Add(this.adminidaddtext);
            this.Controls.Add(this.adminidadd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "AddNewAdmin";
            this.Text = "Add New Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adminidadd;
        private System.Windows.Forms.TextBox adminidaddtext;
        private System.Windows.Forms.Label adminnameadd;
        private System.Windows.Forms.TextBox adminnametext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adminpasswordtext;
        private System.Windows.Forms.Button buttonadmininsert;
        private System.Windows.Forms.Button clearadminadd;
    }
}