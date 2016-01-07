using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Framework;
using Entities;
using System.Data;

namespace DataLayer
{
    public class AdminData
    {
        DataAccess da = new DataAccess();
        public List<object> GetAdminList()
        {
            List<object> adminList = new List<object>();
            string query = "select adminId, adminName from admin";
            SqlCommand cmd = da.GetCommand(query);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                object obj = new { admin_id = reader.GetString(0), admin_Name = reader.GetString(1) };
                
                adminList.Add(obj);
            }
            return adminList;
        }

        public bool insertAdmin(Admin obj)
        {
            string insertCommand = "INSERT INTO admin (adminid,adminName,adminPassword) " +
                                   "VALUES (@adminid,@adminName,@adminPassword)";
            SqlCommand command = new SqlCommand(insertCommand);
            SqlParameter idParameter = new SqlParameter("@adminid", SqlDbType.NVarChar, 50);
            idParameter.Value = obj.adminId;
            SqlParameter nameParameter = new SqlParameter("@adminName", SqlDbType.NVarChar, 50);
            nameParameter.Value = obj.adminName;
            SqlParameter passwordParameter = new SqlParameter("@adminPassword", SqlDbType.NVarChar, 50);
            passwordParameter.Value = obj.adminPassword;

            command.Parameters.Add(idParameter);
            command.Parameters.Add(nameParameter);
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
        public bool updateAdmin(Admin obj)
        {
            string insertCommand = "update admin set adminName= @adminName,adminPassword = @adminPassword " +
                                   "where adminid= @adminid ";
            SqlCommand command = new SqlCommand(insertCommand);
            SqlParameter idParameter = new SqlParameter("@adminid", SqlDbType.NVarChar, 50);
            idParameter.Value = obj.adminId;
            SqlParameter nameParameter = new SqlParameter("@adminName", SqlDbType.NVarChar, 50);
            nameParameter.Value = obj.adminName;
            SqlParameter passwordParameter = new SqlParameter("@adminPassword", SqlDbType.NVarChar, 50);
            passwordParameter.Value = obj.adminPassword;

            command.Parameters.Add(idParameter);
            command.Parameters.Add(nameParameter);
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



        public bool deleteAdmin(Admin obj)
        {
            string insertCommand = "delete from admin  " +
                                   "where adminid= @adminid ";
            SqlCommand command = new SqlCommand(insertCommand);
            SqlParameter idParameter = new SqlParameter("@adminid", SqlDbType.NVarChar, 50);
            idParameter.Value = obj.adminId;
            

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

        public List<object> GetAdminIdList()
        {
            List<object> adminidList = new List<object>();
            string query = "select adminId from admin";
            SqlCommand cmd = da.GetCommand(query);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {


                adminidList.Add(reader.GetString(0));
            }
            return adminidList;
        }
        public Admin GetAdminUpdateData(string id)
        {
            Admin adminupdate = new Admin();
            string query = "select adminName, adminPassword from admin where adminId ='" + id + "'";
            SqlCommand cmd = da.GetCommand(query);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                adminupdate.adminName = reader.GetString(0);
                adminupdate.adminPassword = reader.GetString(1);


                
            }
            return adminupdate;
        }
       

    }
}
