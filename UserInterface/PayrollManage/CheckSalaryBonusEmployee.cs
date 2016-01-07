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

namespace UserInterface.PayrollManage
{
    public partial class CheckSalaryBonusEmployee : Form
    {
        public CheckSalaryBonusEmployee(List<Payroll> p)
        {
            InitializeComponent();
            dataGridView1.DataSource = p;
        }
    }
}
