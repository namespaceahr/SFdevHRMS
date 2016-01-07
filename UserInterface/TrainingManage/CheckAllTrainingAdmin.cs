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

namespace UserInterface.TrainingManage
{
    public partial class CheckAllTrainingAdmin : Form
    {
        public CheckAllTrainingAdmin()
        {
            InitializeComponent();
        }
        public CheckAllTrainingAdmin(List<Training> t)
        {
            InitializeComponent();
            dataGridView1.DataSource = t;
        }
    }
}
