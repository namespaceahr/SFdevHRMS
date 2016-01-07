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
    public partial class CheckAllEmployee : Form
    {
        public CheckAllEmployee()
        {
            InitializeComponent();
        }

        public CheckAllEmployee(object employeeList)
        {
            InitializeComponent();
            dataGridView1.DataSource = employeeList;
           
            
        }

    

     
    }
}
