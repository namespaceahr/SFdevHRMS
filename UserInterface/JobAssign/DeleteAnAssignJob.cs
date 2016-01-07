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
    public partial class DeleteAnAssignJob : Form
    {
        EmployeeJobAssign eja = new EmployeeJobAssign();
        EmployeeJobAssignData ejad = new EmployeeJobAssignData();
        public DeleteAnAssignJob()
        {
            InitializeComponent();
        }

        private void DeleteAnAssignJob_Load(object sender, EventArgs e)
        {

            List<object> jobId = ejad.GetJobIdFromJobAssignList();
            deleteanassignjobidcomboBox.DataSource = jobId;
        }

        private void deleteanassignjobdelete_Click(object sender, EventArgs e)
        {

            if (deleteanassignjobidcomboBox.Text != "")
            {
                try
                {
                    eja.jobId = deleteanassignjobidcomboBox.Text;


                    if (ejad.deleteJob(eja))
                    {

                        MessageBox.Show("Job deleted successfully.");
                        DeleteAnAssignJob_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Job not deleted.");
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

     
    }
}
