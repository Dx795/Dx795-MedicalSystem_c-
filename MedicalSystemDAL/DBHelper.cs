using MedicalSystemModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystemDAL
{
    class DBHelper
    {
        private static SqlConnection connection;

        public static SqlConnection Connection
        {
            get
            {
                string ConnStr = "Data Source=" + Config.Ip + ";Initial Catalog=Medical system;Persist Security Info=True;User ID=sa;Password=Jinx13850526746";
                if (connection == null)
                {
                    connection = new SqlConnection(ConnStr);
                    connection.Open();
                }
                else if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                else if (connection.State == System.Data.ConnectionState.Broken)
                {
                    connection.Close();
                    connection.Open();
                }
                return DBHelper.connection;
            }

        }

        //读取信息
        public static SqlDataReader ReadInfo(String sqlstr)
        {
            SqlCommand cmd = new SqlCommand(sqlstr, Connection);
            return cmd.ExecuteReader();
        }

        //增添信息
        public static object InsertInfoRmation(String sqlstr)
        {
            SqlCommand cmd = new SqlCommand(sqlstr, Connection);
            return cmd.ExecuteNonQuery();
        }
        //查询信息
        public static object SelectInfoRmation(String sqlstr)
        {
            SqlCommand cmd = new SqlCommand(sqlstr, Connection);
            return cmd.ExecuteScalar();
        }

        //删除相应信息
        public static object DeleteInfoRmation(String sqlstr)
        {
            SqlCommand cmd = new SqlCommand(sqlstr, Connection);
            return cmd.ExecuteNonQuery();
        }

        //更新
        public static int UpdateInfoRmation(String sqlstr)
        {
            SqlCommand cmd = new SqlCommand(sqlstr, Connection);
            return cmd.ExecuteNonQuery();
        }

        //龙 用
        public static DataSet ExcuteDataSet(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=" + Config.Ip + ";Initial Catalog=Medical system;Persist Security Info=True;User ID=sa;Password=Jinx13850526746"))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = sql;
                    foreach (SqlParameter parameter in parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    return ds;
                }
            }
        }
        //龙 用
        public static DataSet ExcuteDataSet(string sql)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=" + Config.Ip + ";Initial Catalog=Medical system;Persist Security Info=True;User ID=sa;Password=Jinx13850526746"))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = sql;
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    return ds;
                }
            }
        }
    }
}
