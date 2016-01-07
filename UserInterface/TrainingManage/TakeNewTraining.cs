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
    public partial class TakeNewTraining : Form
    {
        Entities.Training t = new Entities.Training();
        Employee s = new Employee();
        TrainingData td = new TrainingData();
        public TakeNewTraining(Employee id)
        {
            this.s = id;
            InitializeComponent();
            
        }

      
         private void addtrainingsave_Click_1(object sender, EventArgs e)
        {
           

            if (addtrainingidtext.Text != "" && addtrainingtopictext.Text != "" && addtrainingreviewtext.Text != "")
            {
                t.trainingId = int.Parse(addtrainingidtext.Text);
                t.employeeId = s.employeeId;
                t.topic = addtrainingtopictext.Text;
                t.reviewTraining = addtrainingreviewtext.Text;
                try
                {
                    if (td.insertTraining(t))
                    {
                        MessageBox.Show("New Training Added Successfully.");
                        button1_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("New Training Not Added.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    button1_Click(sender, e);
                }
            }
             else
            {
                MessageBox.Show("Empty Input.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addtrainingidtext.Text = "";
            addtrainingtopictext.Text = "";
            addtrainingreviewtext.Text = "";
        }
    }
}
