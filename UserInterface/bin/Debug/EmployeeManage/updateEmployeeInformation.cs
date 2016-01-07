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
    public partial class updateEmployeeInformation : Form
    {
        Employee upe = new Employee();
        EmployeeData ed = new EmployeeData();
        public updateEmployeeInformation()
        {
            InitializeComponent();
        }

     
        private void updateemployeesave_Click(object sender, EventArgs e)
        {
            if (updateemployeenametext.Text != "" && updateemployeenametext.Text != "" && updateemployeepasswordtext.Text != "" && updateemployeereligiontext.Text != "")
            {
                try
                {
                    upe.employeeId = updateemployeeidcomboBox.Text;
                    upe.employeeName = updateemployeenametext.Text;
                    upe.employeePassword = updateemployeepasswordtext.Text;
                    upe.employeeDob = updateemployeedobtext.Value;
                    upe.employeeJoinDate = updateemployeejoindatetext.Value;
                    upe.employeeReligion = updateemployeereligiontext.Text;
                    upe.employeeEmail = updateemployeeemailtext.Text;
                    upe.employeeDesignation = updateemployeedesignnationtext.Text;
                    if (ed.updateEmployee(upe))
                    {

                        MessageBox.Show(" Employee Information Updated");

                    }
                    else
                    {
                        MessageBox.Show(" Employee Not Found");

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

        

        private void updateEmployeeInformation_Load(object sender, EventArgs e)
        {
            List<object> employeeid = ed.GetEmployeeIdList();
           updateemployeeidcomboBox.DataSource = employeeid;

           updateemployeeidcomboBox_SelectedValueChanged(sender, e);
        }

   

        private void updateemployeeidcomboBox_SelectedValueChanged(object sender, EventArgs e)
        {

            string id = updateemployeeidcomboBox.Text;


             upe = ed.GetEmployeeData(id);

            updateemployeenametext.Text = upe.employeeName;
            updateemployeepasswordtext.Text = upe.employeePassword;
            updateemployeedobtext.Value = upe.employeeDob;
            updateemployeejoindatetext.Value = upe.employeeJoinDate;
            updateemployeereligiontext.Text = upe.employeeReligion;
            updateemployeeemailtext.Text = upe.employeeEmail;
            updateemployeedesignnationtext.Text = upe.employeeDesignation;
            
        }
    }
}
