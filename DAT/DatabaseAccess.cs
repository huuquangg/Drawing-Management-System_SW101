using System.Data.OleDb;

namespace DataAcessTier
{
    public class DBConnection
    {
        protected OleDbConnection conn;

        public DBConnection()
        {
            try
            {
                conn = new OleDbConnection("Data Source=DESKTOP-LUFJ8I9\\SQLEXPRESS;Initial Catalog=User;Integrated Security=True");
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}