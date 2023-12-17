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
            else
            {
                if (objBluePrintDAO.checkBluePrintName(objBluePrint))
                {
                    throw new Exception("Blueprint name already exists!");
                }
            }
            objBluePrintDAO.AddBluePrint(objBluePrint);
        }

        public List<BluePrint> GetListBluePrint(int userId)
        {
            return objBluePrintDAO.GetListBluePrint(userId);
        }

        public void DeleteBluePrint(int bluePrintId)
        {
            objBluePrintDAO.DeleteBluePrint(bluePrintId);
        }

 

        public int GetBluePrintId(BluePrint objBluePrint)
        {
            return objBluePrintDAO.GetBluePrintId(objBluePrint);
        }

        public string GetBluePrintName(int bluePrintId)
        {
            return objBluePrintDAO.GetBluePrintName(bluePrintId);
        }

        public string GetPath(int bluePrintId)
        {
            return objBluePrintDAO.GetPath(bluePrintId);
        }

        public void UpdateDateCreatedBluePrint(int bluePrintId, DateTime dateCreatedBluePrint)
        {
            objBluePrintDAO.UpdateDateCreatedBluePrint(bluePrintId, dateCreatedBluePrint);
        }

        public DateTime GetDateCreatedBluePrint(int bluePrintId)
        {
            return objBluePrintDAO.GetDateCreatedBluePrint(bluePrintId);
        }
    }
}
