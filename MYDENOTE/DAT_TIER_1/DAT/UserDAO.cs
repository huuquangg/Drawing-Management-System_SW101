using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAT
{
    public class UserDAO : DBConnection
    {
        public UserDAO() : base() { }
        public void GetUserById(int id)
        {
            try
            {
                ConnectoR.Open();
                OleDbCommand command = new OleDbCommand("SELECT * FROM Users WHERE Id = @id", ConnectoR);
                command.Parameters.AddWithValue("@id", id);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("Id: {0}, Username: {1}, Password: {2}", reader["Id"], reader["Username"], reader["Password"]);
                }
                ConnectoR.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        public string CheckLogic(User user)
        {
                string info = CheckLogic(user);
                return info;
        }
        public bool checkLogin(string username, string password)
        {
            bool result = false;
            try
            {
                if (ConnectoR.State != System.Data.ConnectionState.Open) { ConnectoR.Open(); }
                OleDbCommand command = new OleDbCommand("SELECT * FROM userACCOUNT WHERE Username = @username AND Password = @password", ConnectoR);
                command.Parameters.Add("@username", OleDbType.VarChar).Value = username;
                command.Parameters.Add("@password", OleDbType.VarChar).Value = password;

                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ConnectoR.Close();
                    return true;
                }
                ConnectoR.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            return result;
        }


        public void AddUser(string username, string password)
        {

            try
            {
                if (ConnectoR.State != System.Data.ConnectionState.Open) { ConnectoR.Open(); }

                OleDbCommand command = new OleDbCommand("INSERT INTO Users (Username, Password) VALUES (@username, @password)", ConnectoR);
                command.Parameters.Add("@Id", OleDbType.Integer).Value = 0; // auto increment (auto number)
                command.Parameters.Add("@username", OleDbType.VarChar).Value = username;
                command.Parameters.Add("@password", OleDbType.VarChar).Value = password;

                command.ExecuteNonQuery();

                ConnectoR.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
