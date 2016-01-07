using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.BankManage
{
    public partial class CheckAllEmployeesPayment : Form
    {
        public CheckAllEmployeesPayment(List<object> ob)
        {
            InitializeComponent();
            dataGridView1.DataSource = ob;
        }
    }
}
