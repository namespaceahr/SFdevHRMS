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
    public partial class AddNewBankInformation : Form
    {
        BankAccount ba = new BankAccount();
        BankAccountData bad = new BankAccountData();
        public AddNewBankInformation()
        {
            InitializeComponent();
        }

        private void addnewbanksave_Click(object sender, EventArgs e)
        {
            if(addbankidtext.Text!="" && addbankmoneytext.Text!="")
            {
                ba.bankId = addbankidtext.Text;
                try
                {
                ba.totalmoney = int.Parse(addbankmoneytext.Text);
               
               
                    if(bad.insertBankAccount(ba))
                    {
                        MessageBox.Show("New Bank Added Successfully.");
                         button1_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("New Bank Not Added.");
                        
                    }
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Empty Input.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addbankidtext.Text = "";
            addbankmoneytext.Text = "";
        }

       
    }
}
