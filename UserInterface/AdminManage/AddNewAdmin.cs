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
    public partial class AddNewAdmin : Form
    {
        Admin addnewadmin = new Admin();
        AdminData admind = new AdminData();
        public AddNewAdmin()
        {
            InitializeComponent();
        }

        private void buttonadmininsert_Click(object sender, EventArgs e)
        {
            if (adminidaddtext.Text != "" && adminnametext.Text != "" && adminpasswordtext.Text != "")
            {
                try
                {
                    addnewadmin.adminId = adminidaddtext.Text;
                    addnewadmin.adminName = adminnametext.Text;
                    addnewadmin.adminPassword = adminpasswordtext.Text;

                    if (admind.insertAdmin(addnewadmin))
                    {
                        MessageBox.Show("Saved Admin Information");
                        clearadminadd_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Not Saved Admin Information");
                        clearadminadd_Click(sender, e);

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

        private void clearadminadd_Click(object sender, EventArgs e)
        {
            adminidaddtext.Text = "";
            adminnametext.Text = "";
            adminpasswordtext.Text = "";


        }

    }
}
