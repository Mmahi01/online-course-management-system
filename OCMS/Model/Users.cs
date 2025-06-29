using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace OCMS.Model
{
    public class Users
    {
        SqlDBAccess sdba = new SqlDBAccess();

        public void AddLogin(User user)
        {
            SqlCommand cmd = sdba.GetQuery("INSERT INTO [User]  VALUES (@userName, @email, @password, @role);");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@userName", user.Username);
            cmd.Parameters.AddWithValue("@email", user.Email);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@role", user.Role);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void UpdateLogin(User user)
        {
            SqlCommand cmd = sdba.GetQuery("UPDATE [User] SET UserName = @userName, Email = @email, Password = @password, Role = @role WHERE UserID = @userID");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@userID", user.UserId);
            cmd.Parameters.AddWithValue("@userName", user.Username);
            cmd.Parameters.AddWithValue("@email", user.Email);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@role", user.Role);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void DeleteLogin(User user)
        {
            SqlCommand cmd = sdba.GetQuery("DELETE FROM [User] WHERE UserID = @userID");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@userID", user.UserId);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }


        public User SearchLogin(int userId, string password)
        {
            SqlCommand cmd = sdba.GetQuery("SELECT * FROM [User] WHERE UserID = @userId AND Password = @password");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.Parameters.AddWithValue("@password", password);

            List<User> userList = GetData(cmd);

            if (userList.Count > 0)
            {
                return userList[0];
            }
            else
            {
                return null;
            }
        }

        public User GetUserById(int userId)
        {
            SqlCommand cmd = sdba.GetQuery("SELECT * FROM [User] WHERE UserID = @userId");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@userId", userId);

            List<User> userList = GetData(cmd);

            if (userList.Count > 0)
            {
                return userList[0];
            }
            else
            {
                return null;
            }
        }


        public List<User> GetAllUser()
        {
            SqlCommand cmd = sdba.GetQuery("SELECT * FROM [User]");
            cmd.CommandType = CommandType.Text;
            return GetData(cmd);
        }

        public List<User> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            List<User> userList = new List<User>();

            using (sdr)
            {
                while (sdr.Read())
                {
                    User u = new User();
                    u.UserId = sdr.GetInt32(0);         
                    u.Username = sdr.GetString(1);      
                    u.Email = sdr.GetString(2);         
                    u.Password = sdr.GetString(3);      
                    u.Role = sdr.GetString(4);          

                    userList.Add(u);
                }

                sdr.Close();
            }

            cmd.Connection.Close();

            return userList;
        }



    }
}
