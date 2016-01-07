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
    public partial class UpdateATrainingInformation : Form
    {

        TrainingData td = new TrainingData();
        Employee p = new Employee();
       
        Training t = new Training();
        public UpdateATrainingInformation(Employee s)
        {
            this.p = s;
            InitializeComponent();
        }

        private void UpdateATrainingInformation_Load(object sender, EventArgs e)
        {
            List<object> tid = td.GetEmployeeTrainingId(p.employeeId);
            updatetrainingidcomboBox.DataSource = tid;
        }

        private void updatetrainingidcomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            t = td.GetEmployeeTraininginfo(int.Parse(updatetrainingidcomboBox.Text));
            updatetrainingtopictext.Text = t.topic;
            updatetrainingreviewtext.Text = t.reviewTraining;

        }

        private void addtrainingsave_Click(object sender, EventArgs e)
        {

            if (updatetrainingtopictext.Text != "" && updatetrainingreviewtext.Text != "")
            {
                t.employeeId = p.employeeId;
                t.trainingId = int.Parse(updatetrainingidcomboBox.Text);
                t.topic = updatetrainingtopictext.Text;
                t.reviewTraining = updatetrainingreviewtext.Text;

                try
                {
                    if (td.updateTraining(t))
                    {
                        MessageBox.Show("Training Updated Successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Training Not Updated.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Empty Input.");
            }

        }
    }
}
