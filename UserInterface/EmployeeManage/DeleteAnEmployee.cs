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

namespace UserInterface.EmployeeManage
{
    public partial class DeleteAnEmployee : Form
    {
        Employee de = new Employee();
        EmployeeData ed = new EmployeeData();
        EmployeeJobAssignData ejad=new EmployeeJobAssignData();
        PerformanceData pd = new PerformanceData();
        TrainingData td = new TrainingData();
        PayrollData p = new PayrollData();

        public DeleteAnEmployee()
        {
            InitializeComponent();
        }

        private void deleteadmin_Click(object sender, EventArgs e)
        {
            if (deleteemployeeidcomboBox.Text != "")
            {
                de.employeeId = deleteemployeeidcomboBox.Text;
                try
                {
                    ejad.deleteEmployeeJobAssign(deleteemployeeidcomboBox.Text);
                    pd.deleteEmployeePerformance(deleteemployeeidcomboBox.Text);
                    td.deleteEmployeeTraining(deleteemployeeidcomboBox.Text);
                    p.deleteEmployeePayroll(deleteemployeeidcomboBox.Text);

                    if (ed.deleteEmployee(de))
                    {
                        MessageBox.Show("Delete SuccessFully");
                        DeleteAnEmployee_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Employee ID not Found");
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

        private void DeleteAnEmployee_Load(object sender, EventArgs e)
        {
            List<object> employeeid = ed.GetEmployeeIdList();
            deleteemployeeidcomboBox.DataSource = employeeid;
        }

       
    }
}
