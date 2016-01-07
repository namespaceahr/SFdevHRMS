namespace UserInterface.AdminManage
{
    partial class UpdateAdmin
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
            this.updateadminnametext = new System.Windows.Forms.TextBox();
            this.updateadminpasswordtext = new System.Windows.Forms.TextBox();
            this.updateadminsave = new System.Windows.Forms.Button();
            this.updateadminidcombobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Admin Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Admin Password";
            // 
            // updateadminnametext
            // 
            this.updateadminnametext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateadminnametext.Location = new System.Drawing.Point(384, 111);
            this.updateadminnametext.Name = "updateadminnametext";
            this.updateadminnametext.Size = new System.Drawing.Size(196, 31);
            this.updateadminnametext.TabIndex = 4;
            // 
            // updateadminpasswordtext
            // 
            this.updateadminpasswordtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateadminpasswordtext.Location = new System.Drawing.Point(384, 168);
            this.updateadminpasswordtext.Name = "updateadminpasswordtext";
            this.updateadminpasswordtext.Size = new System.Drawing.Size(196, 31);
            this.updateadminpasswordtext.TabIndex = 5;
            // 
            // updateadminsave
            // 
            this.updateadminsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateadminsave.Location = new System.Drawing.Point(419, 280);
            this.updateadminsave.Name = "updateadminsave";
            this.updateadminsave.Size = new System.Drawing.Size(86, 45);
            this.updateadminsave.TabIndex = 6;
            this.updateadminsave.Text = "Save";
            this.updateadminsave.UseVisualStyleBackColor = true;
            this.updateadminsave.Click += new System.EventHandler(this.updateadminsave_Click);
            // 
            // updateadminidcombobox
            // 
            this.updateadminidcombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateadminidcombobox.FormattingEnabled = true;
            this.updateadminidcombobox.Location = new System.Drawing.Point(384, 47);
            this.updateadminidcombobox.Name = "updateadminidcombobox";
            this.updateadminidcombobox.Size = new System.Drawing.Size(196, 33);
            this.updateadminidcombobox.TabIndex = 8;
            this.updateadminidcombobox.SelectedValueChanged += new System.EventHandler(this.updateadminidcombobox_SelectedValueChanged);
            // 
            // UpdateAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 364);
            this.Controls.Add(this.updateadminidcombobox);
            this.Controls.Add(this.updateadminsave);
            this.Controls.Add(this.updateadminpasswordtext);
            this.Controls.Add(this.updateadminnametext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateAdmin";
            this.Text = "Update An Admin Information";
            this.Load += new System.EventHandler(this.UpdateAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox updateadminnametext;
        private System.Windows.Forms.TextBox updateadminpasswordtext;
        private System.Windows.Forms.Button updateadminsave;
        private System.Windows.Forms.ComboBox updateadminidcombobox;
    }
}