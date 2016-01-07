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
   public class DepartmentData
    {
       DataAccess da = new DataAccess();
       public bool insertDepartment(Department obj)
       {
           string insertCommand = "INSERT INTO department (departmentid,departmentName) " +
                                  "VALUES (@departmentid,@departmentName)";
           SqlCommand command = new SqlCommand(insertCommand);
           SqlParameter idParameter = new SqlParameter("@departmentid", SqlDbType.NVarChar, 50);
           idParameter.Value = obj.departmentId;
           SqlParameter nameParameter = new SqlParameter("@departmentName", SqlDbType.NVarChar, 50);
           nameParameter.Value = obj.departmentName;
           

           command.Parameters.Add(idParameter);
           command.Parameters.Add(nameParameter);
         
           if (da.Execution(command))
           {
               return true;
           }
           else
           {
               return false;
           }
       }

       public bool updateDepartment(Department obj)
       {
           string insertCommand = "update department set departmentName=@departmentName " +
                                  "where departmentId=@departmentId";
           SqlCommand command = new SqlCommand(insertCommand);
           SqlParameter idParameter = new SqlParameter("@departmentid", SqlDbType.NVarChar, 50);
           idParameter.Value = obj.departmentId;
           SqlParameter nameParameter = new SqlParameter("@departmentName", SqlDbType.NVarChar, 50);
           nameParameter.Value = obj.departmentName;


           command.Parameters.Add(idParameter);
           command.Parameters.Add(nameParameter);

           if (da.Execution(command))
           {
               return true;
           }
           else
           {
               return false;
           }
       }
       public List<object> GetDepartmentIDList()
       {
           List<object> deprtmentidList = new List<object>();
           string query = "select departmentId from department";
           SqlCommand cmd = da.GetCommand(query);
           cmd.Connection.Open();
           SqlDataReader reader = cmd.ExecuteReader();

           while (reader.Read())
           {


               deprtmentidList.Add(reader.GetString(0));
           }
           return deprtmentidList;
       }
       public Department GetDepartmentData(string id)
       {
           Department dept = new Department();
           string query = "select departmentName from department where departmentId = '" + id + "'";
           SqlCommand cmd = da.GetCommand(query);
           cmd.Connection.Open();
           SqlDataReader reader = cmd.ExecuteReader();

           if (reader.Read())
           {
               dept.departmentName = reader.GetString(0);


           }
           return dept;
       }

       public bool deleteDepartment(Department obj)
       {
           string insertCommand = "delete from department  " +
                                  "where departmentId= @departmentId ";
           SqlCommand command = new SqlCommand(insertCommand);
           SqlParameter employeeIdParameter = new SqlParameter("@departmentId", SqlDbType.NVarChar, 50);
           employeeIdParameter.Value = obj.departmentId;


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
       public List<Department> GetDepartmentList()
       {
           List<Department> DepartmentList = new List<Department>();

           string query = "select departmentId,departmentName,departmentTotalEmployees,departmentTotalSalary from department";
           SqlCommand cmd = da.GetCommand(query);
           cmd.Connection.Open();
           SqlDataReader reader = cmd.ExecuteReader();

           while (reader.Read())
           {
               Department ej = new Department();
               ej.departmentId = reader.GetString(0);
               ej.departmentName = reader.GetString(1);
               ej.totalEmployee = reader.GetInt32(2);
               ej.totalSalary = reader.GetInt32(3);

               DepartmentList.Add(ej);
           }
           return DepartmentList;
       }



    }
}
