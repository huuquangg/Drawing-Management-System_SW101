using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAT
{
    public class DBConnection
    {
        protected OleDbConnection ConnectoR { get; set; }

        public DBConnection()
        {
            try
            {
                string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\dbUser.mdb";
                ConnectoR = new OleDbConnection(connString);
                ConnectoR.Open();
                Console.WriteLine(ConnectoR.Database.ToString());
                Console.WriteLine("Connected");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        public class DatabaseAccess
        {
            public string CheckLogin(User user)
            {
                string _user = null;
                try
                {
                    DBConnection db = new DBConnection();
                    string sql = "SELECT * FROM userACCOUNT WHERE userName = '" + user.Username + "' AND password = '" + user.Password + "'";
                    OleDbCommand cmd = new OleDbCommand("Login_Check", db.ConnectoR);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@userName", user.Username);
                    cmd.Parameters.AddWithValue("@password", user.Password);
                    cmd.Connection = db.ConnectoR;
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            _user = reader.GetString(0);
                        }
                        reader.Close();
                        db.ConnectoR.Close();
                    }
                    else
                    {
                        return _user;
                    }
                    return _user;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}

