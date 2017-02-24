using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

namespace ESMonitor.DAL
{
    /// <summary>
    /// ���ݷ��ʳ��������
    /// Copyright (C) CMS
    /// </summary>
    public abstract class DbHelperSql
    {
        //���ݿ������ַ���(web.config������)�������ݿ��ʹ��DbHelperSQLP��ʵ��.
        public static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];

        #region ���÷���
        /// <summary>
        /// �ж��Ƿ����ĳ���ĳ���ֶ�
        /// </summary>
        /// <param name="tableName">������</param>
        /// <param name="columnName">������</param>
        /// <returns>�Ƿ����</returns>
        public static bool ColumnExists(string tableName, string columnName)
        {
            var sql = "select count(1) from syscolumns where [id]=object_id('" + tableName + "') and [name]='" + columnName + "'";
            var res = GetSingle(sql);
            if (res == null)
            {
                return false;
            }
            return Convert.ToInt32(res) > 0;
        }
        public static int GetMaxId(string fieldName, string tableName)
        {
            var strsql = "select max(" + fieldName + ")+1 from " + tableName;
            var obj = GetSingle(strsql);
            if (obj == null)
            {
                return 1;
            }
            else
            {
                return int.Parse(obj.ToString());
            }
        }
        public static bool Exists(string strSql)
        {
            var obj = GetSingle(strSql);
            int cmdresult;
            if ((Equals(obj, null)) || (Equals(obj, DBNull.Value)))
            {
                cmdresult = 0;
            }
            else
            {
                cmdresult = int.Parse(obj.ToString());
            }
            if (cmdresult == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// ���Ƿ����
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public static bool TabExists(string tableName)
        {
            var strsql = "select count(*) from sysobjects where id = object_id(N'[" + tableName + "]') and OBJECTPROPERTY(id, N'IsUserTable') = 1";
            //string strsql = "SELECT count(*) FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[" + TableName + "]') AND type in (N'U')";
            var obj = GetSingle(strsql);
            int cmdresult;
            if ((Equals(obj, null)) || (Equals(obj, DBNull.Value)))
            {
                cmdresult = 0;
            }
            else
            {
                cmdresult = int.Parse(obj.ToString());
            }
            if (cmdresult == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool Exists(string strSql, params SqlParameter[] cmdParms)
        {
            var obj = GetSingle(strSql, cmdParms);
            int cmdresult;
            if ((Equals(obj, null)) || (Equals(obj, DBNull.Value)))
            {
                cmdresult = 0;
            }
            else
            {
                cmdresult = int.Parse(obj.ToString());
            }
            if (cmdresult == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region  ִ�м�SQL���

        /// <summary>
        /// ִ��SQL��䣬����Ӱ��ļ�¼��
        /// </summary>
        /// <param name="sqlString">SQL���</param>
        /// <returns>Ӱ��ļ�¼��</returns>
        public static int ExecuteSql(string sqlString)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                using (var cmd = new SqlCommand(sqlString, connection))
                {
                    try
                    {
                        connection.Open();
                        var rows = cmd.ExecuteNonQuery();
                        return rows;
                    }
                    catch (SqlException)
                    {
                        connection.Close();
                        throw;
                    }
                }
            }
        }

        public static int ExecuteSqlByTime(string sqlString, int times)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                using (var cmd = new SqlCommand(sqlString, connection))
                {
                    try
                    {
                        connection.Open();
                        cmd.CommandTimeout = times;
                        var rows = cmd.ExecuteNonQuery();
                        return rows;
                    }
                    catch (SqlException)
                    {
                        connection.Close();
                        throw;
                    }
                }
            }
        }
      
        /// <summary>
        /// ִ��Sql��Oracle�Ļ������
        /// </summary>
        /// <param name="list">SQL�������б�</param>
        /// <param name="oracleCmdSqlList">Oracle�������б�</param>
        /// <returns>ִ�н�� 0-����SQL�������ʧ�� -1 ����Oracle�������ʧ�� 1-��������ִ�гɹ�</returns>
        public static int ExecuteSqlTran(List<CommandInfo> list, List<CommandInfo> oracleCmdSqlList)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SqlCommand {Connection = conn};
                var tx = conn.BeginTransaction();
                cmd.Transaction = tx;
                try
                {
                    foreach (var myDe in list)
                    {
                        var cmdText = myDe.CommandText;
                        var cmdParms = (SqlParameter[])myDe.Parameters;
                        PrepareCommand(cmd, conn, tx, cmdText, cmdParms);
                        if (myDe.EffentNextType == EffentNextType.SolicitationEvent)
                        {
                            if (myDe.CommandText.ToLower().IndexOf("count(", StringComparison.Ordinal) == -1)
                            {
                                tx.Rollback();
                                throw new Exception("Υ��Ҫ��"+myDe.CommandText+"�������select count(..�ĸ�ʽ");
                                //return 0;
                            }

                            var obj = cmd.ExecuteScalar();
                            if (obj == null && null == DBNull.Value)
                            {
                            }
                            var isHave = Convert.ToInt32(obj) > 0;
                            if (isHave)
                            {
                                //�����¼�
                                myDe.OnSolicitationEvent();
                            }
                        }
                        if (myDe.EffentNextType == EffentNextType.WhenHaveContine || myDe.EffentNextType == EffentNextType.WhenNoHaveContine)
                        {
                            if (myDe.CommandText.ToLower().IndexOf("count(", StringComparison.Ordinal) == -1)
                            {
                                tx.Rollback();
                                throw new Exception("SQL:Υ��Ҫ��" + myDe.CommandText + "�������select count(..�ĸ�ʽ");
                                //return 0;
                            }

                            var obj = cmd.ExecuteScalar();
                            if (obj == null && null == DBNull.Value)
                            {
                            }
                            var isHave = Convert.ToInt32(obj) > 0;

                            if (myDe.EffentNextType == EffentNextType.WhenHaveContine && !isHave)
                            {
                                tx.Rollback();
                                throw new Exception("SQL:Υ��Ҫ��" + myDe.CommandText + "����ֵ�������0");
                                //return 0;
                            }
                            if (myDe.EffentNextType == EffentNextType.WhenNoHaveContine && isHave)
                            {
                                tx.Rollback();
                                throw new Exception("SQL:Υ��Ҫ��" + myDe.CommandText + "����ֵ�������0");
                                //return 0;
                            }
                            continue;
                        }
                        var val = cmd.ExecuteNonQuery();
                        if (myDe.EffentNextType == EffentNextType.ExcuteEffectRows && val == 0)
                        {
                            tx.Rollback();
                            throw new Exception("SQL:Υ��Ҫ��" + myDe.CommandText + "������Ӱ����");
                            //return 0;
                        }
                        cmd.Parameters.Clear();
                    }
                    tx.Commit();
                    return 1;
                }
                catch (SqlException)
                {
                    tx.Rollback();
                    throw;
                }
                catch (Exception)
                {
                    tx.Rollback();
                    throw;
                }
            }
        }        
        /// <summary>
        /// ִ�ж���SQL��䣬ʵ�����ݿ�����
        /// </summary>
        /// <param name="sqlStringList">����SQL���</param>		
        public static int ExecuteSqlTran(List<String> sqlStringList)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandTimeout = 600
                };
                //10���ӳ�ʱ
                var tx = conn.BeginTransaction();
                cmd.Transaction = tx;
                try
                {
                    var count = 0;
                    for (var n = 0; n < sqlStringList.Count; n++)
                    {
                        var strsql = sqlStringList[n];
                        if (strsql.Trim().Length > 1)
                        {
                            cmd.CommandText = strsql;
                            count += cmd.ExecuteNonQuery();
                        }
                    }
                    tx.Commit();
                    return count;
                }
                catch
                {
                    tx.Rollback();
                    return 0;
                }
            }
        }

        /// <summary>
        /// ִ�ж���SQL��䣬ʵ�����ݿ�����
        /// </summary>
        /// <param name="sqlStringList">����SQL���</param>		
        public static void ExecuteSqlTran(ArrayList sqlStringList)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SqlCommand {Connection = conn};
                var tx = conn.BeginTransaction();
                cmd.Transaction = tx;
                try
                {
                    for (var n = 0; n < sqlStringList.Count; n++)
                    {
                        var strsql = sqlStringList[n].ToString();
                        if (strsql.Trim().Length > 1)
                        {
                            cmd.CommandText = strsql;
                            cmd.ExecuteNonQuery();
                        }
                    }
                    tx.Commit();
                }
                catch (SqlException e)
                {
                    tx.Rollback();
                    throw new Exception(e.Message);
                }
            }
        }
        /// <summary>
        /// ִ�д�һ���洢���̲����ĵ�SQL��䡣
        /// </summary>
        /// <param name="sqlString">SQL���</param>
        /// <param name="content">��������,����һ���ֶ��Ǹ�ʽ���ӵ����£���������ţ�����ͨ�������ʽ���</param>
        /// <returns>Ӱ��ļ�¼��</returns>
        public static int ExecuteSql(string sqlString, string content)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var cmd = new SqlCommand(sqlString, connection);
                var myParameter = new SqlParameter("@content", SqlDbType.NText) {Value = content};
                cmd.Parameters.Add(myParameter);
                try
                {
                    connection.Open();
                    var rows = cmd.ExecuteNonQuery();
                    return rows;
                }
                finally
                {
                    cmd.Dispose();
                    connection.Close();
                }
            }
        }
        /// <summary>
        /// ִ�д�һ���洢���̲����ĵ�SQL��䡣
        /// </summary>
        /// <param name="sqlString">SQL���</param>
        /// <param name="content">��������,����һ���ֶ��Ǹ�ʽ���ӵ����£���������ţ�����ͨ�������ʽ���</param>
        /// <returns>Ӱ��ļ�¼��</returns>
        public static object ExecuteSqlGet(string sqlString, string content)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var cmd = new SqlCommand(sqlString, connection);
                var myParameter = new SqlParameter("@content", SqlDbType.NText) {Value = content};
                cmd.Parameters.Add(myParameter);
                try
                {
                    connection.Open();
                    var obj = cmd.ExecuteScalar();
                    if ((Equals(obj, null)) || (Equals(obj, DBNull.Value)))
                    {
                        return null;
                    }
                    else
                    {
                        return obj;
                    }
                }
                finally
                {
                    cmd.Dispose();
                    connection.Close();
                }
            }
        }
        /// <summary>
        /// �����ݿ������ͼ���ʽ���ֶ�(������������Ƶ���һ��ʵ��)
        /// </summary>
        /// <param name="strSql">SQL���</param>
        /// <param name="fs">ͼ���ֽ�,���ݿ���ֶ�����Ϊimage�����</param>
        /// <returns>Ӱ��ļ�¼��</returns>
        public static int ExecuteSqlInsertImg(string strSql, byte[] fs)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var cmd = new SqlCommand(strSql, connection);
                var myParameter = new SqlParameter("@fs", SqlDbType.Image) {Value = fs};
                cmd.Parameters.Add(myParameter);
                try
                {
                    connection.Open();
                    var rows = cmd.ExecuteNonQuery();
                    return rows;
                }
                finally
                {
                    cmd.Dispose();
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// ִ��һ�������ѯ�����䣬���ز�ѯ�����object����
        /// </summary>
        /// <param name="sqlString">�����ѯ������</param>
        /// <returns>��ѯ�����object��</returns>
        public static object GetSingle(string sqlString)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                using (var cmd = new SqlCommand(sqlString, connection))
                {
                    try
                    {
                        connection.Open();
                        var obj = cmd.ExecuteScalar();
                        if ((Equals(obj, null)) || (Equals(obj, DBNull.Value)))
                        {
                            return null;
                        }
                        return obj;
                    }
                    catch (SqlException)
                    {
                        connection.Close();
                        throw;
                    }
                }
            }
        }
        public static object GetSingle(string sqlString, int times)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                using (var cmd = new SqlCommand(sqlString, connection))
                {
                    try
                    {
                        connection.Open();
                        cmd.CommandTimeout = times;
                        var obj = cmd.ExecuteScalar();
                        if ((Equals(obj, null)) || (Equals(obj, DBNull.Value)))
                        {
                            return null;
                        }
                        else
                        {
                            return obj;
                        }
                    }
                    catch (SqlException)
                    {
                        connection.Close();
                        throw;
                    }
                }
            }
        }
        /// <summary>
        /// ִ�в�ѯ��䣬����SqlDataReader ( ע�⣺���ø÷�����һ��Ҫ��SqlDataReader����Close )
        /// </summary>
        /// <param name="strSql">��ѯ���</param>
        /// <returns>SqlDataReader</returns>
        public static SqlDataReader ExecuteReader(string strSql)
        {
            var connection = new SqlConnection(ConnectionString);
            var cmd = new SqlCommand(strSql, connection);
            connection.Open();
            var myReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return myReader;
        }
        /// <summary>
        /// ִ�в�ѯ��䣬����DataSet
        /// </summary>
        /// <param name="sqlString">��ѯ���</param>
        /// <returns>DataSet</returns>
        public static DataSet Query(string sqlString)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var ds = new DataSet();
                try
                {
                    connection.Open();
                    var command = new SqlDataAdapter(sqlString, connection);
                    command.Fill(ds, "ds");
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                return ds;
            }
        }
        public static DataSet Query(string sqlString, int times)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var ds = new DataSet();
                try
                {
                    connection.Open();
                    var command = new SqlDataAdapter(sqlString, connection) {SelectCommand = {CommandTimeout = times}};
                    command.Fill(ds, "ds");
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                return ds;
            }
        }



        #endregion

        #region ִ�д�������SQL���

        /// <summary>
        /// ִ��SQL��䣬����Ӱ��ļ�¼��
        /// </summary>
        /// <param name="sqlString">SQL���</param>
        /// <param name="cmdParms"></param>
        /// <returns>Ӱ��ļ�¼��</returns>
        public static int ExecuteSql(string sqlString, params SqlParameter[] cmdParms)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    PrepareCommand(cmd, connection, null, sqlString, cmdParms);
                    var rows = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    return rows;
                }
            }
        }


        /// <summary>
        /// ִ�ж���SQL��䣬ʵ�����ݿ�����
        /// </summary>
        /// <param name="sqlStringList">SQL���Ĺ�ϣ��keyΪsql��䣬value�Ǹ�����SqlParameter[]��</param>
        public static void ExecuteSqlTran(Hashtable sqlStringList)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    var cmd = new SqlCommand();
                    try
                    {
                        //ѭ��
                        foreach (DictionaryEntry myDe in sqlStringList)
                        {
                            var cmdText = myDe.Key.ToString();
                            var cmdParms = (SqlParameter[])myDe.Value;
                            PrepareCommand(cmd, conn, trans, cmdText, cmdParms);
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                        }
                        trans.Commit();
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }

        /// <summary>
        /// ִ�ж���SQL��䣬ʵ�����ݿ�����
        /// </summary>
        public static int ExecuteSqlTran(List<CommandInfo> cmdList)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    var cmd = new SqlCommand();
                    try
                    { var count = 0;
                        //ѭ��
                        foreach (var myDe in cmdList)
                        {
                            var cmdText = myDe.CommandText;
                            var cmdParms = (SqlParameter[])myDe.Parameters;
                            PrepareCommand(cmd, conn, trans, cmdText, cmdParms);
                           
                            if (myDe.EffentNextType == EffentNextType.WhenHaveContine || myDe.EffentNextType == EffentNextType.WhenNoHaveContine)
                            {
                                if (myDe.CommandText.ToLower().IndexOf("count(", StringComparison.Ordinal) == -1)
                                {
                                    trans.Rollback();
                                    return 0;
                                }

                                var obj = cmd.ExecuteScalar();
                                if (obj == null && null == DBNull.Value)
                                {
                                }
                                var isHave = Convert.ToInt32(obj) > 0;

                                if (myDe.EffentNextType == EffentNextType.WhenHaveContine && !isHave)
                                {
                                    trans.Rollback();
                                    return 0;
                                }
                                if (myDe.EffentNextType == EffentNextType.WhenNoHaveContine && isHave)
                                {
                                    trans.Rollback();
                                    return 0;
                                }
                                continue;
                            }
                            var val = cmd.ExecuteNonQuery();
                            count += val;
                            if (myDe.EffentNextType == EffentNextType.ExcuteEffectRows && val == 0)
                            {
                                trans.Rollback();
                                return 0;
                            }
                            cmd.Parameters.Clear();
                        }
                        trans.Commit();
                        return count;
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }
        /// <summary>
        /// ִ�ж���SQL��䣬ʵ�����ݿ�����
        /// </summary>
        /// <param name="sqlStringList">SQL���Ĺ�ϣ��keyΪsql��䣬value�Ǹ�����SqlParameter[]��</param>
        public static void ExecuteSqlTranWithIndentity(List<CommandInfo> sqlStringList)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    var cmd = new SqlCommand();
                    try
                    {
                        var indentity = 0;
                        //ѭ��
                        foreach (var myDe in sqlStringList)
                        {
                            var cmdText = myDe.CommandText;
                            var cmdParms = (SqlParameter[])myDe.Parameters;
                            foreach (var q in cmdParms)
                            {
                                if (q.Direction == ParameterDirection.InputOutput)
                                {
                                    q.Value = indentity;
                                }
                            }
                            PrepareCommand(cmd, conn, trans, cmdText, cmdParms);
                            cmd.ExecuteNonQuery();
                            foreach (var q in cmdParms)
                            {
                                if (q.Direction == ParameterDirection.Output)
                                {
                                    indentity = Convert.ToInt32(q.Value);
                                }
                            }
                            cmd.Parameters.Clear();
                        }
                        trans.Commit();
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }
        /// <summary>
        /// ִ�ж���SQL��䣬ʵ�����ݿ�����
        /// </summary>
        /// <param name="sqlStringList">SQL���Ĺ�ϣ��keyΪsql��䣬value�Ǹ�����SqlParameter[]��</param>
        public static void ExecuteSqlTranWithIndentity(Hashtable sqlStringList)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    var cmd = new SqlCommand();
                    try
                    {
                        var indentity = 0;
                        //ѭ��
                        foreach (DictionaryEntry myDe in sqlStringList)
                        {
                            var cmdText = myDe.Key.ToString();
                            var cmdParms = (SqlParameter[])myDe.Value;
                            foreach (var q in cmdParms)
                            {
                                if (q.Direction == ParameterDirection.InputOutput)
                                {
                                    q.Value = indentity;
                                }
                            }
                            PrepareCommand(cmd, conn, trans, cmdText, cmdParms);
                            cmd.ExecuteNonQuery();
                            foreach (var q in cmdParms)
                            {
                                if (q.Direction == ParameterDirection.Output)
                                {
                                    indentity = Convert.ToInt32(q.Value);
                                }
                            }
                            cmd.Parameters.Clear();
                        }
                        trans.Commit();
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }

        /// <summary>
        /// ִ��һ�������ѯ�����䣬���ز�ѯ�����object����
        /// </summary>
        /// <param name="sqlString">�����ѯ������</param>
        /// <param name="cmdParms"></param>
        /// <returns>��ѯ�����object��</returns>
        public static object GetSingle(string sqlString, params SqlParameter[] cmdParms)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    PrepareCommand(cmd, connection, null, sqlString, cmdParms);
                    var obj = cmd.ExecuteScalar();
                    cmd.Parameters.Clear();
                    if ((Equals(obj, null)) || (Equals(obj, DBNull.Value)))
                    {
                        return null;
                    }
                    return obj;
                }
            }
        }

        /// <summary>
        /// ִ�в�ѯ��䣬����SqlDataReader ( ע�⣺���ø÷�����һ��Ҫ��SqlDataReader����Close )
        /// </summary>
        /// <param name="sqlString"></param>
        /// <param name="cmdParms"></param>
        /// <returns>SqlDataReader</returns>
        public static SqlDataReader ExecuteReader(string sqlString, params SqlParameter[] cmdParms)
        {
            var connection = new SqlConnection(ConnectionString);
            var cmd = new SqlCommand();
            PrepareCommand(cmd, connection, null, sqlString, cmdParms);
            var myReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            cmd.Parameters.Clear();
            return myReader;
            //			finally
            //			{
            //				cmd.Dispose();
            //				connection.Close();
            //			}	

        }

        /// <summary>
        /// ִ�в�ѯ��䣬����DataSet
        /// </summary>
        /// <param name="sqlString">��ѯ���</param>
        /// <param name="cmdParms"></param>
        /// <returns>DataSet</returns>
        public static DataSet Query(string sqlString, params SqlParameter[] cmdParms)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var cmd = new SqlCommand();
                PrepareCommand(cmd, connection, null, sqlString, cmdParms);
                using (var da = new SqlDataAdapter(cmd))
                {
                    var ds = new DataSet();
                    try
                    {
                        da.Fill(ds, "ds");
                        cmd.Parameters.Clear();
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    return ds;
                }
            }
        }


        private static void PrepareCommand(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, string cmdText, SqlParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            if (trans != null)
                cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;//cmdType;
            if (cmdParms != null)
            {
                foreach (var parameter in cmdParms)
                {
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                        (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                    cmd.Parameters.Add(parameter);
                }
            }
        }

        #endregion

        #region �洢���̲���

        /// <summary>
        /// ִ�д洢���̣�����SqlDataReader ( ע�⣺���ø÷�����һ��Ҫ��SqlDataReader����Close )
        /// </summary>
        /// <param name="storedProcName">�洢������</param>
        /// <param name="parameters">�洢���̲���</param>
        /// <returns>SqlDataReader</returns>
        public static SqlDataReader RunProcedure(string storedProcName, IDataParameter[] parameters)
        {
            var connection = new SqlConnection(ConnectionString);
            connection.Open();
            var command = BuildQueryCommand(connection, storedProcName, parameters);
            command.CommandType = CommandType.StoredProcedure;
            var returnReader = command.ExecuteReader(CommandBehavior.CloseConnection);
            return returnReader;
            
        }


        /// <summary>
        /// ִ�д洢����
        /// </summary>
        /// <param name="storedProcName">�洢������</param>
        /// <param name="parameters">�洢���̲���</param>
        /// <param name="tableName">DataSet����еı���</param>
        /// <returns>DataSet</returns>
        public static DataSet RunProcedure(string storedProcName, IDataParameter[] parameters, string tableName)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var dataSet = new DataSet();
                connection.Open();
                var sqlDa = new SqlDataAdapter
                {
                    SelectCommand = BuildQueryCommand(connection, storedProcName, parameters)
                };
                sqlDa.Fill(dataSet, tableName);
                connection.Close();
                return dataSet;
            }
        }
        public static DataSet RunProcedure(string storedProcName, IDataParameter[] parameters, string tableName, int times)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var dataSet = new DataSet();
                connection.Open();
                var sqlDa = new SqlDataAdapter
                {
                    SelectCommand = BuildQueryCommand(connection, storedProcName, parameters)
                };
                sqlDa.SelectCommand.CommandTimeout = times;
                sqlDa.Fill(dataSet, tableName);
                connection.Close();
                return dataSet;
            }
        }


        /// <summary>
        /// ���� SqlCommand ����(��������һ���������������һ������ֵ)
        /// </summary>
        /// <param name="connection">���ݿ�����</param>
        /// <param name="storedProcName">�洢������</param>
        /// <param name="parameters">�洢���̲���</param>
        /// <returns>SqlCommand</returns>
        private static SqlCommand BuildQueryCommand(SqlConnection connection, string storedProcName, IDataParameter[] parameters)
        {
            var command = new SqlCommand(storedProcName, connection) {CommandType = CommandType.StoredProcedure};
            foreach (var dataParameter in parameters)
            {
                var parameter = (SqlParameter) dataParameter;
                if (parameter == null) continue;
                // ���δ����ֵ���������,���������DBNull.Value.
                if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                    (parameter.Value == null))
                {
                    parameter.Value = DBNull.Value;
                }
                command.Parameters.Add(parameter);
            }

            return command;
        }

        /// <summary>
        /// ִ�д洢���̣�����Ӱ�������		
        /// </summary>
        /// <param name="storedProcName">�洢������</param>
        /// <param name="parameters">�洢���̲���</param>
        /// <param name="rowsAffected">Ӱ�������</param>
        /// <returns></returns>
        public static int RunProcedure(string storedProcName, IDataParameter[] parameters, out int rowsAffected)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = BuildIntCommand(connection, storedProcName, parameters);
                rowsAffected = command.ExecuteNonQuery();
                var result = (int)command.Parameters["ReturnValue"].Value;
                connection.Close();
                return result;
            }
        }

        /// <summary>
        /// ���� SqlCommand ����ʵ��(��������һ������ֵ)	
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="storedProcName">�洢������</param>
        /// <param name="parameters">�洢���̲���</param>
        /// <returns>SqlCommand ����ʵ��</returns>
        private static SqlCommand BuildIntCommand(SqlConnection connection, string storedProcName, IDataParameter[] parameters)
        {
            var command = BuildQueryCommand(connection, storedProcName, parameters);
            command.Parameters.Add(new SqlParameter("ReturnValue",
                SqlDbType.Int, 4, ParameterDirection.ReturnValue,
                false, 0, 0, string.Empty, DataRowVersion.Default, null));
            return command;
        }
        #endregion

        #region SqlBulkCopy��ʽ�����������
        public static bool SqlBulkCopyInsert(string tableName, DataTable dt, SqlBulkCopyColumnMapping[] mapping)
        {
            bool flag;
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (var tran = connection.BeginTransaction()) 
                {
                    using (var sqlBulkCopy = new SqlBulkCopy(ConnectionString))
                    {
                        if (mapping != null)
                        {
                            foreach (var map in mapping) 
                            {
                                sqlBulkCopy.ColumnMappings.Add(map);  
                            }
                        }
                        sqlBulkCopy.DestinationTableName = tableName;
                        sqlBulkCopy.BatchSize = dt.Rows.Count;

                        try 
                        { 
                            sqlBulkCopy.WriteToServer(dt);//�������
                            tran.Commit();//�ύ���� 
                            flag = true;
                        }

                        catch 
                        { 
                            tran.Rollback();//�ع����� Bool = false; } } } }
                            flag = false; 
                        }
                    }
                }
            }
            return flag;
        }
        #endregion
    }
        
}