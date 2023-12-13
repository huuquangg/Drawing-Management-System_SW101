using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT
{
    public class DBConnection
    {
        protected OleDbConnection ConnectoR { get; set; }

        public DBConnection()
        {
            try
            {
                //Provider=Microsoft.ACE.OLEDB.12.0;Data Source="E:\University\V Software 101\test\SW101_\MYDENOTE\Database\dbUSER.mdb"
                //E:\University\V Software 101\test\SW101_\MYDENOTE\DAT_TIER_1\DAT\dbUSER.mdb
                string strConnect = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"E:\\University\\V Software 101\\test\\SW101_\\MYDENOTE\\Database\\dbUSER.mdb\"";
                ConnectoR = new OleDbConnection(strConnect);
                // print ConnectoR is connected
                Console.WriteLine(ConnectoR.Database.ToString());
                Console.WriteLine("Connected");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
