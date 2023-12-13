using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAT;

namespace BUS
{
    public class BUSAccount
    {
        AccessAccount Access_acc = new AccessAccount();
        public string CheckLogic(Account account)
        {
            if (account.Username == "")
            {
                return "Please enter your username";
            }
            else if (account.Password == "")
            {
                return "Please enter your password";
            }
            else
            {
                string info = Access_acc.CheckLogic(account);
                return info;
            }   
        }
    }
}
