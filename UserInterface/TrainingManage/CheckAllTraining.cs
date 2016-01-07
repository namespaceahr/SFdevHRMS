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
    public partial class CheckAllTraining : Form
    {
        public CheckAllTraining()
        {
            InitializeComponent();
        }

        public CheckAllTraining(List<Training> T )
        {
            InitializeComponent();
            dataGridView1.DataSource = T;
        }
    }
}
