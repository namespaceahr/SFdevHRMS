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

namespace UserInterface.EmployeeJobInformation
{
    public partial class CheckAllMyJob : Form
    {
        public CheckAllMyJob()
        {
            InitializeComponent();
        }


        public CheckAllMyJob(List<EmployeeJobAssign> eja)
        {
            InitializeComponent();
            dataGridView1.DataSource = eja;

        }
    }
}
