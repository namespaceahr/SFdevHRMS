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
    public partial class AddNewSalaryBonus : Form
    {
        
        PayrollData pd = new PayrollData();
        Payroll p = new Payroll();
        public AddNewSalaryBonus()
        {
            InitializeComponent();
        }

        private void AddNewSalaryBonus_Load(object sender, EventArgs e)
        {
            List<object> employeeidjoblist = pd.GetEmployeeListFromJobAssign();
            payrolladdemployeeidcomboBox.DataSource = employeeidjoblist;
            payrolladdemployeeidcomboBox_SelectedValueChanged(sender, e);
           
            
       }

        private void payrolladdemployeeidcomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            payrolladddepartmentidcomboBox.Text = "";
           List<object> deptlist =pd.GetDeptidfromjobAssign(payrolladdemployeeidcomboBox.Text);
           payrolladddepartmentidcomboBox.DataSource = deptlist;


        }

        private void payrolladdsave_Click(object sender, EventArgs e)
        {
            if (payrolladdsalaryamounttext.Text == "" && payrolladdbonusamounttext.Text == "")
            {
                MessageBox.Show("Empty Input.");
            }
            else
            {
                if (int.Parse(payrolladdsalaryamounttext.Text) > 0 && int.Parse(payrolladdbonusamounttext.Text) > 0)
                {
                    try
                    {
                        p.employeeId = payrolladdemployeeidcomboBox.Text;
                        p.SalaryAmount = int.Parse(payrolladdsalaryamounttext.Text);
                        p.bonusAmount = int.Parse(payrolladdbonusamounttext.Text);
                        p.departmentId = payrolladddepartmentidcomboBox.Text;

                        if (pd.insertPayroll(p))
                        {

                            MessageBox.Show("Payroll Added Successfully.");
                            button1_Click(sender, e);
                            AddNewSalaryBonus_Load(sender, e);

                        }
                        else
                        {
                            MessageBox.Show("Payroll Not Added.");
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

        private void button1_Click(object sender, EventArgs e)
        {
            payrolladdsalaryamounttext.Text = "";
            payrolladdbonusamounttext.Text = "";
        }

       

    }
}
