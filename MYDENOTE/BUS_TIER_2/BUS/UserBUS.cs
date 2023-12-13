using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using DAT;
using DTO;

namespace BUS
{
    public class UserBUS
    {
        UserDAO objUserDAO = new UserDAO();
        public string CheckLogic(User user)
        {
            if (user.Username == "")
            {
                return "Please enter your username";
            }
            else if (user.Password == "")
            {
                return "Please enter your password";
            }
            else
            {
                string info = objUserDAO.CheckLogic(user);
                return info;
            }

        }
    public void GetUserById(int id)
        {
            objUserDAO.GetUserById(id);
        }

        public bool checkLogin(string username, string password)
        {
            return objUserDAO.checkLogin(username, password);
        }

        public void AddUser(string username, string password)
        {
            if(username == "" || password == "")
            {
                throw new Exception("Please fill in all the fields!");
            }
            else
            {
                if (objUserDAO.checkLogin(username, password))
                {
                    throw new Exception("Username already exists!");
                }
            }
            objUserDAO.AddUser(username, password);
        }


    }
}
