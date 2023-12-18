using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAT;
using DTO;

namespace BUS
{
    public class UserBUS
    {
        UserDAO objUserDAO = new UserDAO();

        public bool checkLogin(User objUser)
        {
            return objUserDAO.checkLogin(objUser);
        }

        public void AddUser(User objUSER)
        {
            if (objUSER.Username == "" || objUSER.Password == "")
            {
                throw new Exception("Please fill in all the fields!");
            }
            else
            {
                if (objUserDAO.checkLogin(objUSER))
                {
                    throw new Exception("Username already exists!");
                }
            }
            objUserDAO.AddUser(objUSER);
        }

        public int getUserId(User objUSER)
        {
            return objUserDAO.getUserId(objUSER);
        }

        public string getUsername(User objUSER)
        {
            return objUserDAO.getUsername(objUSER);
        }
       
    }
}
