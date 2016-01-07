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

namespace UserInterface.PerformanceManage
{
    public partial class EvaluatePerformance : Form
    {
        EmployeeData ed = new EmployeeData();
        PerformanceData pd = new PerformanceData();
        Performance p = new Performance();
        public EvaluatePerformance(Admin obj)
        {
            InitializeComponent();
            evaluatebyadmintext.Text = obj.adminId;
            evaluatebyadmintext.ReadOnly = true;

        }

        private void EvaluatePerformance_Load(object sender, EventArgs e)
        {
            List<object> employeeid = ed.GetEmployeeIdList();
            evaluateemployeeidcomboBox.DataSource = employeeid;
        }

        private void evaluateperformancesave_Click(object sender, EventArgs e)
        {
            if (evaluateperformanceidtext.Text != "" && evaluatereviewcommenttext.Text != "")
            {
                try
                {
                    p.employeeId = evaluateemployeeidcomboBox.Text;
                    p.PerformanceId = evaluateperformanceidtext.Text;
                    p.reviewComment = evaluatereviewcommenttext.Text;
                    p.reviewDate = ReviewDatetime.Value;
                    p.reviewByAdmin = evaluatebyadmintext.Text;
                    if (pd.insertPerformance(p))
                    {

                        MessageBox.Show("New Performance Added Successfully.");
                        button2_Click(sender, e);

                    }
                    else
                    {
                        MessageBox.Show("Performance Not Added.");
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

        private void button2_Click(object sender, EventArgs e)
        {
            evaluateperformanceidtext.Text = "";
            evaluatereviewcommenttext.Text = "";
            
        }
    }
}
