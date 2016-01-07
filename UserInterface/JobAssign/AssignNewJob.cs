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
    public partial class AssignNewJob : Form
    {
        EmployeeJobAssignData ejad = new EmployeeJobAssignData();
        EmployeeJobAssign eja = new EmployeeJobAssign();
        public AssignNewJob(Admin obj)
        {
            InitializeComponent();
            assignnewjobbyadminidtext.Text = obj.adminId;
            assignnewjobbyadminidtext.ReadOnly = true;
             
        }

        private void AssignNewJob_Load(object sender, EventArgs e)
        {
            List<object> deptno = ejad.GetDepartNoList();

            assinnewjobdeptnocombobox.DataSource = deptno;

            List<object> employeeid = ejad.GetEmployeeList();
            assignnewjobemployeeidcomboBox.DataSource = employeeid;
            
        }

        private void assignnewjobsave_Click(object sender, EventArgs e)
        {
            if (assignnewjobemployeeidcomboBox.Text != "" && assignnewjobidtext.Text != "" && assignnewjobdescriptiontext.Text != "" && assinnewjobdeptnocombobox.Text != "")
            {
                try
                {
                    eja.employeeId = assignnewjobemployeeidcomboBox.Text;
                    eja.jobId = assignnewjobidtext.Text;
                    eja.jobDescription = assignnewjobdescriptiontext.Text;
                    eja.jobAssignByAdmin = assignnewjobbyadminidtext.Text;
                    eja.jobStartDate = assignnewjobstartdatetext.Value;
                    eja.jobDeadlineDate = assignnewjobdeadlinedatetext.Value;
                    eja.departmentId = assinnewjobdeptnocombobox.Text;



                    if (ejad.insertNewJob(eja))
                    {

                        MessageBox.Show("New Job Successfully Added.");

                        button2_Click(sender, e);

                    }
                    else
                    {
                        MessageBox.Show("Not Added Job id already Exists.");
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

        private void button2_Click(object sender, EventArgs e)
        {
            
            assignnewjobidtext.Text="";
           assignnewjobdescriptiontext.Text="";
           
           assignnewjobstartdatetext.Value=DateTime.Now;
           assignnewjobdeadlinedatetext.Value = DateTime.Now;
         
        }

       
    }
}
