using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCMS.Model
{
    public class User
    {
        private int userid;
        private string username;
        private string password;
        private string email;
        private string role;
        public int UserId { get { return userid; } set { userid = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Role { get { return role; } set { role = value; } }

        public User() { }
        public User(int userid, string username, string password, string email, string role)
        {
            this.userid = userid;
            this.username = username;
            this.password = password;
            this.email = email;
            this.role = role;
        }
    }
}
