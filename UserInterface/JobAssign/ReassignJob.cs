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

namespace UserInterface.JobAssign
{
    public partial class ReassignJob : Form
    {
        EmployeeJobAssignData ejad = new EmployeeJobAssignData();
        EmployeeJobAssign rajob = new EmployeeJobAssign();

        public ReassignJob(Admin obj)
        {
            InitializeComponent();
            reassignnewjobbyadminidtext.Text = obj.adminId;
            reassignnewjobbyadminidtext.ReadOnly = true;
        }

        private void reassignnewjobsave_Click(object sender, EventArgs e)
        {
            if (reassignnewjobdescriptiontext.Text != "")
            {
                try
                {
                    rajob.employeeId = reassignjobemployeeidcomboBox.Text;
                    rajob.jobId = reassignjobjobidcomboBox.Text;
                    rajob.jobDescription = reassignnewjobdescriptiontext.Text;
                    rajob.jobAssignByAdmin = reassignnewjobbyadminidtext.Text;
                    rajob.jobStartDate = reassignnewjobstartdatetext.Value;
                    rajob.jobDeadlineDate = reassignnewjobdeadlinedatetext.Value;
                    rajob.departmentId = reassinnewjobdeptnocombobox.Text;
                    if (ejad.updateJob(rajob))
                    {
                        MessageBox.Show("Job Reassign Successfully.");


                    }
                    else
                    {
                        MessageBox.Show("Job Reassign Not Complete.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Empty Input.");
            }
        }

        private void ReassignJob_Load(object sender, EventArgs e)
        {
            List<object> employeeidjoblist = ejad.GetEmployeeList();
            reassignjobemployeeidcomboBox.DataSource = employeeidjoblist;

            List<object> jobeidjoblist = ejad.GetJobIdFromJobAssignList();
            reassignjobjobidcomboBox.DataSource = jobeidjoblist;

            List<object> deptidjoblist = ejad.GetDepartNoList();
            reassinnewjobdeptnocombobox.DataSource = deptidjoblist;

            reassignjobjobidcomboBox_SelectedValueChanged(sender, e);



        }

        private void reassignjobjobidcomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            string jobid = reassignjobjobidcomboBox.Text;

            rajob = ejad.GetJobAllFromJobAssign(jobid);


            reassignjobemployeeidcomboBox.Text = rajob.employeeId;          
           reassignnewjobdescriptiontext.Text= rajob.jobDescription;
           reassignnewjobstartdatetext.Value=rajob.jobStartDate;
           reassignnewjobdeadlinedatetext.Value=rajob.jobDeadlineDate;
           reassinnewjobdeptnocombobox.Text = rajob.departmentId;
            


        }

      
    }
}
