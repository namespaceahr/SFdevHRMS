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

namespace UserInterface.DepartmentManage
{
    public partial class DeleteAnDepartmentInfo : Form
    {
        Department dept = new Department();
        DepartmentData deptdata = new DepartmentData();
        EmployeeJobAssignData ejad = new EmployeeJobAssignData();
        PayrollData pd = new PayrollData();
        public DeleteAnDepartmentInfo()
        {
            InitializeComponent();
        }

        private void deletedepartmentsave_Click(object sender, EventArgs e)
        {
            if (deletedepartmentidcomboBox.Text != "")
            {

                dept.departmentId = deletedepartmentidcomboBox.Text;
                try
                {
                    ejad.deleteDepartmentJobAssign(deletedepartmentidcomboBox.Text);

                    pd.deleteDepartmentPayroll(deletedepartmentidcomboBox.Text);

                    if (deptdata.deleteDepartment(dept))
                    {
                        MessageBox.Show("Delete Successfully.");
                        DeleteAnDepartmentInfo_Load(sender, e);

                    }
                    else
                    {
                        MessageBox.Show("Delete Successfully.");
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

        private void DeleteAnDepartmentInfo_Load(object sender, EventArgs e)
        {
            List<object> deptidlist = deptdata.GetDepartmentIDList();
            deletedepartmentidcomboBox.DataSource = deptidlist;
        }
    }
}
