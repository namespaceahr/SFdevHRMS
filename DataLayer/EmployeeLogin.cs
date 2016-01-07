using Entities;
using Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
   public class EmployeeLogin
    {
        DataAccess da = new DataAccess();
        public bool EmployeeValid(Employee e)
        {
            string query = String.Format("select * from employee where EmployeeId = '{0}' and EmployeePassword = '{1}'", e.employeeId, e.employeePassword);
            SqlCommand cmd = da.GetCommand(query);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
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
