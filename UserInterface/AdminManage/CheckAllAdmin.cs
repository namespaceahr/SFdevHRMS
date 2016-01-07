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
    public partial class CheckAllAdmin : Form
    {
        public CheckAllAdmin()
        {
            InitializeComponent();
            
        }

      
        public CheckAllAdmin(object adminList)
        {
            InitializeComponent();
            dataGridView1.DataSource = adminList;
            
        }



     
    }
}
