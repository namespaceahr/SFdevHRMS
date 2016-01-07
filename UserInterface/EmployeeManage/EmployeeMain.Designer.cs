namespace UserInterface.EmployeeManage
{
    partial class EmployeeMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.myJobInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkMyAllAssignedJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myTrainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeNewTrainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateATrainingInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteATrainingInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAllMyTrainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myPayrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkMySalaryAndBonusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeMyPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeloginlabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myJobInformationToolStripMenuItem,
            this.myTrainingToolStripMenuItem,
            this.myPayrollToolStripMenuItem,
            this.myAccountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(841, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // myJobInformationToolStripMenuItem
            // 
            this.myJobInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jobStatusToolStripMenuItem,
            this.checkMyAllAssignedJobToolStripMenuItem});
            this.myJobInformationToolStripMenuItem.Name = "myJobInformationToolStripMenuItem";
            this.myJobInformationToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.myJobInformationToolStripMenuItem.Text = "My Job Information";
            // 
            // jobStatusToolStripMenuItem
            // 
            this.jobStatusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem});
            this.jobStatusToolStripMenuItem.Name = "jobStatusToolStripMenuItem";
            this.jobStatusToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.jobStatusToolStripMenuItem.Text = "Job Status";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.addNewToolStripMenuItem.Text = "Add New Or Update Job Status";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // checkMyAllAssignedJobToolStripMenuItem
            // 
            this.checkMyAllAssignedJobToolStripMenuItem.Name = "checkMyAllAssignedJobToolStripMenuItem";
            this.checkMyAllAssignedJobToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.checkMyAllAssignedJobToolStripMenuItem.Text = "Check My All Assigned Job";
            this.checkMyAllAssignedJobToolStripMenuItem.Click += new System.EventHandler(this.checkMyAllAssignedJobToolStripMenuItem_Click);
            // 
            // myTrainingToolStripMenuItem
            // 
            this.myTrainingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takeNewTrainingToolStripMenuItem,
            this.updateATrainingInformationToolStripMenuItem,
            this.deleteATrainingInformationToolStripMenuItem,
            this.checkAllMyTrainingToolStripMenuItem});
            this.myTrainingToolStripMenuItem.Name = "myTrainingToolStripMenuItem";
            this.myTrainingToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.myTrainingToolStripMenuItem.Text = "My Training";
            // 
            // takeNewTrainingToolStripMenuItem
            // 
            this.takeNewTrainingToolStripMenuItem.Name = "takeNewTrainingToolStripMenuItem";
            this.takeNewTrainingToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.takeNewTrainingToolStripMenuItem.Text = "Take New Training";
            this.takeNewTrainingToolStripMenuItem.Click += new System.EventHandler(this.takeNewTrainingToolStripMenuItem_Click);
            // 
            // updateATrainingInformationToolStripMenuItem
            // 
            this.updateATrainingInformationToolStripMenuItem.Name = "updateATrainingInformationToolStripMenuItem";
            this.updateATrainingInformationToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.updateATrainingInformationToolStripMenuItem.Text = "Update A Training Information";
            this.updateATrainingInformationToolStripMenuItem.Click += new System.EventHandler(this.updateATrainingInformationToolStripMenuItem_Click);
            // 
            // deleteATrainingInformationToolStripMenuItem
            // 
            this.deleteATrainingInformationToolStripMenuItem.Name = "deleteATrainingInformationToolStripMenuItem";
            this.deleteATrainingInformationToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.deleteATrainingInformationToolStripMenuItem.Text = "Delete A Training Information";
            this.deleteATrainingInformationToolStripMenuItem.Click += new System.EventHandler(this.deleteATrainingInformationToolStripMenuItem_Click);
            // 
            // checkAllMyTrainingToolStripMenuItem
            // 
            this.checkAllMyTrainingToolStripMenuItem.Name = "checkAllMyTrainingToolStripMenuItem";
            this.checkAllMyTrainingToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.checkAllMyTrainingToolStripMenuItem.Text = "Check All My Training";
            this.checkAllMyTrainingToolStripMenuItem.Click += new System.EventHandler(this.checkAllMyTrainingToolStripMenuItem_Click);
            // 
            // myPayrollToolStripMenuItem
            // 
            this.myPayrollToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkMySalaryAndBonusToolStripMenuItem});
            this.myPayrollToolStripMenuItem.Name = "myPayrollToolStripMenuItem";
            this.myPayrollToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.myPayrollToolStripMenuItem.Text = "My Payroll";
            // 
            // checkMySalaryAndBonusToolStripMenuItem
            // 
            this.checkMySalaryAndBonusToolStripMenuItem.Name = "checkMySalaryAndBonusToolStripMenuItem";
            this.checkMySalaryAndBonusToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.checkMySalaryAndBonusToolStripMenuItem.Text = "Check My Salary And Bonus";
            this.checkMySalaryAndBonusToolStripMenuItem.Click += new System.EventHandler(this.checkMySalaryAndBonusToolStripMenuItem_Click);
            // 
            // myAccountToolStripMenuItem
            // 
            this.myAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeMyPasswordToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.myAccountToolStripMenuItem.Name = "myAccountToolStripMenuItem";
            this.myAccountToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.myAccountToolStripMenuItem.Text = "My Account ";
            // 
            // changeMyPasswordToolStripMenuItem
            // 
            this.changeMyPasswordToolStripMenuItem.Name = "changeMyPasswordToolStripMenuItem";
            this.changeMyPasswordToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.changeMyPasswordToolStripMenuItem.Text = "Change My Password";
            this.changeMyPasswordToolStripMenuItem.Click += new System.EventHandler(this.changeMyPasswordToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // employeeloginlabel
            // 
            this.employeeloginlabel.AutoSize = true;
            this.employeeloginlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeloginlabel.Location = new System.Drawing.Point(428, -1);
            this.employeeloginlabel.Name = "employeeloginlabel";
            this.employeeloginlabel.Size = new System.Drawing.Size(65, 25);
            this.employeeloginlabel.TabIndex = 2;
            this.employeeloginlabel.Text = "Login";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 282);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(841, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(400, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.toolStripProgressBar1.Visible = false;
            // 
            // EmployeeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 304);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.employeeloginlabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EmployeeMain";
            this.Text = "Employee Main Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem myJobInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jobStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkMyAllAssignedJobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myTrainingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeNewTrainingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateATrainingInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteATrainingInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkAllMyTrainingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myPayrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkMySalaryAndBonusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeMyPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label employeeloginlabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}