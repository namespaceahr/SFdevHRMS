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
    public partial class ChangeEmployeePassword : Form
    {
        Employee p = new Employee();
        EmployeeData ed = new EmployeeData();
        public ChangeEmployeePassword(Employee s)
        {
            this.p = s;
            InitializeComponent();
        }

        private void passwordemployeesave_Click(object sender, EventArgs e)
        {
            if (changeemployeepasswordtext.Text != "")
            {
                p.employeePassword = changeemployeepasswordtext.Text;
                try
                {
                    if (ed.changePasswordEmployee(p))
                    {
                        MessageBox.Show("Password Changed Successfuly.");
                    }
                    else
                    {
                        MessageBox.Show("Password Not Changed.");
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
