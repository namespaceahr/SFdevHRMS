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

namespace UserInterface.PayrollManage
{
    public partial class DeleteASalaryBonus : Form
    {
        PayrollData pd = new PayrollData();
        Payroll p = new Payroll();
        public DeleteASalaryBonus()
        {
            InitializeComponent();
        }

        private void DeleteASalaryBonus_Load(object sender, EventArgs e)
        {
            List<object> employeeidjoblist = pd.GetEmployeeIdFromPayroll();
            payrolldeleteemployeeidcomboBox.DataSource = employeeidjoblist;
            payrolldeleteemployeeidcomboBox_SelectedValueChanged(sender, e);

        }
        private void payrolldeleteemployeeidcomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            List<object> didjoblist = pd.GetDeptIdFromPayroll(payrolldeleteemployeeidcomboBox.Text);

            payrolldeletedepartmentidcomboBox.DataSource = didjoblist;
        }

        private void payrolldelete_Click(object sender, EventArgs e)
        {
            try
            {
                p.employeeId = payrolldeleteemployeeidcomboBox.Text;
                p.departmentId = payrolldeletedepartmentidcomboBox.Text;
                if (pd.deletePayroll(p))
                {

                    MessageBox.Show("Payroll deleted Successfully.");
                    DeleteASalaryBonus_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Payroll not deleted.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
