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
    public partial class UpdateDepartmentInfo : Form
    {
        Department dept = new Department();
        DepartmentData deptdata = new DepartmentData();
        public UpdateDepartmentInfo()
        {
            InitializeComponent();
        }

        private void updatedepartmentidcomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            string id = updatedepartmentidcomboBox.Text;
            dept = deptdata.GetDepartmentData(id);
            updatedepartmentnametext.Text = dept.departmentName;
        }

        private void UpdateDepartmentInfo_Load(object sender, EventArgs e)
        {
            List<object> deptidlist = deptdata.GetDepartmentIDList();
            updatedepartmentidcomboBox.DataSource = deptidlist;
            updatedepartmentidcomboBox_SelectedValueChanged(sender, e);
        }

        private void updatedepartmentsave_Click(object sender, EventArgs e)
        {
            if (updatedepartmentnametext.Text != "")
            {
                try
                {
                    dept.departmentId = updatedepartmentidcomboBox.Text;
                    dept.departmentName = updatedepartmentnametext.Text;
                    if (deptdata.updateDepartment(dept))
                    {

                        MessageBox.Show("Department Update Successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Department Not Update.");
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

