using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFMSDLL
{
    public class DBUtility
    {
        /// <summary>
        /// 
        /// </summary>
        static  string connectString = "Server=localhost;Database=PFMS;Trusted_Connection=SSPI";
        public static DataTable GetData(string SQL)
        {
            SqlConnection mycon = new SqlConnection(connectString);
            mycon.Open();
            SqlDataAdapter sql = new SqlDataAdapter(SQL, mycon);
            DataSet result = new DataSet();
            sql.Fill(result);
            mycon.Close();
            return result.Tables[0];
        }
        public static int ExcuteSQL(string SQL)
        {
            SqlConnection mycon = new SqlConnection(connectString);
            mycon.Open();
            SqlCommand myda = new SqlCommand(SQL, mycon);
            int result = myda.ExecuteNonQuery();
            mycon.Close();
            return result;
        }
        public  static SqlParameter[] ProceureToParameter(string ProName, SqlParameter[] parm)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(connectString);
            SqlCommand cmd = new SqlCommand()
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = ProName
            };
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                cmd.Connection = con;
                for (int i = 0; i < parm.Length; i++)
                {
                    cmd.Parameters.Add(parm[i]);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Dispose();
                cmd.Parameters.Clear();
                cmd.Dispose();
            }
            return parm;
        }
        public static DataSet ProceureToTable(string ProName, SqlParameter[] parm)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dr = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(connectString);
            SqlCommand cmd = new SqlCommand()
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = ProName
            };
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                cmd.Connection = con;
                for (int i = 0; i < parm.Length; i++)
                {
                    cmd.Parameters.Add(parm[i]);
                }
                dr.SelectCommand = cmd;
                //cmd.ExecuteNonQuery();
                dr.Fill(ds);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Dispose();
                cmd.Parameters.Clear();
                cmd.Dispose();
            }
            return ds;
        }

    }
}
