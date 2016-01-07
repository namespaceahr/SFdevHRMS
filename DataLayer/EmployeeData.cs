using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.SqlClient;
using System.Data;
using Framework;

namespace DataLayer
{
   public class EmployeeData
    {
       DataAccess da = new DataAccess();
       public bool insertEmployee(Employee obj)
       {
           string insertCommand = "INSERT INTO employee (EmployeeId,EmployeeName,EmployeePassword,EmployeeDob,EmployeeJoinDate,EmployeeReligion,EmployeeEmail,EmployeeDesignation) " +
                                  "VALUES (@EmployeeId,@EmployeeName,@EmployeePassword,@EmployeeDob,@EmployeeJoinDate,@EmployeeReligion,@EmployeeEmail,@EmployeeDesignation)";
           SqlCommand command = new SqlCommand(insertCommand);
           SqlParameter idParameter = new SqlParameter("@EmployeeId", SqlDbType.NVarChar, 50);
           idParameter.Value = obj.employeeId;
           SqlParameter nameParameter = new SqlParameter("@EmployeeName", SqlDbType.NVarChar, 50);
           nameParameter.Value = obj.employeeName;
           SqlParameter passwordParameter = new SqlParameter("@EmployeePassword", SqlDbType.NVarChar, 50);
           passwordParameter.Value = obj.employeePassword;
           SqlParameter dobParameter = new SqlParameter("@EmployeeDob", SqlDbType.Date);
           dobParameter.Value = obj.employeeDob;
           SqlParameter joindateParameter = new SqlParameter("@EmployeeJoinDate", SqlDbType.Date);
           joindateParameter.Value = obj.employeeJoinDate;
           SqlParameter religionParameter = new SqlParameter("@EmployeeReligion", SqlDbType.NVarChar, 50);
           religionParameter.Value = obj.employeeReligion;
            SqlParameter emailParameter = new SqlParameter("@EmployeeEmail", SqlDbType.NVarChar, 50);
            emailParameter.Value = obj.employeeEmail;
            SqlParameter designationParameter = new SqlParameter("@EmployeeDesignation", SqlDbType.NVarChar, 50);
            designationParameter.Value = obj.employeeDesignation;






           command.Parameters.Add(idParameter);
           command.Parameters.Add(nameParameter);
           command.Parameters.Add(passwordParameter);
           command.Parameters.Add(dobParameter);
           command.Parameters.Add(joindateParameter);
           command.Parameters.Add(religionParameter);
           command.Parameters.Add(emailParameter);
           command.Parameters.Add(designationParameter);



           if (da.Execution(command))
           {
               return true;
           }
           else
           {
               return false;
           }
       }

       public bool updateEmployee(Employee obj)
       {
           string insertCommand = "update employee set EmployeeName = @EmployeeName,EmployeePassword = @EmployeePassword,EmployeeDob = @EmployeeDob,EmployeeJoinDate = @EmployeeJoinDate,EmployeeReligion = @EmployeeReligion,EmployeeEmail = @EmployeeEmail,EmployeeDesignation = @EmployeeDesignation" +
                                  "  where  EmployeeId= @EmployeeId";
           SqlCommand command = new SqlCommand(insertCommand);
           SqlParameter idParameter = new SqlParameter("@EmployeeId", SqlDbType.NVarChar, 50);
           idParameter.Value = obj.employeeId;
           SqlParameter nameParameter = new SqlParameter("@EmployeeName", SqlDbType.NVarChar, 50);
           nameParameter.Value = obj.employeeName;
           SqlParameter passwordParameter = new SqlParameter("@EmployeePassword", SqlDbType.NVarChar, 50);
           passwordParameter.Value = obj.employeePassword;
           SqlParameter dobParameter = new SqlParameter("@EmployeeDob", SqlDbType.Date);
           dobParameter.Value = obj.employeeDob;
           SqlParameter joindateParameter = new SqlParameter("@EmployeeJoinDate", SqlDbType.Date);
           joindateParameter.Value = obj.employeeJoinDate;
           SqlParameter religionParameter = new SqlParameter("@EmployeeReligion", SqlDbType.NVarChar, 50);
           religionParameter.Value = obj.employeeReligion;
           SqlParameter emailParameter = new SqlParameter("@EmployeeEmail", SqlDbType.NVarChar, 50);
           emailParameter.Value = obj.employeeEmail;
           SqlParameter designationParameter = new SqlParameter("@EmployeeDesignation", SqlDbType.NVarChar, 50);
           designationParameter.Value = obj.employeeDesignation;






           command.Parameters.Add(idParameter);
           command.Parameters.Add(nameParameter);
           command.Parameters.Add(passwordParameter);
           command.Parameters.Add(dobParameter);
           command.Parameters.Add(joindateParameter);
           command.Parameters.Add(religionParameter);
           command.Parameters.Add(emailParameter);
           command.Parameters.Add(designationParameter);



           if (da.Execution(command))
           {
               return true;
           }
           else
           {
               return false;
           }
       }


       public List<object> GetEmployeeList()
       {
           List<object> employeeList = new List<object>();
           string query = "select EmployeeId,EmployeeName,EmployeeDob,EmployeeJoinDate,EmployeeReligion,EmployeeEmail,EmployeeDesignation from employee";
           SqlCommand cmd = da.GetCommand(query);
           cmd.Connection.Open();
           SqlDataReader reader = cmd.ExecuteReader();

           while (reader.Read())
           {
               object obj = new { Id = reader.GetString(0), Name = reader.GetString(1), DateOfBirth = reader.GetDateTime(2), JoinDate = reader.GetDateTime(3), Religion = reader.GetString(4), Email = reader.GetString(5),Designation=reader.GetString(6) };

               employeeList.Add(obj);
           }
           return employeeList;
       }


       public List<object> GetEmployeeIdList()
       {
           List<object> employeeidList = new List<object>();
           string query = "select employeeId from employee";
           SqlCommand cmd = da.GetCommand(query);
           cmd.Connection.Open();
           SqlDataReader reader = cmd.ExecuteReader();

           while (reader.Read())
           {


               employeeidList.Add(reader.GetString(0));
           }
           return employeeidList;
       }



       public bool deleteEmployee(Employee obj)
       {
           string insertCommand = "delete from employee  " +
                                  "where EmployeeId= @EmployeeId ";
           SqlCommand command = new SqlCommand(insertCommand);
           SqlParameter employeeIdParameter = new SqlParameter("@EmployeeId", SqlDbType.NVarChar, 50);
           employeeIdParameter.Value = obj.employeeId;


           command.Parameters.Add(employeeIdParameter);

           if (da.Execution(command))
           {
               return true;
           }
           else
           {
               return false;
           }

       }

       public Employee GetEmployeeData(string id)
       {
           Employee emp = new Employee();
           string query = "select EmployeeName,EmployeePassword,EmployeeDob,EmployeeJoinDate,EmployeeReligion,EmployeeEmail,EmployeeDesignation from employee where EmployeeId = '" + id + "'";          
           SqlCommand cmd = da.GetCommand(query);
           cmd.Connection.Open();
           SqlDataReader reader = cmd.ExecuteReader();

           if (reader.Read())
           {
               emp.employeeName = reader.GetString(0);
               emp.employeePassword = reader.GetString(1);
               emp.employeeDob = reader.GetDateTime(2);
               emp.employeeJoinDate = reader.GetDateTime(3);
               emp.employeeReligion = reader.GetString(4);
               emp.employeeEmail = reader.GetString(5);
               emp.employeeDesignation = reader.GetString(6);

               
           }
           return emp;
       }

       public bool changePasswordEmployee(Employee obj)
       {
           string insertCommand = "update employee set EmployeePassword= @EmployeePassword " +
                                  " where EmployeeId= @EmployeeId ";
           SqlCommand command = new SqlCommand(insertCommand);
           SqlParameter employeeIdParameter = new SqlParameter("@EmployeeId", SqlDbType.NVarChar, 50);
           employeeIdParameter.Value = obj.employeeId;
           SqlParameter passwordParameter = new SqlParameter("@EmployeePassword", SqlDbType.NVarChar, 50);
           passwordParameter.Value = obj.employeePassword;


           command.Parameters.Add(employeeIdParameter);
           command.Parameters.Add(passwordParameter);

           if (da.Execution(command))
           {
               return true;
           }
           else
           {
               return false;
           }

       }
    }
}
