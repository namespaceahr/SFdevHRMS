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
    public partial class CreateNewEmployee : Form
    {
        Employee addnew = new Employee();
        EmployeeData ed = new EmployeeData();
        public CreateNewEmployee()
        {
            InitializeComponent();
        }

    

        private void AddSaveEmployee_Click(object sender, EventArgs e)
        {
            if (addemployeeidtext.Text != "" && addemployeenametext.Text != "" && addemployeepasswordtext.Text != "" && addemployeereligiontext.Text != "" && addemployeeemailtext.Text != "" && addemployeedesignationtext.Text != "")
            {
                try
                {
                    addnew.employeeId = addemployeeidtext.Text;
                    addnew.employeeName = addemployeenametext.Text;
                    addnew.employeePassword = addemployeepasswordtext.Text;
                    addnew.employeeDob = addemployeedobtext.Value;
                    addnew.employeeJoinDate = addemployeejoindatetext.Value;
                    addnew.employeeReligion = addemployeereligiontext.Text;
                    addnew.employeeEmail = addemployeeemailtext.Text;
                    addnew.employeeDesignation = addemployeedesignationtext.Text;

                    if (ed.insertEmployee(addnew))
                    {
                        MessageBox.Show(" Employee Information Saved");

                        button1_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show(" Employee Information Not  Saved");
                        button1_Click(sender, e);
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
            addemployeeidtext.Text="";
            addemployeenametext.Text="";
            addemployeepasswordtext.Text="";
            addemployeedobtext.Value=DateTime.Now;
            addemployeejoindatetext.Value=DateTime.Now;
            addemployeereligiontext.Text="";
            addemployeeemailtext.Text="";
            addemployeedesignationtext.Text="";
        }

      
    }
}
