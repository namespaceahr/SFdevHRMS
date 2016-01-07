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
    public partial class UpdateAnPerformance : Form
    {
        PerformanceData pds = new PerformanceData();
        Performance p = new Performance();
        public UpdateAnPerformance(Admin obj)
        {
            InitializeComponent();
            updateevaluatebyadmintext.Text = obj.adminId;
            updateevaluatebyadmintext.ReadOnly = true;
        }

        private void UpdateAnPerformance_Load(object sender, EventArgs e)
        {
            List<object> employeeid = pds.GetEmployeeIdFromPerformanceList();
            updateevaluateemployeeidcomboBox.DataSource = employeeid;


            updateevaluateemployeeidcomboBox_SelectedValueChanged(sender, e);


        }

      

        private void updateevaluateperformancesave_Click(object sender, EventArgs e)
        {
            if (updateevaluatereviewcommenttext.Text != "")
            {
                try
                {
                    p.employeeId = updateevaluateemployeeidcomboBox.Text;
                    p.PerformanceId = updateevaluateperformanceidcomboBox.Text;
                    p.reviewComment = updateevaluatereviewcommenttext.Text;
                    p.reviewDate = updateReviewDatetime.Value;
                    p.reviewByAdmin = updateevaluatebyadmintext.Text;
                    if (pds.updatePerformance(p))
                    {
                        MessageBox.Show("Performance updated Successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Performance Not updated.");
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

        private void updateevaluateemployeeidcomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            List<object> performanceid = pds.GetPerformanceIdFromPerformanceList(updateevaluateemployeeidcomboBox.Text);
            updateevaluateperformanceidcomboBox.DataSource = performanceid;
            updateevaluateperformanceidcomboBox_SelectedValueChanged(sender, e);
        }

        private void updateevaluateperformanceidcomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            string pid = updateevaluateperformanceidcomboBox.Text;
            p = pds.GetPerformance(pid);

            updateevaluatereviewcommenttext.Text = p.reviewComment;
            updateReviewDatetime.Value = p.reviewDate;
        }

       
    }
}
