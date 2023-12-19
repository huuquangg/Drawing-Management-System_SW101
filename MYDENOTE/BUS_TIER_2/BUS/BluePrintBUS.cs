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
        BluePrintDAO objBluePrintDAO = new BluePrintDAO(); // create a new BluePrintDAO object to access the database

        public void AddBluePrint(BluePrint objBluePrint) // Check the logic of the blueprint before adding it to the database
        {
            if (objBluePrint.bluePrintName == "") // check if the blueprint name is empty
            {
                throw new Exception("Please fill in all the fields!");
            }
            if (objBluePrintDAO.checkBluePrintName(objBluePrint)) // check if the blueprint name already exists
            {
                throw new Exception("Blueprint name already exists!");
            }
            objBluePrintDAO.AddBluePrint(objBluePrint);
        }

        public List<BluePrint> GetListBluePrint(int userId) // get a list of blueprints
        {
            return objBluePrintDAO.GetListBluePrint(userId);
        }

        public string GetBluePrintName(BluePrint objBP) // get the name of a blueprint
        {
            return objBluePrintDAO.getBluePrintName(objBP);
        }

        public string GetBluePrintPath(BluePrint objBP) // get the path of a blueprint
        {
            return objBluePrintDAO.getBluePrintPath(objBP);
        }

        public string GetBluePrintPATHByName(string name, int currUserID) // get the path of a blueprint by its name
        {
            return objBluePrintDAO.getBluePrintPATHByName(name, currUserID);
        }

        public void DeleteBluePrint(string BPname, int currUserID) // delete a blueprint
        {
            objBluePrintDAO.DeleteBluePrint(BPname, currUserID);
        }
    }
}
