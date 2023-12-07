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
                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbSanPham.mdb;Persist Security Info=True");
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}