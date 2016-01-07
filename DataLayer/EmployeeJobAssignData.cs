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
    public class EmployeeJobAssignData
    {
        DataAccess da = new DataAccess();


        public List<object> GetDepartNoList()
        {
            List<object> departnoList = new List<object>();
            string query = "select departmentId from department";
            SqlCommand cmd = da.GetCommand(query);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                

                departnoList.Add(reader.GetString(0));
            }
            return departnoList;
        }



        public List<object> GetEmployeeList()
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

        public bool insertNewJob(EmployeeJobAssign obj)
        {
            string insertCommand = "INSERT INTO employeejobassign (employeeId,jobId,jobDescription,jobAssignByAdminId,jobStartDate,jobDeadlineDate,departmentNo) " +
                                   " VALUES (@employeeId,@jobId,@jobDescription,@jobAssignByAdminId,@jobStartDate,@jobDeadlineDate,@departmentNo)";
            SqlCommand command = new SqlCommand(insertCommand);
            SqlParameter idParameter = new SqlParameter("@employeeId", SqlDbType.NVarChar, 50);
            idParameter.Value = obj.employeeId;
            SqlParameter jobidParameter = new SqlParameter("@jobId", SqlDbType.NVarChar, 50);
            jobidParameter.Value = obj.jobId;
            SqlParameter jobdesParameter = new SqlParameter("@jobDescription", SqlDbType.NVarChar, 50);
            jobdesParameter.Value = obj.jobDescription;
            SqlParameter jobassignadminidParameter = new SqlParameter("@jobAssignByAdminId", SqlDbType.NVarChar, 50);
            jobassignadminidParameter.Value = obj.jobAssignByAdmin;
            SqlParameter jobstartdateParameter = new SqlParameter("@jobStartDate", SqlDbType.Date);
            jobstartdateParameter.Value = obj.jobStartDate;
            SqlParameter jobDeadlineDateParameter = new SqlParameter("@jobDeadlineDate", SqlDbType.Date);
            jobDeadlineDateParameter.Value = obj.jobDeadlineDate;
            SqlParameter departmentNoParameter = new SqlParameter("@departmentNo", SqlDbType.NVarChar, 50);
            departmentNoParameter.Value = obj.departmentId;
            
            






            command.Parameters.Add(idParameter);
            command.Parameters.Add(jobidParameter);
            command.Parameters.Add(jobdesParameter);
            command.Parameters.Add(jobassignadminidParameter);
            command.Parameters.Add(jobstartdateParameter);
            command.Parameters.Add(jobDeadlineDateParameter);
            command.Parameters.Add(departmentNoParameter);



        



            if (da.Execution(command))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AutoUpdateDepartmentTotalEmployee()
        {
            int res = 0;
            string query = "select departmentId from department";
            SqlCommand cmd = da.GetCommand(query);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                string dept = reader.GetString(0);

                if (da.CheckAutoEmployee(dept) > 0)
                {


                    string insertCommand = "update department set departmentTotalEmployees=(select  COUNT(DISTINCT employeeId) FROM employeejobassign where departmentNo='" + reader.GetString(0) + "')" +
                                       " where departmentId='" + reader.GetString(0) + "'";
                    SqlCommand command = new SqlCommand(insertCommand);
                    da.Execution(command);

                }
                else
                {
                    string insertCommand = "update department set departmentTotalEmployees=@num" +
                                       " where departmentId='" + reader.GetString(0) + "'";
                    SqlCommand command = new SqlCommand(insertCommand);
                    SqlParameter numParameter = new SqlParameter("@num", SqlDbType.Int);
                    numParameter.Value = res;
                    command.Parameters.Add(numParameter);
                    da.Execution(command);
                }
            }
          
        }

      

      
        public string GetDeptIdAfterDeleteaJob(string jobId)
        {
            string result="";
            string query = "select departmentNo from employeejobassign where jobId= '"+ jobId +"'";
            SqlCommand cmd = da.GetCommand(query);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {


               result=reader.GetString(0);
            }
            return result;
        }

      

        public bool updateJob(EmployeeJobAssign obj)
        {
            string insertCommand = "update employeejobassign set employeeId=@employeeId, jobId=@jobId,jobDescription=@jobDescription,jobAssignByAdminId=@jobAssignByAdminId,jobStartDate=@jobStartDate,jobDeadlineDate=@jobDeadlineDate,departmentNo=@departmentNo " +
                                   " where jobId=@jobId";
            SqlCommand command = new SqlCommand(insertCommand);
            SqlParameter idParameter = new SqlParameter("@employeeId", SqlDbType.NVarChar, 50);
            idParameter.Value = obj.employeeId;
            SqlParameter jobidParameter = new SqlParameter("@jobId", SqlDbType.NVarChar, 50);
            jobidParameter.Value = obj.jobId;
            SqlParameter jobdesParameter = new SqlParameter("@jobDescription", SqlDbType.NVarChar, 50);
            jobdesParameter.Value = obj.jobDescription;
            SqlParameter jobassignadminidParameter = new SqlParameter("@jobAssignByAdminId", SqlDbType.NVarChar, 50);
            jobassignadminidParameter.Value = obj.jobAssignByAdmin;
            SqlParameter jobstartdateParameter = new SqlParameter("@jobStartDate", SqlDbType.Date);
            jobstartdateParameter.Value = obj.jobStartDate;
            SqlParameter jobDeadlineDateParameter = new SqlParameter("@jobDeadlineDate", SqlDbType.Date);
            jobDeadlineDateParameter.Value = obj.jobDeadlineDate;
            SqlParameter departmentNoParameter = new SqlParameter("@departmentNo", SqlDbType.NVarChar, 50);
            departmentNoParameter.Value = obj.departmentId;


           
           
           




            command.Parameters.Add(idParameter);
            command.Parameters.Add(jobidParameter);
            command.Parameters.Add(jobdesParameter);
            command.Parameters.Add(jobassignadminidParameter);
            command.Parameters.Add(jobstartdateParameter);
            command.Parameters.Add(jobDeadlineDateParameter);
            command.Parameters.Add(departmentNoParameter);







            if (da.Execution(command))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        

        public List<object> GetJobIdFromJobAssignList()
        {
            List<object> jobidList = new List<object>();
            string query = "select jobId from employeejobassign";
            SqlCommand cmd = da.GetCommand(query);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {


                jobidList.Add(reader.GetString(0));
            }
            return jobidList;
        }

        public EmployeeJobAssign GetJobAllFromJobAssign(string jobid)
        {
            EmployeeJobAssign eja = new EmployeeJobAssign();
            string query = "select employeeId,jobDescription,jobStartDate,jobDeadlineDate,departmentNo from employeejobassign where jobId= '" + jobid + "'";
            SqlCommand cmd = da.GetCommand(query);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                eja.employeeId = reader.GetString(0);              
                eja.jobDescription = reader.GetString(1);
                eja.jobStartDate = reader.GetDateTime(2);
                eja.jobDeadlineDate = reader.GetDateTime(3);
                eja.departmentId = reader.GetString(4);
                

            }
            return eja;
        }


        public List<EmployeeJobAssign> GetAssignJobList()
        {
            List<EmployeeJobAssign> employeeAssignjobList = new List<EmployeeJobAssign>();
          
            string query = "select employeeId,jobId,jobDescription,jobAssignByAdminId,jobStartDate,jobDeadlineDate,departmentNo,JobStatus from employeejobassign";
            SqlCommand cmd = da.GetCommand(query);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                EmployeeJobAssign ej = new EmployeeJobAssign();
                ej.employeeId = reader.GetString(0);
                ej.jobId = reader.GetString(1);
                ej.jobDescription = reader.GetString(2);
                ej.jobAssignByAdmin = reader.GetString(3);
                ej.jobStartDate = reader.GetDateTime(4);
                ej.jobDeadlineDate = reader.GetDateTime(5);
                ej.departmentId = reader.GetString(6);
                ej.jobStatus = reader.GetString(7);

                employeeAssignjobList.Add(ej);
            }
            return employeeAssignjobList;
        }
        public bool deleteJob(EmployeeJobAssign obj)
        {
            string insertCommand = "delete from employeejobassign  " +
                                   "where jobId= @jobId ";
            SqlCommand command = new SqlCommand(insertCommand);
            SqlParameter jobIdParameter = new SqlParameter("@jobId", SqlDbType.NVarChar, 50);
             jobIdParameter.Value = obj.jobId;


             command.Parameters.Add(jobIdParameter);

            if (da.Execution(command))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void deleteFromJobAssign(string adminid)
        {


            string insertCommand = "delete from employeejobassign where jobAssignByAdminId='" + adminid + "'";
            SqlCommand command = new SqlCommand(insertCommand);
            da.Execution(command);

        }
        public void deleteEmployeeJobAssign(string employeeId)
        {


            string insertCommand = "delete from employeejobassign where employeeId='" + employeeId + "'";
            SqlCommand command = new SqlCommand(insertCommand);
            da.Execution(command);

        }

        public void deleteDepartmentJobAssign(string departmentNo)
        {


            string insertCommand = "delete from employeejobassign where departmentNo='" + departmentNo + "'";
            SqlCommand command = new SqlCommand(insertCommand);
            da.Execution(command);

        }


        public List<object> GetJobIdFromJobAssignListForEmployee(string eid)
        {
            List<object> jobidList = new List<object>();
            string query = "select jobId from employeejobassign where employeeId='"+ eid +"'";
            SqlCommand cmd = da.GetCommand(query);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {


                jobidList.Add(reader.GetString(0));
            }
            return jobidList;
        }

        public string GetJobStatus(string eid, string jobid)
        {
            string result = "";
            string query = "select jobstatus from employeejobassign where employeeId='" + eid + "'  and jobId='" + jobid+ "'";
            SqlCommand cmd = da.GetCommand(query);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {


                result=reader.GetString(0);
            }
            return result;


        }


        public bool updateStatus(string eid, string jobid, string jobs)
        {


            string insertCommand = "update employeejobassign set jobStatus='" + jobs + "' where employeeId='" + eid + "' and  jobId='" + jobid + "'";
            SqlCommand command = new SqlCommand(insertCommand);

            if (da.Execution(command))
            {

                return true;
            }
            else
            {
                return false;
            }


        }


        public List<EmployeeJobAssign> GetAssignJobListForEmployee(string eid)
        {
            List<EmployeeJobAssign> employeeAssignjobList = new List<EmployeeJobAssign>();

            string query = "select employeeId,jobId,jobDescription,jobAssignByAdminId,jobStartDate,jobDeadlineDate,departmentNo,JobStatus from employeejobassign where employeeId='"+ eid +"' ";
            SqlCommand cmd = da.GetCommand(query);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                EmployeeJobAssign ej = new EmployeeJobAssign();
                ej.employeeId = reader.GetString(0);
                ej.jobId = reader.GetString(1);
                ej.jobDescription = reader.GetString(2);
                ej.jobAssignByAdmin = reader.GetString(3);
                ej.jobStartDate = reader.GetDateTime(4);
                ej.jobDeadlineDate = reader.GetDateTime(5);
                ej.departmentId = reader.GetString(6);
                ej.jobStatus = reader.GetString(7);

                employeeAssignjobList.Add(ej);
            }
            return employeeAssignjobList;
        }



    }
}
