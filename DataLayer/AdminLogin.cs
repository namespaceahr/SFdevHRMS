using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Framework;
using System.Data;
using System.Data.SqlClient;


namespace DataLayer
{
    public class AdminLogin
    {
        DataAccess da = new DataAccess();
        public bool AdminValid(Admin ad)
        {
            string query = String.Format("select * from admin where adminId = '{0}' and adminPassword = '{1}'",ad.adminId, ad.adminPassword);
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
