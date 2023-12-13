using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAT;

namespace BUS
{
    public class UserBUS
    {
        UserDAO objUserDAO = new UserDAO();

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
