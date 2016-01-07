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
    public partial class UpdateASalaryBonus : Form
    {
        PayrollData pd = new PayrollData();
        Payroll p = new Payroll();
        public UpdateASalaryBonus()
        {
            InitializeComponent();
        }

        private void UpdateASalaryBonus_Load(object sender, EventArgs e)
        {
            List<object> employeeidjoblist = pd.GetEmployeeIdFromPayroll();
            payrollupdateemployeeidcomboBox.DataSource = employeeidjoblist;
            payrollupdateemployeeidcomboBox_SelectedValueChanged(sender, e);
        }

        private void payrollupdateemployeeidcomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            List<object> didjoblist = pd.GetDeptIdFromPayroll(payrollupdateemployeeidcomboBox.Text);

            payrollupdatedepartmentidcomboBox.DataSource = didjoblist;
            payrollupdatedepartmentidcomboBox_SelectedValueChanged(sender, e);

        }

        private void payrollupdatedepartmentidcomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
           Payroll pay=pd.GetAllPayroll(payrollupdateemployeeidcomboBox.Text, payrollupdatedepartmentidcomboBox.Text);
           
           payrollupdatesalaryamounttext.Text = pay.SalaryAmount.ToString();
           payrollupdatebonusamounttext.Text = pay.bonusAmount.ToString();
           
        }

        private void payrollupdatesave_Click(object sender, EventArgs e)
        {
            if (int.Parse(payrollupdatesalaryamounttext.Text) > 0 && int.Parse(payrollupdatebonusamounttext.Text) > 0)
            {
                try
                {
                    p.employeeId = payrollupdateemployeeidcomboBox.Text;
                    p.SalaryAmount = int.Parse(payrollupdatesalaryamounttext.Text);
                    p.bonusAmount = int.Parse(payrollupdatebonusamounttext.Text);
                    p.departmentId = payrollupdatedepartmentidcomboBox.Text;
                    if (pd.updatePayroll(p))
                    {

                        MessageBox.Show("Payroll Updated Successfully.");
                        button1_Click(sender, e);

                    }
                    else
                    {
                        MessageBox.Show("Payroll Not  Updated.");
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

        private void button1_Click(object sender, EventArgs e)
        {
            payrollupdatesalaryamounttext.Text="";
            payrollupdatebonusamounttext.Text = "";
        }
    }
}
