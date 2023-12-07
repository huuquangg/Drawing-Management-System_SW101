using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using System.Data.OleDb;

namespace DataAcessTier
{
    public class DanhMucDAO: DBConnection
    {
        public DanhMucDAO() : base() { }
        public bool DeleteDanhMuc(string madm)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                OleDbCommand cmd = new OleDbCommand("DELETE FROM tbDanhMuc WHERE madm = @madm", conn);
                cmd.Parameters.Add("@madm", OleDbType.BSTR).Value = madm;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                conn.Close(); 
                return false;
            }
        }

        public DataTable GetAllDanhMuc()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM tbDanhMuc ORDER BY MaDm ASC", conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch(Exception)
            {
                conn.Close();
            }
            return null;
        }

        public bool CheckDanhMucByID(string strMaDM)
        {
            bool result = false;
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM tbDanhMuc WHERE MADM = @madm", conn);
                cmd.Parameters.Add("@madm", OleDbType.BSTR).Value = strMaDM;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    result = true;
                }
                conn.Close();
            }
            catch(Exception)
            {
                conn.Close();
            }
            return result;
        }
    }
}
