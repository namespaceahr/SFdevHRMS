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
    public partial class WithdrawMoneyFromBank : Form
    {
        BankAccountData bad = new BankAccountData();
        BankAccount ba = new BankAccount();
        public WithdrawMoneyFromBank()
        {
            InitializeComponent();
            totalbankmoneytext.ReadOnly = true;
        }

        public WithdrawMoneyFromBank(int payment)
        {
            InitializeComponent();
            totalbankmoneytext.ReadOnly = true;
            withdrawmoneytext.Text=payment.ToString();
            withdrawmoneytext.ReadOnly = true;
        }
        private void WithdrawMoneyFromBank_Load(object sender, EventArgs e)
        {
            List<object> bidlist = bad.GetBankAccountList();
            withdrawbankidcombobox.DataSource = bidlist;
        }

        private void withdrawbankidcombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            totalbankmoneytext.Text = bad.GetBalance(withdrawbankidcombobox.Text).ToString();
            
        }

        private void addnewbanksave_Click(object sender, EventArgs e)
        {
            if (withdrawmoneytext.Text == "")
            {
                MessageBox.Show("Empty Input.");
            }
            else
            {
                if (int.Parse(withdrawmoneytext.Text) <= int.Parse(totalbankmoneytext.Text) && int.Parse(withdrawmoneytext.Text) > 0)
                {
                    try
                    {
                        ba.bankId = withdrawbankidcombobox.Text;
                        if (bad.withdrawMoney(ba, int.Parse(withdrawmoneytext.Text)))
                        {
                            if (bad.AddmoneyTotalpay(ba, int.Parse(withdrawmoneytext.Text)))
                            {
                                MessageBox.Show("Withdraw Successfully.");
                                button1_Click(sender, e);
                                WithdrawMoneyFromBank_Load(sender, e);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Withdraw Not Done.");
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Withdraw money not possible.");
                }
            }


            }

        private void button1_Click(object sender, EventArgs e)
        {
            withdrawmoneytext.Text = "";
        }
        }
    }

