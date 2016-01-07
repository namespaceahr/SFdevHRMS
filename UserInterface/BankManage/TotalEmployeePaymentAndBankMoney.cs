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
    public partial class TotalEmployeePaymentAndBankMoney : Form
    {
        
        BankAccountData bad = new BankAccountData();
        public TotalEmployeePaymentAndBankMoney()
        {
            InitializeComponent();
            totalemployeepaymenttext.ReadOnly = true;
            totalbankbalancetext.ReadOnly = true;
            
        }

        private void TotalEmployeePaymentAndBankMoney_Load(object sender, EventArgs e)
        {
            totalemployeepaymenttext.Text = bad.GetTotalEmplyeeSalary().ToString();
            totalbankbalancetext.Text = bad.GetTotalBankBalance().ToString();
            nbstatus.Text ="Before Pay Make Sure That Any One bank account Have :" + totalemployeepaymenttext.Text;
            Nbb.Text = "If Any One bank account Have Not This  Money Add Money";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            bad.insertEmployeePayment(int.Parse(totalemployeepaymenttext.Text), DateTime.Now);
            button1.Visible = false;
            new BankManage.WithdrawMoneyFromBank(int.Parse(totalemployeepaymenttext.Text)).Show();

            

        }
            
    }
}
