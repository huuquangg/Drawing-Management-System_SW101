using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAT;
using DTO;

namespace BUS
{
    public class BluePrintBUS
    {
        BluePrintDAO objBluePrintDAO = new BluePrintDAO();

        public void AddBluePrint(BluePrint objBluePrint)
        {
            if (objBluePrint.bluePrintName == "")
            {
                throw new Exception("Please fill in all the fields!");
            }
            if (objBluePrintDAO.checkBluePrintName(objBluePrint))
            {
                throw new Exception("Blueprint name already exists!");
            }
            objBluePrintDAO.AddBluePrint(objBluePrint);
        }

        public List<BluePrint> GetListBluePrint(int userId)
        {
            return objBluePrintDAO.GetListBluePrint(userId);
        }

        public string GetBluePrintName(BluePrint objBP)
        {
            return objBluePrintDAO.getBluePrintName(objBP);
        }

        public string GetBluePrintPath(BluePrint objBP)
        {
            return objBluePrintDAO.getBluePrintPath(objBP);
        }

        public string GetBluePrintPATHByName(string name, int currUserID)
        {
            return objBluePrintDAO.getBluePrintPATHByName(name, currUserID);
        }

        public void DeleteBluePrint(string BPname, int currUserID)
        {
            objBluePrintDAO.DeleteBluePrint(BPname, currUserID);
        }
    }
}
