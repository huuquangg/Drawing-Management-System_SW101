using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT
{
    public class DBconnection
    {
        protected OleDbConnection connectoR;

        public DBconnection()
        {
            try
            {
                connectoR = new OleDbConnection("");
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
