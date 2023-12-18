using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BCrypt;

namespace DAT
{
    public class UserDAO : DBConnection
    {
        public UserDAO() : base() { }

        public int getUserId(User objUser)
        {
            int result = 0;
            try
            {
                if (ConnectoR.State != System.Data.ConnectionState.Open) { ConnectoR.Open(); }
                OleDbCommand command = new OleDbCommand("SELECT * FROM userACCOUNT WHERE Username = @username", ConnectoR);
                command.Parameters.Add("@username", OleDbType.VarChar).Value = objUser.Username;
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    result = (int)reader["Id"];
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

        public bool checkLogin(User objUser)
        {
            bool result = false;
            try
            {

                if (ConnectoR.State != System.Data.ConnectionState.Open) { ConnectoR.Open(); }
                OleDbCommand command = new OleDbCommand("SELECT * FROM userACCOUNT WHERE Username = @username", ConnectoR);
                command.Parameters.Add("@username", OleDbType.VarChar).Value = objUser.Username;
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (BCrypt.Net.BCrypt.Verify(objUser.Password, reader["Password"].ToString()))
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
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

        protected int getNumberofUsers()
        {
            int result = 0;
            try
            {
                OleDbCommand command = new OleDbCommand("SELECT COUNT(*) FROM userACCOUNT", ConnectoR);
                result = (int)command.ExecuteScalar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            return result;
        }

        public void AddUser(User addedUSER)
        {

            try
            {
                if (ConnectoR.State != System.Data.ConnectionState.Open) { ConnectoR.Open(); }

                OleDbCommand command = new OleDbCommand("INSERT INTO userACCOUNT VALUES (@Id,@username, @password)", ConnectoR);
                command.Parameters.Add("@Id", OleDbType.Integer).Value = getNumberofUsers() + 1; // auto increment (auto number)
                command.Parameters.Add("@username", OleDbType.VarChar).Value = addedUSER.Username;
                command.Parameters.Add("@password", OleDbType.VarChar).Value = addedUSER.Password;
                command.ExecuteNonQuery();
                ConnectoR.Close();
            }
            catch (Exception e)
            {
                ConnectoR.Close();
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public string getUsername(User objUSER)
        {
            string result = "";
            try
            {
                if (ConnectoR.State != System.Data.ConnectionState.Open) { ConnectoR.Open(); }
                OleDbCommand command = new OleDbCommand("SELECT * FROM userACCOUNT WHERE Username = @username", ConnectoR);
                command.Parameters.Add("@username", OleDbType.VarChar).Value = objUSER.Username;
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    result = reader["Username"].ToString();
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
    }
}
