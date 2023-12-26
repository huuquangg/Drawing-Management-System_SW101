using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BluePrint
    {
        public int bluePrintId { get; set; }
        public string bluePrintName { get; set; }
        public string Path { get; set; }
        public int userId { get; set; }

        public DateTime dateCreatedBluePrint { get; set; }
        

        public BluePrint() { }

        public BluePrint(int bluePrintId, string bluePrintName, string Path, DateTime dateCreatedBluePrint, int userId)
        {
            this.bluePrintId = bluePrintId;
            this.bluePrintName = bluePrintName;
            this.Path = Path;
            this.dateCreatedBluePrint = dateCreatedBluePrint;
            this.userId = userId;
        }
        
        


    }
}
