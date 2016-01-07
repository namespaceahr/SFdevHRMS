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

namespace UserInterface.JobAssign
{
    public partial class CheckAllAssignJob : Form
    {
        public CheckAllAssignJob()
        {
            InitializeComponent();
        }
        public CheckAllAssignJob(List<EmployeeJobAssign> eja)
        {
            InitializeComponent();
            dataGridView1.DataSource = eja;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


       
    }
}
