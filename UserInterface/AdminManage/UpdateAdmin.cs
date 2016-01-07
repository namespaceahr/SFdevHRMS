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
    public partial class UpdateAdmin : Form
    {
        Admin updateadmin = new Admin();
        AdminData updatedata = new AdminData();
        public UpdateAdmin()
        {
            InitializeComponent();
        }

    

        private void updateadminsave_Click(object sender, EventArgs e)
        {
            if (updateadminidcombobox.Text != "" && updateadminnametext.Text != "" && updateadminpasswordtext.Text != "")
            {
                try
                {

                    updateadmin.adminId = updateadminidcombobox.Text;
                    updateadmin.adminName = updateadminnametext.Text;
                    updateadmin.adminPassword = updateadminpasswordtext.Text;

                    if (updatedata.updateAdmin(updateadmin))
                    {
                        MessageBox.Show("Updated Admin Information");

                    }
                    else
                    {
                        MessageBox.Show("Not Saved Admin Information");

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

        private void UpdateAdmin_Load(object sender, EventArgs e)
        {
            List<object> adminid = updatedata.GetAdminIdList();
            updateadminidcombobox.DataSource = adminid;
            updateadminidcombobox_SelectedValueChanged(sender, e);
        }

        private void updateadminidcombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            string id = updateadminidcombobox.Text;
            updateadmin = updatedata.GetAdminUpdateData(id);


            updateadminnametext.Text = updateadmin.adminName;
            updateadminpasswordtext.Text = updateadmin.adminPassword;
        }
    }
}
