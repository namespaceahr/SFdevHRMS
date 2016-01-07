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

namespace UserInterface.TrainingManage
{
    public partial class DeleteATraining : Form
    {
        TrainingData td = new TrainingData();
        Employee p = new Employee();

        Training t = new Training();
        public DeleteATraining(Employee s)
        {
            this.p = s;
            InitializeComponent();
        }

        private void DeleteATraining_Load(object sender, EventArgs e)
        {
            List<object> tid = td.GetEmployeeTrainingId(p.employeeId);
            deletetrainingidcomboBox.DataSource = tid;
        }

        private void trainingdelete_Click(object sender, EventArgs e)
        {
            t.trainingId = int.Parse(deletetrainingidcomboBox.Text);
            try
            {
                if (td.deleteTraining(t))
                {
                    MessageBox.Show(" Training Deleted Successfully.");
                    deletetrainingidcomboBox.Text = "";
                    DeleteATraining_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(" Training Not Deleted.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
