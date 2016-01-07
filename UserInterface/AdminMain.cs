using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UserInterface
{
    public partial class AdminMain : Form
    {
        AddNewAdmin ana;
        DeleteAnAdmin da;
        UpdateAdmin ua;

        public AdminMain()
        {
            InitializeComponent();
        }

        
      

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {


                 this.Close();
                new Main().Show();
                MessageBox.Show(" Logout Success");
                
            

            
        }

        private void createNewAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ana == null)
            {
                ana = new AddNewAdmin();
                ana.MdiParent = this;
                ana.FormClosed += ana_FormClosed;
                  ana.Show();
                
            }
            else
            {
                ana.Activate();
            }

        }

        void ana_FormClosed(object sender, FormClosedEventArgs e)
        {
            ana = null;
        }

        private void deleteAnAdminInfomationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(da==null)
            {
                da = new DeleteAnAdmin();
                da.MdiParent = this;
                da.FormClosed += da_FormClosed;
                da.Show();

            }
            else
            {
                da.Activate();
            }

        }

        void da_FormClosed(object sender, FormClosedEventArgs e)
        {
            da = null;
        }

        private void editAnAdminInfomationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(ua==null)
            {
                ua = new UpdateAdmin();
                ua.MdiParent = this;
                ua.FormClosed += ua_FormClosed;
                ua.Show();
            }
            else
            {

                ua.Activate();
            }


        }

        void ua_FormClosed(object sender, FormClosedEventArgs e)
        {
            ua = null;
        }

        
    }
}
