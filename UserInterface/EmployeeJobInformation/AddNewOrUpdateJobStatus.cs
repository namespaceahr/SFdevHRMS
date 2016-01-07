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

namespace UserInterface.EmployeeJobInformation
{
    public partial class AddNewOrUpdateJobStatus : Form
    {
        EmployeeJobAssignData ejad = new EmployeeJobAssignData();
        Employee s = new Employee();
        public AddNewOrUpdateJobStatus(Employee n)
        {
            this.s = n;
            InitializeComponent();
        }

        private void AddNewOrUpdateJobStatus_Load(object sender, EventArgs e)
        {
            List<object> jobidlist = ejad.GetJobIdFromJobAssignListForEmployee(s.employeeId);
            jobstatusjobidcomboBox.DataSource = jobidlist;
            jobstatusjobidcomboBox_SelectedValueChanged(sender,e);
        }

        private void jobstatusjobidcomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            jobstatustext.Text = ejad.GetJobStatus(s.employeeId, jobstatusjobidcomboBox.Text);
        }  

        private void jobstatussave_Click(object sender, EventArgs e)
        {
            if(ejad.updateStatus(s.employeeId, jobstatusjobidcomboBox.Text,jobstatustext.Text))
            {

                MessageBox.Show("Job Status Added Successfully.");
            }
            else
            {
                MessageBox.Show("Job Status Not Added.");
            }
        }
    }
}
