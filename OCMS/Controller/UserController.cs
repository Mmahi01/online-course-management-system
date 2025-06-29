using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCMS.Model;

namespace OCMS.Controller
{
    public class UserController
    {
        Users usr = new Users();

        public void AddUser(User user)
        {
            usr.AddLogin(user);
        }

        public void DeleteUser(User user)
        {
            usr.DeleteLogin(user);
        }

        public void UpdateUser(User user)
        {
            usr.UpdateLogin(user);
        }

        public int GetTotalUsers()
        {
            return usr.GetAllUser().Count;
        }

        public int GetTotalStudents()
        {
            return usr.GetAllUser().Where(u => u.Role == "Student").Count();
        }

        public int GetTotalInstructors()
        {
            return usr.GetAllUser().Where(u => u.Role == "Instructor").Count();
        }

        public User GetUserById(int userId)
        {
            return usr.GetUserById(userId);
        }



        public User SearchUser(int userId, string password)
        {
            User user = usr.SearchLogin(userId, password);
            return user;
        }

        public List<User> GetAllUsers()
        {
            List<User> userList = usr.GetAllUser();
            return userList;
        }

        public bool IsValidInstructor(int userId)
        {
            User user = usr.GetUserById(userId);
            return user != null && user.Role == "Instructor";
        }

    }
}
