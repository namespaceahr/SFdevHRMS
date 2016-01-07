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

namespace UserInterface.AdminManage
{
    public partial class DeleteAnAdmin : Form
    {
        Admin deleteadmininformation = new Admin();
        AdminData ad = new AdminData();

        public DeleteAnAdmin()
        {
            InitializeComponent();
        }


        private void deleteadmin_Click_1(object sender, EventArgs e)
        {
            deleteadmininformation.adminId = deleteadminidcomboBox.Text;
            if (deleteadminidcomboBox.Text != "")
            {
                new EmployeeJobAssignData().deleteFromJobAssign(deleteadminidcomboBox.Text);
                new PerformanceData().deleteFromPerformance(deleteadminidcomboBox.Text);
                try
                {
                    if (ad.deleteAdmin(deleteadmininformation))
                    {
                        MessageBox.Show("Successfully Delete ");
                        DeleteAnAdmin_Load(sender, e);
                    }

                    else
                    {
                        MessageBox.Show("Not Delete ");

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

        private void DeleteAnAdmin_Load(object sender, EventArgs e)
        {
            List<object> adminid = ad.GetAdminIdList();
            deleteadminidcomboBox.DataSource = adminid;
        }
    }
}
