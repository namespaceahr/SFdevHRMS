using Entities;
using Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class BankAccountData
    {

        DataAccess da = new DataAccess();
        public bool insertBankAccount(BankAccount obj)
        {
            string insertCommand = "INSERT INTO bankaccount(BankId,TotalMoney) " +
                                   " VALUES (@BankId,@TotalMoney) ";

            SqlCommand command = new SqlCommand(insertCommand);

            SqlParameter bankIdParameter = new SqlParameter("@BankId", SqlDbType.NVarChar,50);
            bankIdParameter.Value = obj.bankId;

            SqlParameter TotalMoneyParameter = new SqlParameter("@TotalMoney", SqlDbType.Int);
            TotalMoneyParameter.Value = obj.totalmoney;







            command.Parameters.Add(bankIdParameter);
            command.Parameters.Add(TotalMoneyParameter);
          






            if (da.Execution(command))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool deleteBankAccount(BankAccount obj)
        {
            string insertCommand = "delete from bankaccount  " +
                                   "where bankid= @bankid ";
            SqlCommand command = new SqlCommand(insertCommand);
            SqlParameter idParameter = new SqlParameter("@bankid", SqlDbType.NVarChar, 50);
            idParameter.Value = obj.bankId;


            command.Parameters.Add(idParameter);

            if (da.Execution(command))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool addBankAccountMoney(BankAccount obj,int addmoney)
        {
            string insertCommand = "update bankaccount set totalmoney= (select sum(totalmoney+'" + addmoney + "') from bankaccount where bankid= @BankId)  where bankid= @BankId";

            SqlCommand command = new SqlCommand(insertCommand);

            SqlParameter bankIdParameter = new SqlParameter("@BankId", SqlDbType.NVarChar, 50);
            bankIdParameter.Value = obj.bankId;

          command.Parameters.Add(bankIdParameter);
          
            if (da.Execution(command))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool withdrawMoney(BankAccount obj, int addmoney)
        {
            string insertCommand = "update bankaccount set totalmoney= (select sum(totalmoney-'" + addmoney + "') from bankaccount where bankid= @BankId)  where bankid= @BankId";

            SqlCommand command = new SqlCommand(insertCommand);

            SqlParameter bankIdParameter = new SqlParameter("@BankId", SqlDbType.NVarChar, 50);
            bankIdParameter.Value = obj.bankId;

            command.Parameters.Add(bankIdParameter);

            if (da.Execution(command))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool AddmoneyTotalpay(BankAccount obj, int addmoney)
        {
            string insertCommand = "update bankaccount set TotalPay= (select sum(TotalPay+'" + addmoney + "') from bankaccount where bankid= @BankId)  where bankid= @BankId";

            SqlCommand command = new SqlCommand(insertCommand);

            SqlParameter bankIdParameter = new SqlParameter("@BankId", SqlDbType.NVarChar, 50);
            bankIdParameter.Value = obj.bankId;

            command.Parameters.Add(bankIdParameter);

            if (da.Execution(command))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void insertEmployeePayment(int money,DateTime d)
        {
            string insertCommand = "INSERT INTO employeepayment (PayTime,EmployeeTotalSalary) " +
                                   " VALUES (@PayTime,@EmployeeTotalSalary) ";

            SqlCommand command = new SqlCommand(insertCommand);
            SqlParameter timeParameter = new SqlParameter("@PayTime", SqlDbType.DateTime);
            timeParameter.Value = d;
            SqlParameter payParameter = new SqlParameter("@EmployeeTotalSalary", SqlDbType.Int);
            payParameter.Value = money;

            command.Parameters.Add(timeParameter);
            command.Parameters.Add(payParameter);
             da.Execution(command);
           
        }


        public int GetTotalEmplyeeSalary()
        {
            int result=0;
              string query = "select sum(SalaryAmount+BonusAmount) from payroll";
            SqlCommand cmd = da.GetCommand(query);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {


               result=reader.GetInt32(0);
            }
            return result;

        }

        public int GetTotalBankBalance()
        {
            int result = 0;
            string query = "select sum(TotalMoney) from bankaccount";
            SqlCommand cmd = da.GetCommand(query);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {


                result = reader.GetInt32(0);
            }
            return result;

        }
        public List<BankAccount> GetBankAccountInformation()
        {
            List<BankAccount> bList = new List<BankAccount>();

            string query = "select  BankId,TotalMoney,TotalPay from bankaccount";
            SqlCommand cmd = da.GetCommand(query);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                BankAccount ba = new BankAccount();
                ba.bankId = reader.GetString(0);
                ba.totalmoney = reader.GetInt32(1);
                ba.totalpay = reader.GetInt32(2);


                bList.Add(ba);
            }
            return bList;
        }

        public List<object> GetEmployeePaymentHistory()
        {
            List<object> bList = new List<object>();

            string query = "select  PayTime,EmployeeTotalSalary  from employeepayment";
            SqlCommand cmd = da.GetCommand(query);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                object obj = new { Payment_Time =reader.GetDateTime(0),TotalPayment =reader.GetInt32(1) };


                bList.Add(obj);
            }
            return bList;
        }

        public List<object> GetBankAccountList()
        {
            List<object> bankidList = new List<object>();
            string query = "select bankId from bankaccount";
            SqlCommand cmd = da.GetCommand(query);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {


                bankidList.Add(reader.GetString(0));
            }
            return bankidList;
        }

        public int GetBalance(string bankid)
        {
            int result = 0;
            string query = "select TotalMoney from bankaccount where bankid='"+ bankid +"' ";
            SqlCommand cmd = da.GetCommand(query);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {


                result=reader.GetInt32(0);
            }
            return result;
        }

    }
}
