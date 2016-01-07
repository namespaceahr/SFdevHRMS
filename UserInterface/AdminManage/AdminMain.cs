using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using Entities;
using UserInterface.EmployeeManage;
using UserInterface.JobAssign;
using UserInterface.DepartmentManage;
using UserInterface.PerformanceManage;
using UserInterface.PayrollManage;
using UserInterface.TrainingManage;
using UserInterface.BankManage;




namespace UserInterface.AdminManage
{
    public partial class AdminMain : Form
    {
        Admin adminlogin = new Admin();

        //admin manage
        AddNewAdmin ana;
        DeleteAnAdmin da;
        UpdateAdmin ua;
        CheckAllAdmin caa;

        //Employee manage
        CreateNewEmployee cne;
        updateEmployeeInformation uei;
        CheckAllEmployee cae;
        DeleteAnEmployee dne;

        //Employee Assign
        AssignNewJob anj;
        ReassignJob aj;
        CheckAllAssignJob caaj;
        DeleteAnAssignJob daaj;

        //Department manage
        AddNewDepartment and;
        UpdateDepartmentInfo udi;
        DeleteAnDepartmentInfo dadi;
        CheckAllDepartmentInfo cadi;

        //Performance manage
        EvaluatePerformance ep;
        UpdateAnPerformance uap;
        DeleteAnPerformance dap;
        CheckAllPerformance cap;

        //Payroll  manage
        AddNewSalaryBonus ansb;
        UpdateASalaryBonus uasb;
        DeleteASalaryBonus dasb;
        CheckAllSalaryBonus casb;

        //Training
        CheckAllTrainingAdmin cata;

        //BankAccount
        AddNewBankInformation anbi;
        AddMoneyOnBank amob;
        TotalEmployeePaymentAndBankMoney tepabm;
        DeleteABankInformation dabi;
        WithdrawMoneyFromBank wmfb;
        CheckAllBankMoneyInformation cabmi;
        CheckAllEmployeesPayment caep;







        BackgroundWorker workerCheckAllAdmin;
        BackgroundWorker workerCheckAllEmployee;
        BackgroundWorker workerCheckAllAssignJob;
        BackgroundWorker workerCheckAllDepartment;
        BackgroundWorker workerCheckAllPerformance;
        BackgroundWorker workerCheckAllPayroll;
        BackgroundWorker workerCheckAllTraining;
        BackgroundWorker workerCheckAllBankAccount;
        BackgroundWorker workerCheckAllEpayment;

        public AdminMain(Admin login)
        {
            InitializeComponent();
            this.loginadminlabel.Text = "Login As "+login.adminId;

            this.adminlogin = login;

           // toolStripProgressBar1.Visible = false;

           //Admin info
            workerCheckAllAdmin = new BackgroundWorker();
            workerCheckAllAdmin.DoWork += WorkerAdmin_DoWork;
           
            workerCheckAllAdmin.RunWorkerCompleted += WorkerAdmin_RunWorkerCompleted;
            workerCheckAllAdmin.WorkerReportsProgress = true;
            
            //Employee info
            workerCheckAllEmployee = new BackgroundWorker();
            workerCheckAllEmployee.DoWork += WorkerEmployee_DoWork;
            
            workerCheckAllEmployee.RunWorkerCompleted += WorkerEmployee_RunWorkerCompleted;
            workerCheckAllEmployee.WorkerReportsProgress = true;

            //Assign job
            workerCheckAllAssignJob = new BackgroundWorker();
            workerCheckAllAssignJob.DoWork += WorkerAssignJob_DoWork;

            workerCheckAllAssignJob.RunWorkerCompleted += WorkerAssignJob_RunWorkerCompleted;
            workerCheckAllAssignJob.WorkerReportsProgress = true;

            //Department
            workerCheckAllDepartment = new BackgroundWorker();
            workerCheckAllDepartment.DoWork += WorkerDepartment_DoWork;

            workerCheckAllDepartment.RunWorkerCompleted += WorkerDepartment_RunWorkerCompleted;
            workerCheckAllDepartment.WorkerReportsProgress = true;

            //Performance
            workerCheckAllPerformance = new BackgroundWorker();
            workerCheckAllPerformance.DoWork += WorkerPerformance_DoWork;

            workerCheckAllPerformance.RunWorkerCompleted += WorkerPerformance_RunWorkerCompleted;
            workerCheckAllPerformance.WorkerReportsProgress = true;

            //Payroll
            workerCheckAllPayroll = new BackgroundWorker();
            workerCheckAllPayroll.DoWork += WorkerPayroll_DoWork;

            workerCheckAllPayroll.RunWorkerCompleted += WorkerPayroll_RunWorkerCompleted;
            workerCheckAllPayroll.WorkerReportsProgress = true;

            //Training
            workerCheckAllTraining = new BackgroundWorker();
            workerCheckAllTraining.DoWork += WorkerTraining_DoWork;

            workerCheckAllTraining.RunWorkerCompleted += WorkerTraining_RunWorkerCompleted;
            workerCheckAllTraining.WorkerReportsProgress = true;

            //BankAccount
            workerCheckAllBankAccount = new BackgroundWorker();
            workerCheckAllBankAccount.DoWork += WorkerBankAccount_DoWork;

            workerCheckAllBankAccount.RunWorkerCompleted += WorkerBankAccount_RunWorkerCompleted;
            workerCheckAllBankAccount.WorkerReportsProgress = true;

            //Employee Payment
            workerCheckAllEpayment = new BackgroundWorker();
            workerCheckAllEpayment.DoWork += WorkerEpayment_DoWork;

            workerCheckAllEpayment.RunWorkerCompleted += WorkerEpayment_RunWorkerCompleted;
            workerCheckAllEpayment.WorkerReportsProgress = true;

        }
        
        #region AdminBackgroundWorker 
        private void WorkerAdmin_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //List<Admin> dataReceived = (List<Admin>) e.Result;

            if (caa == null)
            {

                caa = new CheckAllAdmin(e.Result);
                caa.MdiParent = this;
                caa.FormClosed += caa_FormClosed;
                caa.Show();
                toolStripProgressBar1.Visible = false;
                toolStripStatusLabel1.Text = "All Admin Information Load  Done";
               
            }
            else
            {
                toolStripProgressBar1.Visible = false;
                toolStripStatusLabel1.Text = "All Admin Information Load  Done";
                caa.Activate();
            }
        }

    
        private void WorkerAdmin_DoWork(object sender, DoWorkEventArgs e)
        {
            // Executes when RunWorkerAsync() is called

            List<object> dataReceived = new AdminData().GetAdminList(); //change for other all
            e.Result = dataReceived;
            
            
        }
        #endregion


        #region EmployeeBackgroundWorker
        private void WorkerEmployee_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            

            if (cae == null)
            {
                cae = new CheckAllEmployee(e.Result);
                cae.MdiParent = this;
                cae.FormClosed += cae_FormClosed;
                cae.Show();
                toolStripProgressBar1.Visible = false;
                toolStripStatusLabel1.Text = "All Employee Information Load  Done";
            }
            else
            {
                toolStripProgressBar1.Visible = false;
                toolStripStatusLabel1.Text = "All Employee Information Load  Done";
                cae.Activate();
            }
        }

      

        private void WorkerEmployee_DoWork(object sender, DoWorkEventArgs e)
        {
            // Executes when RunWorkerAsync() is called

            List<object> dataReceived = new EmployeeData().GetEmployeeList(); 
            e.Result = dataReceived;
            
           
        }
        #endregion


        #region AssignJobBackgroundWorker
        private void WorkerAssignJob_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //List<EmployeeJobAssign> dataReceived = (List<EmployeeJobAssign>) e.Result;

            if (caaj == null)
            {
                caaj = new CheckAllAssignJob((List<EmployeeJobAssign>)e.Result);
                caaj.MdiParent = this;
                caaj.FormClosed += caaj_FormClosed;
                caaj.Show();
                toolStripProgressBar1.Visible = false;
                toolStripStatusLabel1.Text = "All Assign Job Information Load Done";
            }
            else
            {
                toolStripProgressBar1.Visible = false;
                toolStripStatusLabel1.Text = "All Assign Job Information Load Done";
                caaj.Activate();
            }
        }


        private void WorkerAssignJob_DoWork(object sender, DoWorkEventArgs e)
        {
            // Executes when RunWorkerAsync() is called

            List<EmployeeJobAssign> dataReceived = new EmployeeJobAssignData().GetAssignJobList(); //change for other all
            e.Result = dataReceived;


        }
        #endregion


        #region DepartmentBackgroundWorker
        private void WorkerDepartment_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (cadi == null)
            {
                cadi = new CheckAllDepartmentInfo((List<Department>) e.Result);
                cadi.MdiParent = this;
                cadi.FormClosed += cadi_FormClosed;
                cadi.Show();
                toolStripProgressBar1.Visible = false;
                toolStripStatusLabel1.Text = "All Department Information Load Done";
                
            }
            else
            {
                toolStripProgressBar1.Visible = false;
                toolStripStatusLabel1.Text = "All Department Information Load Done";
                cadi.CheckAllDepartmentInfo_Load(sender, e);
                cadi.Activate();
                
            }
        }

       


        private void WorkerDepartment_DoWork(object sender, DoWorkEventArgs e)
        {
            // Executes when RunWorkerAsync() is called

            List<Department> dataReceived = new DepartmentData().GetDepartmentList(); //change for other all
            e.Result = dataReceived;


        }
        #endregion


        #region PerformanceBackgroundWorker
        private void WorkerPerformance_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (cap == null)
            {
                cap = new CheckAllPerformance((List<Performance>)e.Result);
                cap.MdiParent = this;
                cap.FormClosed += cap_FormClosed;
                cap.Show();
                toolStripProgressBar1.Visible = false;
                toolStripStatusLabel1.Text = "All Performance Information Load Done";
            }
            else
            {
                toolStripProgressBar1.Visible = false;
                toolStripStatusLabel1.Text = "All Performance Information Load Done";
                cap.Activate();
            }
        }

        



        private void WorkerPerformance_DoWork(object sender, DoWorkEventArgs e)
        {
            // Executes when RunWorkerAsync() is called

            List<Performance> dataReceived = new PerformanceData().GetPerformanceList(); //change for other all
            e.Result = dataReceived;


        }
        #endregion


        #region PayrollBackgroundWorker
        private void WorkerPayroll_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (casb == null)
            {
                casb = new CheckAllSalaryBonus((List<Payroll>)e.Result);
                casb.MdiParent = this;
                casb.FormClosed += casb_FormClosed;
                casb.Show();
                toolStripProgressBar1.Visible = false;
                toolStripStatusLabel1.Text = "All Payroll Information Load Done";
            }
            else
            {
                toolStripProgressBar1.Visible = false;
                toolStripStatusLabel1.Text = "All Payroll Information Load Done";
                casb.Activate();
            }
        }

        




        private void WorkerPayroll_DoWork(object sender, DoWorkEventArgs e)
        {
            // Executes when RunWorkerAsync() is called

            List<Payroll> dataReceived = new PayrollData().GetAllPayrollList(); //change for other all
            e.Result = dataReceived;


        }
        #endregion


        #region TrainingBackgroundWorker
        private void WorkerTraining_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (cata == null)
            {
                cata = new CheckAllTrainingAdmin((List<Training>)e.Result);
                cata.MdiParent = this;
                cata.FormClosed += cata_FormClosed;
                cata.Show();
                toolStripProgressBar1.Visible = false;
                toolStripStatusLabel1.Text = "All Training Information Load Done";
            }
            else
            {
                toolStripProgressBar1.Visible = false;
                toolStripStatusLabel1.Text = "All Training Information Load Done";
                cata.Activate();
            }
        }

       





        private void WorkerTraining_DoWork(object sender, DoWorkEventArgs e)
        {
            // Executes when RunWorkerAsync() is called

            List<Training> dataReceived = new TrainingData().GetAllEmployeeTraining(); //change for other all
            e.Result = dataReceived;


        }
        #endregion


        #region BankAccountBackgroundWorker
        private void WorkerBankAccount_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (cabmi == null)
            {
                cabmi = new CheckAllBankMoneyInformation((List<BankAccount>)e.Result);
                cabmi.MdiParent = this;
                cabmi.FormClosed += cabmi_FormClosed;
                cabmi.Show();
                toolStripProgressBar1.Visible = false;
                toolStripStatusLabel1.Text = "All BankAccount Information Load Done";
            }
            else
            {
                toolStripProgressBar1.Visible = false;
                toolStripStatusLabel1.Text = "All BankAccount Information Load Done";
                cabmi.Activate();
            }
        }

       







        private void WorkerBankAccount_DoWork(object sender, DoWorkEventArgs e)
        {
            // Executes when RunWorkerAsync() is called

            List<BankAccount> dataReceived = new BankAccountData().GetBankAccountInformation();//change for other all
            e.Result = dataReceived;


        }
        #endregion



        #region EpaymentBackgroundWorker
        private void WorkerEpayment_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (caep == null)
            {
                caep = new CheckAllEmployeesPayment((List<object>)e.Result);
                caep.MdiParent = this;
                caep.FormClosed += caep_FormClosed;
                caep.Show();
                toolStripProgressBar1.Visible = false;
                toolStripStatusLabel1.Text = "All Employees payment Information Load Done";
            }
            else
            {
                toolStripProgressBar1.Visible = false;
                toolStripStatusLabel1.Text = "All Employees payment Information Load Done";
                caep.Activate();
            }
        }

       








        private void WorkerEpayment_DoWork(object sender, DoWorkEventArgs e)
        {
            // Executes when RunWorkerAsync() is called

            List<object> dataReceived = new BankAccountData().GetEmployeePaymentHistory();//change for other all
            e.Result = dataReceived;


        }
        #endregion





      

        private void createNewAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ana == null)
            {
                ana = new AddNewAdmin();
                ana.MdiParent = this;
                ana.FormClosed += ana_FormClosed;
                  ana.Show();
                
            }
            else
            {
                ana.Activate();
            }

        }

        void ana_FormClosed(object sender, FormClosedEventArgs e)
        {
            ana = null;
        }

        private void deleteAnAdminInfomationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(da==null)
            {
                da = new DeleteAnAdmin();
                da.MdiParent = this;
                da.FormClosed += da_FormClosed;
                da.Show();

            }
            else
            {
                da.Activate();
            }

        }

        void da_FormClosed(object sender, FormClosedEventArgs e)
        {
            da = null;
        }

        private void editAnAdminInfomationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(ua==null)
            {
                ua = new UpdateAdmin();
                ua.MdiParent = this;
                ua.FormClosed += ua_FormClosed;
                ua.Show();
            }
            else
            {

                ua.Activate();
            }


        }

        void ua_FormClosed(object sender, FormClosedEventArgs e)
        {
            ua = null;
        }

        private void checkAllAdminInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Visible = true;
            toolStripStatusLabel1.Text = "Loading All Admin Information";
            workerCheckAllAdmin.RunWorkerAsync();

        }

        void caa_FormClosed(object sender, FormClosedEventArgs e)
        {
            caa = null;
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Main().Show();
           


            object logout= MessageBox.Show("Logout Success.","SFdevHRMS",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button3);
               
            
        }

      
      private void createToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            if (cne == null)
            {
                cne = new CreateNewEmployee();
                cne.MdiParent = this;
                cne.FormClosed += cne_FormClosed;
                cne.Show();

            }
            else
            {
                cne.Activate();
            }
        }

      void cne_FormClosed(object sender, FormClosedEventArgs e)
      {
          cne = null;
      }

      private void editAnEmployeeInformationToolStripMenuItem_Click(object sender, EventArgs e)
      {
          if (uei == null)
          {
              uei = new updateEmployeeInformation();
              uei.MdiParent = this;
              uei.FormClosed += uei_FormClosed;
              uei.Show();

          }
          else
          {
              uei.Activate();
          }
      }

      void uei_FormClosed(object sender, FormClosedEventArgs e)
      {
          uei = null;
      }

      private void checkAllEmployeInformationToolStripMenuItem_Click(object sender, EventArgs e)
      {
          toolStripProgressBar1.Visible = true;
          toolStripStatusLabel1.Text = "Loading All Employee Information";
          workerCheckAllEmployee.RunWorkerAsync();

      }
      void cae_FormClosed(object sender, FormClosedEventArgs e)
      {
          cae = null;
      }

      private void deleteAnEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
      {
          if (dne == null)
          {
              dne = new DeleteAnEmployee();
              dne.MdiParent = this;
              dne.FormClosed += dne_FormClosed;
              dne.Show();
          }
          else
          {

              dne.Activate();
          }
      }

     void dne_FormClosed(object sender, FormClosedEventArgs e)
            {
 	            dne=null;
            }

     private void assignANewJobToolStripMenuItem_Click(object sender, EventArgs e)
     {

         if (anj == null)
         {
             anj = new AssignNewJob(this.adminlogin);
             anj.MdiParent = this;
             anj.FormClosed += anj_FormClosed;
             anj.Show();
             
         }
         else
         {

             anj.Activate();
         }
     }

     void anj_FormClosed(object sender, FormClosedEventArgs e)
     {
         anj = null;
     }

     private void reAssignAJobToolStripMenuItem_Click(object sender, EventArgs e)
     {
         if (aj == null)
         {
             aj = new ReassignJob(this.adminlogin);
             aj.MdiParent = this;
             aj.FormClosed += aj_FormClosed; 
             aj.Show();
            
         }
         else
         {

            aj.Activate();
         }



     }

     void aj_FormClosed(object sender, FormClosedEventArgs e)
     {
         aj = null;
     }

     private void checkAllAssignedJobToolStripMenuItem_Click(object sender, EventArgs e)
     {
         toolStripProgressBar1.Visible = true;
         toolStripStatusLabel1.Text = "Loading All Assign Job Information";
         workerCheckAllAssignJob.RunWorkerAsync();

     }

        
        void caaj_FormClosed(object sender, FormClosedEventArgs e)
        {
            caaj = null;
        }

        private void deleteAAssignJobToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (daaj == null)
            {
                daaj = new DeleteAnAssignJob();
                daaj.MdiParent = this;
                daaj.FormClosed += daaj_FormClosed;
                daaj.Show();
                
            }
            else
            {

                daaj.Activate();
            }

        }

        void daaj_FormClosed(object sender, FormClosedEventArgs e)
        {
            daaj = null;
        }

        private void addNewDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (and == null)
            {
                and = new AddNewDepartment();
                and.MdiParent = this;
                and.FormClosed +=and_FormClosed;
                  and.Show();
                
            }
            else
            {
                and.Activate();
            }

        }

          void and_FormClosed(object sender, FormClosedEventArgs e)
        {
 	          and=null;
        }

          private void updateADepartmentInformationToolStripMenuItem_Click(object sender, EventArgs e)
          {
              if (udi == null)
              {
                  udi = new UpdateDepartmentInfo();
                  udi.MdiParent = this;
                  udi.FormClosed += udi_FormClosed;
                  udi.Show();

              }
              else
              {
                  udi.Activate();
              }


          }

          void udi_FormClosed(object sender, FormClosedEventArgs e)
          {
              udi = null;
          }

          private void deleteADepartmentToolStripMenuItem_Click(object sender, EventArgs e)
          {
              if (dadi == null)
              {
                  dadi = new DeleteAnDepartmentInfo();
                  dadi.MdiParent = this;
                  dadi.FormClosed += dadi_FormClosed;
                  dadi.Show();

              }
              else
              {
                  dadi.Activate();
              }
          }

          void dadi_FormClosed(object sender, FormClosedEventArgs e)
          {
              dadi = null;
          }

          private void checkAllDepartmentInformationToolStripMenuItem_Click(object sender, EventArgs e)
          {
              toolStripProgressBar1.Visible = true;
              toolStripStatusLabel1.Text = "Loading All Department  Information";
              workerCheckAllDepartment.RunWorkerAsync();
          }
          void cadi_FormClosed(object sender, FormClosedEventArgs e)
          {
              cadi = null;
          }

          private void evaluateAnEmployeePerformanceToolStripMenuItem_Click(object sender, EventArgs e)
          {
              if (ep == null)
              {
                  ep = new EvaluatePerformance(adminlogin);
                  ep.MdiParent = this;
                  ep.FormClosed += ep_FormClosed;
                  ep.Show();

              }
              else
              {
                  ep.Activate();
              }
          }

          void ep_FormClosed(object sender, FormClosedEventArgs e)
          {
              ep = null;
          }

          private void updateAnPerformanceInformationToolStripMenuItem_Click(object sender, EventArgs e)
          {
              if (uap == null)
              {
                  uap = new UpdateAnPerformance(adminlogin);
                  uap.MdiParent = this;
                  uap.FormClosed += uap_FormClosed;
                  uap.Show();

              }
              else
              {
                  uap.Activate();
              }


          }

          void uap_FormClosed(object sender, FormClosedEventArgs e)
          {
              uap = null;
          }

          private void checkAllPerformanceInformationToolStripMenuItem_Click(object sender, EventArgs e)
          {
              if (dap == null)
              {
                  dap = new DeleteAnPerformance();
                  dap.MdiParent = this;
                  dap.FormClosed += dap_FormClosed;
                  dap.Show();
              }
              else
              {

                  dap.Activate();
              }

          }

          void dap_FormClosed(object sender, FormClosedEventArgs e)
          {
              dap = null;
          }

          private void deleteAnPerformanceInformationToolStripMenuItem_Click(object sender, EventArgs e)
          {
              toolStripProgressBar1.Visible = true;
              toolStripStatusLabel1.Text = "Loading All Performance  Information";
              workerCheckAllPerformance.RunWorkerAsync();

          }
          void cap_FormClosed(object sender, FormClosedEventArgs e)
          {
              cap = null;
          }

          private void addNewEmployeeSalaryToolStripMenuItem_Click(object sender, EventArgs e)
          {
              if (ansb == null)
              {
                  ansb = new AddNewSalaryBonus();
                  ansb.MdiParent = this;
                  ansb.FormClosed += ansb_FormClosed;
                  ansb.Show();
              }
              else
              {

                  ansb.Activate();
              }


          }

          void ansb_FormClosed(object sender, FormClosedEventArgs e)
          {
              ansb = null;
          }

          private void changeSalaryAmountToolStripMenuItem_Click(object sender, EventArgs e)
          {
               if (uasb == null)
              {
                  uasb = new UpdateASalaryBonus();
                  uasb.MdiParent = this;
                  uasb.FormClosed +=uasb_FormClosed;
                  uasb.Show();
              }
              else
              {

                  uasb.Activate();
              }


          }

                void uasb_FormClosed(object sender, FormClosedEventArgs e)
                {
                    uasb = null;
                }

           private void updateBonusAmountToolStripMenuItem_Click(object sender, EventArgs e)
              {
                  if (dasb == null)
                  {
                      dasb = new DeleteASalaryBonus();
                      dasb.MdiParent = this;
                      dasb.FormClosed += dasb_FormClosed;
                      dasb .Show();
                  }
                  else
                  {

                      dasb .Activate();
                  }

              }

           void dasb_FormClosed(object sender, FormClosedEventArgs e)
           {
               dasb = null;
           }

           private void checkAllEmployeeSalaryToolStripMenuItem_Click(object sender, EventArgs e)
           {

               toolStripProgressBar1.Visible = true;
               toolStripStatusLabel1.Text = "Loading All Payroll  Information";
               workerCheckAllPayroll.RunWorkerAsync();
           }

           void casb_FormClosed(object sender, FormClosedEventArgs e)
           {
               casb = null;
           }

           private void checkTrainingReviewToolStripMenuItem_Click(object sender, EventArgs e)
           {
               toolStripProgressBar1.Visible = true;
               toolStripStatusLabel1.Text = "Loading All Training  Information";
               workerCheckAllTraining.RunWorkerAsync();

           }
           void cata_FormClosed(object sender, FormClosedEventArgs e)
           {
               cata = null;
           }

           private void aDDMoneyOnBankAccountToolStripMenuItem_Click(object sender, EventArgs e)
           {
               if (anbi == null)
               {
                   anbi = new AddNewBankInformation();
                   anbi.MdiParent = this;
                   anbi.FormClosed += anbi_FormClosed;
                   anbi.Show();
               }
               else
               {

                   anbi.Activate();
               }
           }

           void anbi_FormClosed(object sender, FormClosedEventArgs e)
           {
               anbi = null;
           }

           private void withdrToolStripMenuItem_Click(object sender, EventArgs e)
           {
               if (amob == null)
               {
                   amob = new AddMoneyOnBank();
                   amob.MdiParent = this;
                   amob.FormClosed += amob_FormClosed;
                   amob.Show();
               }
               else
               {

                   amob.Activate();
               }
           }

           void amob_FormClosed(object sender, FormClosedEventArgs e)
           {
               amob = null;
           }

         

           private void checkAllBankMoneyInformationToolStripMenuItem_Click(object sender, EventArgs e)
           {
               if (tepabm == null)
               {
                   tepabm = new TotalEmployeePaymentAndBankMoney();
                   tepabm.MdiParent = this;
                   tepabm.FormClosed += tepabm_FormClosed;
                   tepabm .Show();
               }
               else
               {

                   tepabm .Activate();
               }
           }

           void tepabm_FormClosed(object sender, FormClosedEventArgs e)
           {
               tepabm = null;
           }

           private void checkAllBankMoneyInformationToolStripMenuItem1_Click(object sender, EventArgs e)
           {
               if (dabi == null)
               {
                   dabi = new DeleteABankInformation();
                   dabi.MdiParent = this;
                   dabi.FormClosed += dabi_FormClosed;
                   dabi.Show();

               }
               else
               {
                   dabi.Activate();
               }
           }

           void dabi_FormClosed(object sender, FormClosedEventArgs e)
           {
               dabi = null;
           }

           private void checkAllBankMoneyInformationToolStripMenuItem2_Click(object sender, EventArgs e)
           {
               if (wmfb == null)
               {
                   wmfb = new WithdrawMoneyFromBank();
                   wmfb.MdiParent = this;
                   wmfb.FormClosed += wmfb_FormClosed;
                   wmfb.Show();

               }
               else
               {
                   wmfb.Activate();
               }
           }

           void wmfb_FormClosed(object sender, FormClosedEventArgs e)
           {
               wmfb = null;
           }

           private void checkAllBankMoneyInformationToolStripMenuItem3_Click(object sender, EventArgs e)
           {
               toolStripProgressBar1.Visible = true;
               toolStripStatusLabel1.Text = "Loading All BankAccount  Information";
               workerCheckAllBankAccount.RunWorkerAsync();
           }

           void cabmi_FormClosed(object sender, FormClosedEventArgs e)
           {
               cabmi = null;
           }

           private void checkAllEmployeeSToolStripMenuItem_Click(object sender, EventArgs e)
           {
               toolStripProgressBar1.Visible = true;
               toolStripStatusLabel1.Text = "Loading All Employee Payment  Information";
               workerCheckAllEpayment.RunWorkerAsync();
           }

           void caep_FormClosed(object sender, FormClosedEventArgs e)
           {
               caep = null;
           }


        }

 }

       

