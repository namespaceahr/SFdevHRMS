using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Framework
{
    public class DataAccess
    {
        string connectionString = "Data Source=localhost;Initial Catalog=SFdevHRMS;Integrated Security=True";
       
        public bool Execution(SqlCommand command)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            command.Connection = connection;
            connection.Open();
            
                if (command.ExecuteNonQuery() != 0)
                {
                    connection.Close();
                    return true;

                }
                else
                {
                    connection.Close();
                    return false;
                }
            
          
            
        }

        public int CheckAutoEmployee(string dept)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select  COUNT(DISTINCT employeeId) FROM employeejobassign where departmentNo='" + dept + "'";
            connection.Open();
            int result = ((int)cmd.ExecuteScalar());
            connection.Close();

            return result;
        }


        public string CheckAutoEmployeeSalary(string dept)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = " select sum(SalaryAmount+BonusAmount) from payroll where departmentId='" + dept + "'";
            connection.Open();
            string result = cmd.ExecuteScalar().ToString();
            connection.Close();

            return result;
        }

        public DataTable Query(SqlCommand query)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            query.Connection = connection;
            SqlDataAdapter da = new SqlDataAdapter(query);
            connection.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();

            return dt;
        }

        public SqlCommand GetCommand(string query)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = new SqlConnection(connectionString);
            cmd.CommandText = query;
            return cmd;
        }
    }
}
