using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCMS.Model
{
    public class Signup
    {
        SqlDBAccess sdba = new SqlDBAccess();


        public bool VerifyUser(string userId, string currentPassword)
        {
            SqlCommand cmd = sdba.GetQuery("SELECT COUNT(*) FROM [User] WHERE userId = @userId AND password = @password");
            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.Parameters.AddWithValue("@password", currentPassword);
            cmd.Connection.Open();
            int count = (int)cmd.ExecuteScalar();
            cmd.Connection.Close();

            return count > 0;
        }

        public bool UpdatePassword(string userId, string newPassword)
        {
            SqlCommand cmd = sdba.GetQuery("UPDATE [User] SET password = @password WHERE userId = @userId");
            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.Parameters.AddWithValue("@password", newPassword);
            cmd.Connection.Open();
            int rows = cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            return rows > 0;
        }


        public string AddUser(User user)
        {
            SqlCommand cmd = sdba.GetQuery(
                "INSERT INTO [User] (userName, email, password, role) " +
                "OUTPUT INSERTED.userID VALUES (@userName, @email, @password, @role);");

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@userName", user.Username);
            cmd.Parameters.AddWithValue("@email", user.Email);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@role", user.Role);

            cmd.Connection.Open();
            object result = cmd.ExecuteScalar(); 
            cmd.Connection.Close();

            return result?.ToString(); 
        }

    }
}
