using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using DataLayer;

namespace UserInterface
{
    public partial class adminlogin : UserControl
    {
        Admin admin = new Admin();
        
        AdminLogin adlogin = new AdminLogin();
        public adminlogin()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            admin.adminId = adminid.Text;
            admin.adminPassword = adminpassword.Text;

            try
            {

                if (adlogin.AdminValid(admin))
                {
                    AdminManage.AdminMain am = new AdminManage.AdminMain(admin);
                    am.Show();
                    this.Parent.Parent.Visible = false;


                }
                else
                {

                    MessageBox.Show(" Wrong Credentials");
                }

            }

            catch(Exception exc)
            {

                MessageBox.Show("Error "+exc.Message);
            }
            }
                
               
            
          
        

        private void adminpassword_TextChanged(object sender, EventArgs e)
        {
            adminpassword.PasswordChar = '.';
        }

        public void Logout()
        {
            
            this.Parent.Parent.Visible = true;
        }

        private void adminid_TextChanged(object sender, EventArgs e)
        {

        }

        

      

    }
}
