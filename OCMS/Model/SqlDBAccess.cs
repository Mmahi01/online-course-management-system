using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace OCMS.Model
{
    public class SqlDBAccess
    {
       //private const string connectionString = @"LAPTOP-AJ8P9U67\SQLEXPRESS; Initial Catalog=OCMS; Trusted_Connection=True;";
        private const string connectionString = @"Data Source=DESKTOP-TT5C68V; Initial Catalog=OCMS; Integrated Security=True;";
        //private const string connectionString = @"Data Source=DESKTOP-5IIMGTU\SQLEXPRESS; Initial Catalog=Product Management System; Trusted_Connection=True;";


        public SqlCommand GetQuery(string qry)
        {
            var connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(qry, connection); 
            return cmd;
        }

    }
}
