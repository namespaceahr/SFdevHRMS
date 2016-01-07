using DataLayer;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.BankManage
{
    public partial class DeleteABankInformation : Form
    {
        BankAccountData bad = new BankAccountData();
        Entities.BankAccount ba = new Entities.BankAccount();
        public DeleteABankInformation()
        {
            InitializeComponent();
        }

        private void DeleteABankInformation_Load(object sender, EventArgs e)
        {
            List<object> bidlist = bad.GetBankAccountList();
            deletebankidcombobox.DataSource = bidlist;

        }

        private void bankdelete_Click(object sender, EventArgs e)
        {
            
            try
            {    ba.bankId=deletebankidcombobox.Text;
                if(bad.deleteBankAccount(ba))
                {
                    MessageBox.Show("Bank Account Deleted Successfully.");
                    DeleteABankInformation_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Bank Account Not Deleted.");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
