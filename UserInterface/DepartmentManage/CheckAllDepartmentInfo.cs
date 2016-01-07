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
    public partial class CheckAllDepartmentInfo : Form
    {
       
        EmployeeJobAssignData eajd = new EmployeeJobAssignData();
        PayrollData pd = new PayrollData();
        public CheckAllDepartmentInfo()
        {
            InitializeComponent();
          

        }

        public CheckAllDepartmentInfo(List<Department> eja)
        {
           
            InitializeComponent();

            eajd.AutoUpdateDepartmentTotalEmployee();
            pd.AutoUpdateDepartmentTotalSalary();
            dataGridView1.DataSource = eja;
            


        }

        public void CheckAllDepartmentInfo_Load(object sender, EventArgs e)
        {
            try
            {
                eajd.AutoUpdateDepartmentTotalEmployee();
                pd.AutoUpdateDepartmentTotalSalary();
                List<Department> dataReceived = new DepartmentData().GetDepartmentList();
                dataGridView1.DataSource = dataReceived;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
