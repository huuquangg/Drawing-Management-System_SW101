using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAT
{
    public class BluePrintDAO : DBConnection
    {
        public List<BluePrint> GetListBluePrint(int userId)
        {
            List<BluePrint> list = new List<BluePrint>(); // create a list of blueprints
            try
            {
                if (ConnectoR.State != System.Data.ConnectionState.Open) { ConnectoR.Open(); }
                OleDbCommand command = new OleDbCommand("SELECT * FROM BluePrint WHERE userId = @userId", ConnectoR);
                command.Parameters.Add("@userId", OleDbType.Integer).Value = userId;
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read()) // read all the BluePrints from Database
                {
                    BluePrint bluePrint = new BluePrint();
                    bluePrint.bluePrintId = (int)reader["bluePrintId"];
                    bluePrint.bluePrintName = reader["bluePrintName"].ToString();
                    bluePrint.Path = reader["Path"].ToString();
                    bluePrint.dateCreatedBluePrint = (DateTime)reader["dateCreatedBluePrint"];
                    bluePrint.userId = (int)reader["userId"];
                    list.Add(bluePrint);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            return list;
        }

        public void AddBluePrint(BluePrint objBluePrint) // add a blueprint to the database
        {
            try
            {
                if (ConnectoR.State != System.Data.ConnectionState.Open) { ConnectoR.Open(); }
                OleDbCommand command = new OleDbCommand("INSERT INTO BluePrint(bluePrintName, Path, dateCreatedBluePrint, userId) VALUES(@bluePrintName, @Path, @dateCreatedBluePrint, @userId)", ConnectoR);
                command.Parameters.Add("@bluePrintName", OleDbType.VarChar).Value = objBluePrint.bluePrintName;
                command.Parameters.Add("@Path", OleDbType.VarChar).Value = objBluePrint.Path;
                command.Parameters.Add("@dateCreatedBluePrint", OleDbType.Date).Value = objBluePrint.dateCreatedBluePrint;
                command.Parameters.Add("@userId", OleDbType.Integer).Value = objBluePrint.userId;
                command.ExecuteNonQuery();
                ConnectoR.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public void DeleteBluePrint(string bluePrintName, int UserId)
        {
            try // delete all the blueprints with the same name and the same user id
            {
                if (ConnectoR.State != System.Data.ConnectionState.Open) { ConnectoR.Open(); }
                OleDbCommand command = new OleDbCommand("DELETE FROM BluePrint WHERE bluePrintName = @bluePrintName AND userId = @userId", ConnectoR);
                command.Parameters.Add("@bluePrintName", OleDbType.VarChar).Value = bluePrintName;
                command.Parameters.Add("@userId", OleDbType.Integer).Value = UserId;
                command.ExecuteNonQuery();
                ConnectoR.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public bool checkBluePrintName(BluePrint objBluePrint) // check if the blueprint name already exists
        {
            bool result = false;
            try
            {
                if (ConnectoR.State != System.Data.ConnectionState.Open) { ConnectoR.Open(); }
                OleDbCommand command = new OleDbCommand("SELECT * FROM BluePrint WHERE bluePrintName = @bluePrintName AND userId = @userId", ConnectoR);
                command.Parameters.Add("@bluePrintName", OleDbType.VarChar).Value = objBluePrint.bluePrintName;
                command.Parameters.Add("@userId", OleDbType.Integer).Value = objBluePrint.userId;
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    result = true;
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

        public string getBluePrintName(BluePrint objBluePrint) // Get Blue Print Name of a blueprint Object
        {
            string result = "";
            try
            {
                if (ConnectoR.State != System.Data.ConnectionState.Open) { ConnectoR.Open(); }
                OleDbCommand command = new OleDbCommand("SELECT * FROM BluePrint WHERE bluePrintId = @bluePrintId", ConnectoR);
                command.Parameters.Add("@bluePrintId", OleDbType.Integer).Value = objBluePrint.bluePrintId;
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    result = reader["bluePrintName"].ToString();
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

        public string getBluePrintPath(BluePrint objBluePrint) // Get Blue Print Path of a blueprint Object
        {
            string result = "";
            try
            {
                if (ConnectoR.State != System.Data.ConnectionState.Open) { ConnectoR.Open(); }
                OleDbCommand command = new OleDbCommand("SELECT * FROM BluePrint WHERE bluePrintId = @bluePrintId", ConnectoR);
                command.Parameters.Add("@bluePrintId", OleDbType.Integer).Value = objBluePrint.bluePrintId;
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    result = reader["Path"].ToString();
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

        public string getBluePrintPATHByName(string name, int currUserID) // Get Blue Print Path of a current user 
        {
            string result = "";
            try
            {
                if (ConnectoR.State != System.Data.ConnectionState.Open) { ConnectoR.Open(); }
                OleDbCommand command = new OleDbCommand("SELECT Path FROM BluePrint WHERE bluePrintName = @bluePrintName AND userId = @userId", ConnectoR);
                command.Parameters.Add("@bluePrintName", OleDbType.VarChar).Value = name;
                command.Parameters.Add("@userId", OleDbType.Integer).Value = currUserID;
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    result = reader["Path"].ToString();
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
