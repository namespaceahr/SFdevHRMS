namespace UserInterface.TrainingManage
{
    partial class TakeNewTraining
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
            this.addtrainingidtext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addtrainingtopictext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addtrainingreviewtext = new System.Windows.Forms.TextBox();
            this.addtrainingsave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Training ID";
            // 
            // addtrainingidtext
            // 
            this.addtrainingidtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtrainingidtext.Location = new System.Drawing.Point(208, 48);
            this.addtrainingidtext.Name = "addtrainingidtext";
            this.addtrainingidtext.Size = new System.Drawing.Size(160, 29);
            this.addtrainingidtext.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Training Topic";
            // 
            // addtrainingtopictext
            // 
            this.addtrainingtopictext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtrainingtopictext.Location = new System.Drawing.Point(208, 100);
            this.addtrainingtopictext.Name = "addtrainingtopictext";
            this.addtrainingtopictext.Size = new System.Drawing.Size(160, 29);
            this.addtrainingtopictext.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Training Review";
            // 
            // addtrainingreviewtext
            // 
            this.addtrainingreviewtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtrainingreviewtext.Location = new System.Drawing.Point(208, 159);
            this.addtrainingreviewtext.Name = "addtrainingreviewtext";
            this.addtrainingreviewtext.Size = new System.Drawing.Size(160, 29);
            this.addtrainingreviewtext.TabIndex = 6;
            // 
            // addtrainingsave
            // 
            this.addtrainingsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtrainingsave.Location = new System.Drawing.Point(208, 233);
            this.addtrainingsave.Name = "addtrainingsave";
            this.addtrainingsave.Size = new System.Drawing.Size(75, 34);
            this.addtrainingsave.TabIndex = 17;
            this.addtrainingsave.Text = "Save";
            this.addtrainingsave.UseVisualStyleBackColor = true;
            this.addtrainingsave.Click += new System.EventHandler(this.addtrainingsave_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(357, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 18;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Enter Integer Value Only";
            // 
            // TakeNewTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 291);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addtrainingsave);
            this.Controls.Add(this.addtrainingreviewtext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addtrainingtopictext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addtrainingidtext);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TakeNewTraining";
            this.Text = "Take New Training";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addtrainingidtext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addtrainingtopictext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addtrainingreviewtext;
        private System.Windows.Forms.Button addtrainingsave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}