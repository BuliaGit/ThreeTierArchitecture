using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MyDAL
{
    public class DBHelper
    {
        //连接字符串
        private static string connStr = "";
        //数据库连接对象
        private static SqlConnection conn = null;
        //数据适配器
        public static SqlDataAdapter adp = null;

        /// <summary>
        /// 初始化数据库连接
        /// </summary>
        private static void InitConnection()
        {
            if (conn == null)
            {
                conn = new SqlConnection(connStr);
            }
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            if (conn.State == System.Data.ConnectionState.Broken)
            {
                conn.Close();
                conn.Open();
            }
        }

        /// <summary>
        /// 初始化sql
        /// </summary>
        /// <param name="sql"></param>
        public static void InitSql(string sql)
        {
            InitConnection();
            adp = new SqlDataAdapter(sql, conn);
        }

        /// <summary>
        /// 初始化sql和指令存储过程类型
        /// </summary>
        /// <param name="sql"></param>
        public static void InitProc(string sql)
        {
            InitConnection();
            adp = new SqlDataAdapter(sql, conn);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
        }

        /// <summary>
        /// 设置sql语句参数值(默认输入参数)
        /// </summary>
        /// <param name="paramterName"></param>
        /// <param name="value"></param>
        public static void SetParameter(string paramterName, object value)
        {
            if (value == null)
                value = DBNull.Value;
            SqlParameter sqlParameter = new SqlParameter("@" + paramterName.Trim(), value);
            adp.SelectCommand.Parameters.Add(sqlParameter);
        }

        /// <summary>
        /// 设置sql语句输出参数（非字符串类型）
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="dbType"></param>
        public static void SetOutParameter(string parameterName, SqlDbType dbType)
        {
            SqlParameter sqlParameter = new SqlParameter("@" + parameterName.Trim(), dbType);
            sqlParameter.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(sqlParameter);
        }

        /// <summary>
        /// 设置sql语句输出参数（字符串类型）
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="dbType"></param>
        /// <param name="size"></param>
        public static void SetOutParameter(string parameterName, SqlDbType dbType, int size)
        {
            SqlParameter sqlParameter = new SqlParameter("@" + parameterName.Trim(), dbType, size);
            sqlParameter.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(sqlParameter);
        }

        /// <summary>
        /// 设置sql语句输入输出参数（非字符串类型）
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="value"></param>
        /// <param name="dbType"></param>
        public static void SetInOutParameter(string parameterName, object value, SqlDbType dbType)
        {
            SqlParameter sqlParameter = new SqlParameter("@" + parameterName.Trim(), dbType);
            sqlParameter.Direction = ParameterDirection.InputOutput;
            if (value == null)
                value = DBNull.Value;
            sqlParameter.Value = value;
            adp.SelectCommand.Parameters.Add(sqlParameter);
        }

        /// <summary>
        /// 设置sql语句输入输出参数（字符串类型）
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="value"></param>
        /// <param name="dbType"></param>
        /// <param name="size"></param>
        public static void SetInOutParameter(string parameterName, object value, SqlDbType dbType, int size)
        {
            SqlParameter sqlParameter = new SqlParameter("@" + parameterName.Trim(), dbType, size);
            sqlParameter.Direction = ParameterDirection.InputOutput;
            if (value == null)
                value = DBNull.Value;
            sqlParameter.Value = value;
            adp.SelectCommand.Parameters.Add(sqlParameter);
        }

        /// <summary>
        /// 获取参数的值
        /// </summary>
        /// <param name="parameterName"></param>
        /// <returns></returns>
        public static object GetParameter(string parameterName)
        {
            return adp.SelectCommand.Parameters["@" + parameterName.Trim()].Value;
        }


        /// <summary>
        /// 执行查询语句
        /// </summary>
        /// <returns></returns>
        public static DataTable ExecuteQuery()
        {
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            DaoClose();
            return dataTable;
        }


        /// <summary>
        /// 执行非查询语句（增删改）
        /// </summary>
        /// <returns></returns>
        public static int ExecuteNonQuery()
        {
            int result = adp.SelectCommand.ExecuteNonQuery();
            DaoClose();
            return result;
        }


        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public static void DaoClose()
        {
            conn.Close();
        }
    }
}
