using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT
{
    public class BluePrintDAO : DBConnection
    {
        public List<DTO.BluePrint> GetListBluePrint(int userId)
        {
            List<DTO.BluePrint> list = new List<DTO.BluePrint>();
            try
            {
                if (ConnectoR.State != System.Data.ConnectionState.Open) { ConnectoR.Open(); }
                OleDbCommand command = new OleDbCommand("SELECT * FROM BluePrint WHERE userId = @userId", ConnectoR);
                command.Parameters.Add("@userId", OleDbType.Integer).Value = userId;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DTO.BluePrint bluePrint = new DTO.BluePrint();
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

        public int countNumberOfBluePrint()
        {
            int result = 0;
            try
            {
                if (ConnectoR.State != System.Data.ConnectionState.Open) { ConnectoR.Open(); }
                OleDbCommand command = new OleDbCommand("SELECT COUNT(*) FROM BluePrint", ConnectoR);
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    result = (int)reader[0];
                }
                ConnectoR.Close();
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        public void AddBluePrint(DTO.BluePrint objBluePrint)
        {
            try
            {
                if (ConnectoR.State != System.Data.ConnectionState.Open) { ConnectoR.Open(); }
                OleDbCommand command = new OleDbCommand("INSERT INTO BluePrint(bluePrintName, Path, dateCreatedBluePrint, userId) VALUES(@bluePrintName, @Path, @dateCreatedBluePrint, @userId)", ConnectoR);
                command.Parameters.Add("@bluePrintName", OleDbType.VarChar).Value = objBluePrint.bluePrintName;
                command.Parameters.Add("@Path", OleDbType.VarChar).Value = objBluePrint.Path;
                command.Parameters.Add("@dateCreatedBluePrint", OleDbType.Date).Value = objBluePrint.dateCreatedBluePrint;
                command.Parameters.Add("@userId", OleDbType.Integer).Value = objBluePrint.userId ;
                command.ExecuteNonQuery();
                ConnectoR.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public void DeleteBluePrint(int bluePrintId)
        {
            try
            {
                if (ConnectoR.State != System.Data.ConnectionState.Open) { ConnectoR.Open(); }
                OleDbCommand command = new OleDbCommand("DELETE FROM BluePrint WHERE bluePrintId = @bluePrintId", ConnectoR);
                command.Parameters.Add("@bluePrintId", OleDbType.Integer).Value = bluePrintId;
                command.ExecuteNonQuery();
                ConnectoR.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public bool checkBluePrintName(DTO.BluePrint objBluePrint)
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

        public void getABluePrint(int bluePrintId)
        {
            try
            {
                if (ConnectoR.State != System.Data.ConnectionState.Open) { ConnectoR.Open(); }
                OleDbCommand command = new OleDbCommand("SELECT * FROM BluePrint WHERE bluePrintId = @bluePrintId", ConnectoR);
                command.Parameters.Add("@bluePrintId", OleDbType.Integer).Value = bluePrintId;
                command.ExecuteNonQuery();
                ConnectoR.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public List<DTO.BluePrint> SearchBluePrint(string bluePrintName, int userId)
        {
            try
            {
                List<DTO.BluePrint> list = new List<DTO.BluePrint>();
                if (ConnectoR.State != System.Data.ConnectionState.Open) { ConnectoR.Open(); }
                OleDbCommand command = new OleDbCommand("SELECT * FROM BluePrint WHERE bluePrintName LIKE @bluePrintName AND userId = @userId", ConnectoR);
                command.Parameters.Add("@bluePrintName", OleDbType.VarChar).Value = "%" + bluePrintName + "%";
                command.Parameters.Add("@userId", OleDbType.Integer).Value = userId;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DTO.BluePrint bluePrint = new DTO.BluePrint();
                    bluePrint.bluePrintId = (int)reader["bluePrintId"];
                    bluePrint.bluePrintName = reader["bluePrintName"].ToString();
                    bluePrint.Path = reader["Path"].ToString();
                    bluePrint.dateCreatedBluePrint = (DateTime)reader["dateCreatedBluePrint"];
                    bluePrint.userId = (int)reader["userId"];
                    list.Add(bluePrint);
                }
                ConnectoR.Close();
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }


        public int GetBluePrintId(DTO.BluePrint objBluePrint)
        {
            int result = 0;
            try
            {
                if (ConnectoR.State != System.Data.ConnectionState.Open) { ConnectoR.Open(); }
                OleDbCommand command = new OleDbCommand("SELECT bluePrintId FROM BluePrint WHERE bluePrintName = @bluePrintName AND userId = @userId", ConnectoR);
                command.Parameters.Add("@bluePrintName", OleDbType.VarChar).Value = objBluePrint.bluePrintName;
                command.Parameters.Add("@userId", OleDbType.Integer).Value = objBluePrint.userId;
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    result = (int)reader["bluePrintId"];
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

        public string GetBluePrintName(int bluePrintId)
        {
            string result = "";
            try
            {
                if (ConnectoR.State != System.Data.ConnectionState.Open) { ConnectoR.Open(); }
                OleDbCommand command = new OleDbCommand("SELECT bluePrintName FROM BluePrint WHERE bluePrintId = @bluePrintId", ConnectoR);
                command.Parameters.Add("@bluePrintId", OleDbType.Integer).Value = bluePrintId;
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

        public string GetPath(int bluePrintId)
        {
            string result = "";
            try
            {
                if (ConnectoR.State != System.Data.ConnectionState.Open) { ConnectoR.Open(); }
                OleDbCommand command = new OleDbCommand("SELECT Path FROM BluePrint WHERE bluePrintId = @bluePrintId", ConnectoR);
                command.Parameters.Add("@bluePrintId", OleDbType.Integer).Value = bluePrintId;
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

        public void UpdateDateCreatedBluePrint(int bluePrintId, DateTime dateCreatedBluePrint)
        {
            try
            {
                if (ConnectoR.State != System.Data.ConnectionState.Open) { ConnectoR.Open(); }
                OleDbCommand command = new OleDbCommand("UPDATE BluePrint SET dateCreatedBluePrint = @dateCreatedBluePrint WHERE bluePrintId = @bluePrintId", ConnectoR);
                command.Parameters.Add("@dateCreatedBluePrint", OleDbType.Date).Value = dateCreatedBluePrint;
                command.Parameters.Add("@bluePrintId", OleDbType.Integer).Value = bluePrintId;
                command.ExecuteNonQuery();
                ConnectoR.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public DateTime GetDateCreatedBluePrint(int bluePrintId)
        {
            DateTime result = new DateTime();
            try
            {
                if (ConnectoR.State != System.Data.ConnectionState.Open) { ConnectoR.Open(); }
                OleDbCommand command = new OleDbCommand("SELECT dateCreatedBluePrint FROM BluePrint WHERE bluePrintId = @bluePrintId", ConnectoR);
                command.Parameters.Add("@bluePrintId", OleDbType.Integer).Value = bluePrintId;
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    result = (DateTime)reader["dateCreatedBluePrint"];
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
