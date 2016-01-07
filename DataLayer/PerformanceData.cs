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
   public class PerformanceData
    {
       DataAccess da = new DataAccess();

       public bool insertPerformance(Performance obj)
       {
           string insertCommand = "INSERT INTO performance (EmployeeId,performanceId,ReviewComment,ReviewDate,ReviewByAdminId) " +
                                  "VALUES (@EmployeeId,@performanceId,@ReviewComment,@ReviewDate,@ReviewByAdminId)";
           SqlCommand command = new SqlCommand(insertCommand);
           SqlParameter idParameter = new SqlParameter("@EmployeeId", SqlDbType.NVarChar, 50);
           idParameter.Value = obj.employeeId;
           SqlParameter performanceidParameter = new SqlParameter("@performanceId", SqlDbType.NVarChar, 50);
           performanceidParameter.Value = obj.PerformanceId;
           SqlParameter ReviewCommentParameter = new SqlParameter("@ReviewComment", SqlDbType.NVarChar, 50);
           ReviewCommentParameter.Value = obj.reviewComment;
           SqlParameter ReviewDateParameter = new SqlParameter("@ReviewDate", SqlDbType.Date);
           ReviewDateParameter.Value = obj.reviewDate;

           SqlParameter ReviewByAdminIdParameter = new SqlParameter("@ReviewByAdminId", SqlDbType.NVarChar, 50);
           ReviewByAdminIdParameter.Value = obj.reviewByAdmin;
          






           command.Parameters.Add(idParameter);
           command.Parameters.Add(performanceidParameter);
           command.Parameters.Add(ReviewCommentParameter);
           command.Parameters.Add(ReviewDateParameter);
           command.Parameters.Add(ReviewByAdminIdParameter);
         


           if (da.Execution(command))
           {
               return true;
           }
           else
           {
               return false;
           }
       }

       public void deleteEmployeePerformance(string employeeId)
       {


           string insertCommand = "delete from performance where employeeId='" + employeeId + "'";
           SqlCommand command = new SqlCommand(insertCommand);
           da.Execution(command);

       }


       public bool updatePerformance(Performance obj)
       {
           string insertCommand = "update performance set ReviewComment=@ReviewComment,ReviewDate=@ReviewDate,ReviewByAdminId=@ReviewByAdminId " +
                                  " where employeeId=@EmployeeId and performanceId=@performanceId";
           SqlCommand command = new SqlCommand(insertCommand);
           SqlParameter idParameter = new SqlParameter("@EmployeeId", SqlDbType.NVarChar, 50);
           idParameter.Value = obj.employeeId;
           SqlParameter performanceidParameter = new SqlParameter("@performanceId", SqlDbType.NVarChar, 50);
           performanceidParameter.Value = obj.PerformanceId;
           SqlParameter ReviewCommentParameter = new SqlParameter("@ReviewComment", SqlDbType.NVarChar, 50);
           @ReviewCommentParameter.Value = obj.reviewComment;
           SqlParameter ReviewDateParameter = new SqlParameter("@ReviewDate", SqlDbType.Date);
           @ReviewDateParameter.Value = obj.reviewDate;

           SqlParameter ReviewByAdminIdParameter = new SqlParameter("@ReviewByAdminId", SqlDbType.NVarChar, 50);
           ReviewByAdminIdParameter.Value = obj.reviewByAdmin;







           command.Parameters.Add(idParameter);
           command.Parameters.Add(performanceidParameter);
           command.Parameters.Add(ReviewCommentParameter);
           command.Parameters.Add(ReviewDateParameter);
           command.Parameters.Add(ReviewByAdminIdParameter);



           if (da.Execution(command))
           {
               return true;
           }
           else
           {
               return false;
           }
       }

       public bool deletePerformance(Performance obj)
       {
           string insertCommand = "delete from performance " +
                                  " where EmployeeId=@EmployeeId and performanceId=@performanceId ";
           SqlCommand command = new SqlCommand(insertCommand);
           SqlParameter employeeIdParameter = new SqlParameter("@EmployeeId", SqlDbType.NVarChar, 50);
           employeeIdParameter.Value = obj.employeeId;
           SqlParameter performanceIdParameter = new SqlParameter("@performanceId", SqlDbType.NVarChar, 50);
           performanceIdParameter.Value = obj.PerformanceId;


           command.Parameters.Add(employeeIdParameter);
           command.Parameters.Add(performanceIdParameter);


           if (da.Execution(command))
           {
               return true;
           }
           else
           {
               return false;
           }

       }
       public List<object> GetEmployeeIdFromPerformanceList()
       {
           List<object> employeeidList = new List<object>();
           string query = "select DISTINCT employeeId from performance";
           SqlCommand cmd = da.GetCommand(query);
           cmd.Connection.Open();
           SqlDataReader reader = cmd.ExecuteReader();

           while (reader.Read())
           {


               employeeidList.Add(reader.GetString(0));
           }
           return employeeidList;
       }



       public List<object> GetPerformanceIdFromPerformanceList(string empid)
       {
           List<object> PerformanceidList = new List<object>();
           string query = "select performanceId from performance where employeeId='" + empid + "'";
           SqlCommand cmd = da.GetCommand(query);
           cmd.Connection.Open();
           SqlDataReader reader = cmd.ExecuteReader();

           while (reader.Read())
           {


               PerformanceidList.Add(reader.GetString(0));
           }
           return PerformanceidList;
       }

       public Performance GetPerformance(string perid)
       {
           Performance p = new Performance();
           string query = "select ReviewComment,ReviewDate from performance where performanceId= '" + perid + "'";
           SqlCommand cmd = da.GetCommand(query);
           cmd.Connection.Open();
           SqlDataReader reader = cmd.ExecuteReader();

           while (reader.Read())
           {

               p.reviewComment = reader.GetString(0);
               p.reviewDate = reader.GetDateTime(1);


           }
           return p;
       }

       public List<Performance> GetPerformanceList()
       {
           List<Performance> performanceList = new List<Performance>();

           string query = "select EmployeeId,performanceId,ReviewComment,ReviewDate,ReviewByAdminId from performance";
           SqlCommand cmd = da.GetCommand(query);
           cmd.Connection.Open();
           SqlDataReader reader = cmd.ExecuteReader();

           while (reader.Read())
           {
               Performance ej = new Performance();

               ej.employeeId = reader.GetString(0);
               ej.PerformanceId = reader.GetString(1);
               ej.reviewComment = reader.GetString(2);
               ej.reviewDate = reader.GetDateTime(3);
               ej.reviewByAdmin = reader.GetString(4);
              

               performanceList.Add(ej);
           }
           return performanceList;
       }

       public void deleteFromPerformance(string adminid)
       {


           string insertCommand = "delete from performance where ReviewByAdminId='" + adminid + "'";
           SqlCommand command = new SqlCommand(insertCommand);
           da.Execution(command);

       }




    }
}
