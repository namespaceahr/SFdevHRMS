using DataLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.EmployeeJobInformation;
using UserInterface.PayrollManage;
using UserInterface.TrainingManage;

namespace UserInterface.EmployeeManage
{
    public partial class EmployeeMain : Form
    {
        //Job Assigned
        AddNewOrUpdateJobStatus anoujs;
        CheckAllMyJob camj;

        //Training
        TakeNewTraining tnt;
        UpdateATrainingInformation uati;
        DeleteATraining dat;
        CheckAllTraining cat;

        //Payroll
        CheckSalaryBonusEmployee csbe;

        //Change Password
        ChangeEmployeePassword cep;


        BackgroundWorker JobStatus;
        BackgroundWorker Training;
        BackgroundWorker payroll;
        





        Employee n = new Employee();
        public EmployeeMain(Employee obj)
        {
            this.n = obj;
            InitializeComponent();
            employeeloginlabel.Text ="Login As: "+obj.employeeId;


        //JobStatus

            JobStatus = new BackgroundWorker();

            JobStatus.DoWork += WorkerJobStatus_DoWork;

            JobStatus.RunWorkerCompleted += WorkerJobStatus_RunWorkerCompleted;
            JobStatus.WorkerReportsProgress = true;

      //Training 
            Training = new BackgroundWorker();

            Training.DoWork += WorkerTraining_DoWork;

            Training.RunWorkerCompleted += WorkerTraining_RunWorkerCompleted;
            Training.WorkerReportsProgress = true;

      //payroll
            payroll = new BackgroundWorker();

            payroll.DoWork += Workerpayroll_DoWork;

            payroll.RunWorkerCompleted += Workerpayroll_RunWorkerCompleted;
            payroll.WorkerReportsProgress = true;

        }


        #region JobStatusBackgroundWorker
        private void WorkerJobStatus_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {


            if (camj == null)
            {

                camj = new CheckAllMyJob((List<EmployeeJobAssign>)e.Result);
                camj.MdiParent = this;
                camj.FormClosed += camj_FormClosed;
                camj.Show();
                toolStripProgressBar1.Visible = false;
                toolStripStatusLabel1.Text = "All Job Information Load  Done";

            }
            else
            {
                toolStripProgressBar1.Visible = false;
                toolStripStatusLabel1.Text = "All Job Information Load  Done";
                camj.Activate();
            }
        }

        


        private void WorkerJobStatus_DoWork(object sender, DoWorkEventArgs e)
        {


            List<EmployeeJobAssign> dataReceived = new EmployeeJobAssignData().GetAssignJobListForEmployee(n.employeeId);
            e.Result = dataReceived;


        }
        #endregion


        #region TrainingBackgroundWorker
        private void WorkerTraining_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {


            if (cat == null)
            {

                cat = new CheckAllTraining((List<Training>)e.Result);
                cat.MdiParent = this;
                cat.FormClosed += cat_FormClosed;
                cat.Show();
                toolStripProgressBar1.Visible = false;
                toolStripStatusLabel1.Text = "All  Training Information Load  Done";

            }
            else
            {
                toolStripProgressBar1.Visible = false;
                toolStripStatusLabel1.Text = "All  Training Information Load  Done";
                cat.Activate();
            }
        }

       



        private void WorkerTraining_DoWork(object sender, DoWorkEventArgs e)
        {


            List<Training> dataReceived = new TrainingData().GetEmployeeTrainingEmployee(n.employeeId);
            e.Result = dataReceived;


        }
        #endregion


        #region PayrollBackgroundWorker
        private void Workerpayroll_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {


            if (csbe == null)
            {

                csbe = new CheckSalaryBonusEmployee((List<Payroll>)e.Result);
                csbe.MdiParent = this;
                csbe.FormClosed += csbe_FormClosed;
                csbe.Show();
                toolStripProgressBar1.Visible = false;
                toolStripStatusLabel1.Text = "Salary And Bonus Information Load  Done";

            }
            else
            {
                toolStripProgressBar1.Visible = false;
                toolStripStatusLabel1.Text = "Salary And Bonus Information Load  Done";
                csbe.Activate();
            }
        }

      




        private void Workerpayroll_DoWork(object sender, DoWorkEventArgs e)
        {


            List<Payroll> dataReceived = new PayrollData().GetAllPayrollListEmployee(n.employeeId);
            e.Result = dataReceived;


        }
        #endregion



        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new Main().Show();

            object logout = MessageBox.Show("Logout Success.", "SFdevHRMS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);
             
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (anoujs == null)
            {
                anoujs = new AddNewOrUpdateJobStatus(n);
                anoujs.MdiParent = this;
                anoujs.FormClosed += anoujs_FormClosed;
                anoujs.Show();

            }
            else
            {
                anoujs.Activate();
            }
        }

        void anoujs_FormClosed(object sender, FormClosedEventArgs e)
        {
            anoujs = null;
        }

        private void checkMyAllAssignedJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Visible = true;
            toolStripStatusLabel1.Text = "Loading All Job  Information";
            JobStatus.RunWorkerAsync();
        }

        void camj_FormClosed(object sender, FormClosedEventArgs e)
        {
            camj = null;
        }

        private void takeNewTrainingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tnt == null)
            {
                tnt = new TakeNewTraining(n);
                tnt.MdiParent = this;
                tnt.FormClosed += tnt_FormClosed;
                tnt.Show();

            }
            else
            {
                tnt.Activate();
            }
        }

        void tnt_FormClosed(object sender, FormClosedEventArgs e)
        {
            tnt = null;
        }

        private void updateATrainingInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
             if (uati == null)
            {
                uati = new UpdateATrainingInformation(n);
                uati.MdiParent = this;
                uati.FormClosed +=uati_FormClosed;
                uati.Show();

            }
            else
            {
                uati.Activate();
            }
        }

        void uati_FormClosed(object sender, FormClosedEventArgs e)
        {
 	        uati = null;
        }

        private void deleteATrainingInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dat== null)
            {
                dat = new DeleteATraining(n);
                dat.MdiParent = this;
                dat.FormClosed += dat_FormClosed;
                dat.Show();

            }
            else
            {
                dat.Activate();
            }

        }

        void dat_FormClosed(object sender, FormClosedEventArgs e)
        {
            dat = null;
        }

        private void checkAllMyTrainingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Visible = true;
            toolStripStatusLabel1.Text = "Loading Training  Information";
            Training.RunWorkerAsync();
        }

        void cat_FormClosed(object sender, FormClosedEventArgs e)
        {
            cat = null;
        }

        private void checkMySalaryAndBonusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Visible = true;
            toolStripStatusLabel1.Text = "Loading Salary And Bonus  Information";
            payroll.RunWorkerAsync();
        }

        void csbe_FormClosed(object sender, FormClosedEventArgs e)
        {
            csbe = null;
        }

        private void changeMyPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cep == null)
            {
                cep = new ChangeEmployeePassword(n);
                cep.MdiParent = this;
                cep.FormClosed += cep_FormClosed;
                cep.Show();

            }
            else
            {
                cep.Activate();
            }
        }

        void cep_FormClosed(object sender, FormClosedEventArgs e)
        {
            cep = null;
        }

    }
}
