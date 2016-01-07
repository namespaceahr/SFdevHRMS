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
    public partial class DeleteAnAdmin : Form
    {
        public DeleteAnAdmin()
        {
            InitializeComponent();
        }

        private void deleteadminclear_Click(object sender, EventArgs e)
        {
            deleteadmintextbox.Text = "";
        }
    }
}
