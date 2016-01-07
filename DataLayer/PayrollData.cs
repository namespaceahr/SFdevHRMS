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
    public class PayrollData
    {
        DataAccess da = new DataAccess();


        public bool insertPayroll(Payroll obj)
        {
            string insertCommand = "INSERT INTO payroll (EmployeeId,SalaryAmount,BonusAmount,departmentId) " +
                                   "VALUES (@EmployeeId,@SalaryAmount,@BonusAmount,@departmentId)";
            SqlCommand command = new SqlCommand(insertCommand);
            SqlParameter idParameter = new SqlParameter("@EmployeeId", SqlDbType.NVarChar, 50);
            idParameter.Value = obj.employeeId;
            SqlParameter SalaryAmountParameter = new SqlParameter("@SalaryAmount", SqlDbType.Int);
            SalaryAmountParameter.Value = obj.SalaryAmount;
            SqlParameter BonusAmountParameter = new SqlParameter("@BonusAmount", SqlDbType.Int);
            BonusAmountParameter.Value = obj.bonusAmount;
            SqlParameter departmentIdParameter = new SqlParameter("@departmentId", SqlDbType.NVarChar, 50);
            departmentIdParameter.Value = obj.departmentId;

         






            command.Parameters.Add(idParameter);
            command.Parameters.Add(SalaryAmountParameter);
            command.Parameters.Add(BonusAmountParameter);
            command.Parameters.Add(departmentIdParameter);
         



            if (da.Execution(command))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool updatePayroll(Payroll obj)
        {
            string insertCommand = "update payroll set SalaryAmount=@SalaryAmount,BonusAmount=@BonusAmount " +
                                   " where  EmployeeId=@EmployeeId and departmentId=@departmentId ";
            SqlCommand command = new SqlCommand(insertCommand);
            SqlParameter idParameter = new SqlParameter("@EmployeeId", SqlDbType.NVarChar, 50);
            idParameter.Value = obj.employeeId;
            SqlParameter SalaryAmountParameter = new SqlParameter("@SalaryAmount", SqlDbType.Int);
            SalaryAmountParameter.Value = obj.SalaryAmount;
            SqlParameter BonusAmountParameter = new SqlParameter("@BonusAmount", SqlDbType.Int);
            BonusAmountParameter.Value = obj.bonusAmount;
            SqlParameter departmentIdParameter = new SqlParameter("@departmentId", SqlDbType.NVarChar, 50);
            departmentIdParameter.Value = obj.departmentId;








            command.Parameters.Add(idParameter);
            command.Parameters.Add(SalaryAmountParameter);
            command.Parameters.Add(BonusAmountParameter);
            command.Parameters.Add(departmentIdParameter);




            if (da.Execution(command))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool deletePayroll(Payroll obj)
        {
            string insertCommand = "delete from payroll  " +
                                   "where EmployeeId= @EmployeeId and departmentId=@departmentId ";
            SqlCommand command = new SqlCommand(insertCommand);
            SqlParameter employeeIdParameter = new SqlParameter("@EmployeeId", SqlDbType.NVarChar, 50);
            employeeIdParameter.Value = obj.employeeId;
            SqlParameter departmentIdParameter = new SqlParameter("@departmentId", SqlDbType.NVarChar, 50);
            departmentIdParameter.Value = obj.departmentId;


            command.Parameters.Add(employeeIdParameter);
            command.Parameters.Add(departmentIdParameter);

            if (da.Execution(command))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public List<Payroll> GetAllPayrollList()
        {
            List<Payroll> payrollList = new List<Payroll>();

            string query = "select employeeId,SalaryAmount,BonusAmount,departmentId from payroll";
            SqlCommand cmd = da.GetCommand(query);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Payroll p = new Payroll();
                p.employeeId= reader.GetString(0);
                p.SalaryAmount = reader.GetInt32(1);
                p.bonusAmount = reader.GetInt32(2);
                p.departmentId = reader.GetString(3);

                payrollList.Add(p);
            }
            return payrollList;
        }

        public List<Payroll> GetAllPayrollListEmployee(string eid)
        {
            List<Payroll> payrollList = new List<Payroll>();

            string query = "select employeeId,SalaryAmount,BonusAmount,departmentId from payroll where employeeID='"+ eid +"'";
            SqlCommand cmd = da.GetCommand(query);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Payroll p = new Payroll();
                p.employeeId = reader.GetString(0);
                p.SalaryAmount = reader.GetInt32(1);
                p.bonusAmount = reader.GetInt32(2);
                p.departmentId = reader.GetString(3);

                payrollList.Add(p);
            }
            return payrollList;
        }

        public void AutoUpdateDepartmentTotalSalary()
        {
            int res = 0;
            string query = "select departmentId from department";
            SqlCommand cmd = da.GetCommand(query);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string dept = reader.GetString(0);
                if (da.CheckAutoEmployeeSalary(dept)!="")
                {
                    string insertCommand = "update department set departmentTotalSalary=( select sum(SalaryAmount+BonusAmount) from payroll where departmentId='" + reader.GetString(0) + "')" +
                                       "where departmentId='" + reader.GetString(0) + "'";
                    SqlCommand command = new SqlCommand(insertCommand);
                    da.Execution(command);

                }
                else
                {
                    string insertCommand = "update department set departmentTotalSalary=@sal" +
                                       " where departmentId='" + reader.GetString(0) + "'";
                    SqlCommand command = new SqlCommand(insertCommand);
                    SqlParameter salParameter = new SqlParameter("@sal", SqlDbType.Int);
                    salParameter.Value = res;
                    command.Parameters.Add(salParameter);
                    da.Execution(command);
                }
            }

        }

        public void deleteEmployeePayroll(string employeeId)
        {


            string insertCommand = "delete from payroll where employeeId='" + employeeId + "'";
            SqlCommand command = new SqlCommand(insertCommand);
            da.Execution(command);

        }

        public void deleteDepartmentPayroll(string departmentId)
        {


            string insertCommand = "delete from payroll where departmentId='" + departmentId + "'";
            SqlCommand command = new SqlCommand(insertCommand);
            da.Execution(command);

        }

       

        public List<object> GetEmployeeListFromJobAssign()
        {
            List<object> employeeidList = new List<object>();
            string query = "select DISTINCT employeeId from employeejobassign";
            SqlCommand cmd = da.GetCommand(query);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {


                employeeidList.Add(reader.GetString(0));
            }
            return employeeidList;
        }








        public List<object> GetDeptidfromjobAssign(string eid)
        {
            List<object> deptidList = new List<object>();
            string query = "select departmentNo from employeejobassign where employeeId= '"+ eid +"' and  departmentNo not in (select DISTINCT departmentId from payroll where employeeId='"+ eid +"') " ;
            SqlCommand cmd = da.GetCommand(query);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {


                deptidList.Add(reader.GetString(0));
            }
            return deptidList;
        }

        public List<object> GetEmployeeIdFromPayroll()
        {
            List<object> eidList = new List<object>();
            string query = "select DISTINCT employeeID from payroll";
            SqlCommand cmd = da.GetCommand(query);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {


                eidList.Add(reader.GetString(0));
            }
            return eidList;
        }


        public List<object> GetDeptIdFromPayroll(string eid)
        {
            List<object> eidList = new List<object>();
            string query = "select departmentId  from payroll where EmployeeId='" + eid + "'";
            SqlCommand cmd = da.GetCommand(query);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {


                eidList.Add(reader.GetString(0));
            }
            return eidList;
        }

        public Payroll GetAllPayroll(string eid,string did)
        {
            Payroll pn=new Payroll();
            string query = "select SalaryAmount,BonusAmount  from payroll where EmployeeId='" + eid + "' and DepartmentId='"+ did + "'";
            SqlCommand cmd = da.GetCommand(query);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                pn.SalaryAmount = reader.GetInt32(0);
                pn.bonusAmount = reader.GetInt32(1);

                
                
            }
            return pn;
        }
    }
}
