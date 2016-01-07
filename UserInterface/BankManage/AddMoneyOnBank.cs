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

namespace UserInterface.BankManage
{
    public partial class AddMoneyOnBank : Form
    {
        BankAccountData bad = new BankAccountData();
        BankAccount ba = new BankAccount();
        public AddMoneyOnBank()
        {
            InitializeComponent();
        }

        private void AddMoneyOnBank_Load(object sender, EventArgs e)
        {
            List<object> bidlist = bad.GetBankAccountList();
            addmoneybankidcombobox.DataSource = bidlist;
            
        }

        private void addmoneybanksave_Click(object sender, EventArgs e)
        {

            if (addbankonmoneytext.Text == "")
            {
                MessageBox.Show("Empty Input.");
            }
            else
            {
                if (int.Parse(addbankonmoneytext.Text) > 0)
                {
                    ba.bankId = addmoneybankidcombobox.Text;
                    try
                    {
                        if (bad.addBankAccountMoney(ba, int.Parse(addbankonmoneytext.Text)))
                        {
                            MessageBox.Show("New Money Added Successfully.");
                            button1_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("New Money Not Added.");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Please Add Some Money");

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addbankonmoneytext.Text = "";
        }
    }
}
