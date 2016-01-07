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
    public partial class AddNewDepartment : Form
    {
        Department dept = new Department();
        DepartmentData deptd = new DepartmentData();

        public AddNewDepartment()
        {
            InitializeComponent();
        }

        private void addnewdepartmentsave_Click(object sender, EventArgs e)
        {
            if (addnewdepartmentidtext.Text != "" && addnewdepartmentnametext.Text != "")
            {
                try
                {
                    dept.departmentId = addnewdepartmentidtext.Text;
                    dept.departmentName = addnewdepartmentnametext.Text;
                    if (deptd.insertDepartment(dept))
                    {
                        MessageBox.Show("New Department Added Successfully.");
                        button1_Click(sender, e);

                    }
                    else
                    {

                        MessageBox.Show("New Department Not Added.");
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
            addnewdepartmentidtext.Text = "";
            addnewdepartmentnametext.Text = "";
        }
    }
}
