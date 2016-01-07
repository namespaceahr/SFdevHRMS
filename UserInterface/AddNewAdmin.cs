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
    public partial class AddNewAdmin : Form
    {
        public AddNewAdmin()
        {
            InitializeComponent();
        }

        private void admininsertclear_Click(object sender, EventArgs e)
        {
            admininsertid.Text = "";
            admininsertname.Text = "";
            admininsertpassword.Text = "";
        }
    }
}
