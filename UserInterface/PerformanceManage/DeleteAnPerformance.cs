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
    public partial class DeleteAnPerformance : Form
    {
        PerformanceData pds = new PerformanceData();
        Performance p = new Performance();
        public DeleteAnPerformance()
        {
            InitializeComponent();
        }

        private void deleteevaluateemployeeidcomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            List<object> performanceid = pds.GetPerformanceIdFromPerformanceList(deleteevaluateemployeeidcomboBox.Text);
            deleteevaluateperformanceidcomboBox.DataSource = performanceid;
        }

        private void DeleteAnPerformance_Load(object sender, EventArgs e)
        {
            List<object> employeeid = pds.GetEmployeeIdFromPerformanceList();
            deleteevaluateemployeeidcomboBox.DataSource = employeeid;


            deleteevaluateemployeeidcomboBox_SelectedValueChanged(sender, e);
        }

        private void deleteevaluateperformancesave_Click(object sender, EventArgs e)
        {
            try
            {
                p.employeeId = deleteevaluateemployeeidcomboBox.Text;
                p.PerformanceId = deleteevaluateperformanceidcomboBox.Text;
                if (pds.deletePerformance(p))
                {
                    MessageBox.Show("Performance Deleted Successfully.");
                    DeleteAnPerformance_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Performance Not Deleted.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
