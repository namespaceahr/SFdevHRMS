using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class UpdateAdmin : Form
    {
        public UpdateAdmin()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            updateadminidtextbox.Text = "";
            updateadminnametextbox.Text = "";
            updateadminpasswordtextbox.Text = "";

        }
    }
}
