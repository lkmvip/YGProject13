namespace LoginServer.DbClss
{
    using LoginServer;
    using System;
    using System.Collections;
    using System.Data;
    using System.Data.SqlClient;

    public class DBA
    {
        static DBA()
        {
            ZYXDNGuarder.Startup();
        }

        public static int ExeSqlCommand(string sqlCommand)
        {
            int num;
            using (SqlConnection connection = new SqlConnection(getstrConnection(null)))
            {
                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    int num2 = -1;
                    try
                    {
                        connection.Open();
                    }
                    catch
                    {
                        return -1;
                    }
                    try
                    {
                        num2 = command.ExecuteNonQuery();
                    }
                    catch (Exception exception)
                    {
                        Form1.WriteLine(1, "DBA数据层_错误" + exception.Message);
                    }
                    command.Dispose();
                    connection.Close();
                    connection.Dispose();
                    num = num2;
                }
            }
            return num;
        }

        public static int ExeSqlCommand(string sqlCommand, string server)
        {
            int num;
            using (SqlConnection connection = new SqlConnection(getstrConnection(server)))
            {
                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    int num2 = -1;
                    try
                    {
                        connection.Open();
                    }
                    catch
                    {
                        return -1;
                    }
                    try
                    {
                        num2 = command.ExecuteNonQuery();
                    }
                    catch (Exception exception)
                    {
                        Form1.WriteLine(1, "DBA数据层_错误" + exception.Message);
                    }
                    command.Dispose();
                    connection.Close();
                    connection.Dispose();
                    num = num2;
                }
            }
            return num;
        }

        public static int ExeSqlCommand(string sqlCommand, ref Exception exception, string db)
        {
            int num;
            using (SqlConnection connection = new SqlConnection(getstrConnection(null)))
            {
                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    try
                    {
                        connection.Open();
                    }
                    catch (Exception exception2)
                    {
                        exception = exception2;
                        return -1;
                    }
                    int num2 = command.ExecuteNonQuery();
                    command.Dispose();
                    connection.Close();
                    connection.Dispose();
                    num = num2;
                }
            }
            return num;
        }

        public static DataTable GetDBToDataTable(string sqlCommand)
        {
            DataTable table;
            using (SqlConnection connection = new SqlConnection(getstrConnection(null)))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    using (adapter.SelectCommand = new SqlCommand(sqlCommand, connection))
                    {
                        try
                        {
                            connection.Open();
                        }
                        catch
                        {
                            return null;
                        }
                        DataTable dataTable = new DataTable();
                        try
                        {
                            adapter.Fill(dataTable);
                        }
                        catch (Exception exception)
                        {
                            Form1.WriteLine(1, "DBA数据层_错误" + exception.Message);
                        }
                        adapter.Dispose();
                        connection.Close();
                        connection.Dispose();
                        table = dataTable;
                    }
                }
            }
            return table;
        }

        public static DataTable GetDBToDataTable(string sqlCommand, string server)
        {
            DataTable table;
            using (SqlConnection connection = new SqlConnection(getstrConnection(server)))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    using (adapter.SelectCommand = new SqlCommand(sqlCommand, connection))
                    {
                        try
                        {
                            connection.Open();
                        }
                        catch
                        {
                            return null;
                        }
                        DataTable dataTable = new DataTable();
                        try
                        {
                            adapter.Fill(dataTable);
                        }
                        catch (Exception exception)
                        {
                            Form1.WriteLine(1, "DBA数据层_错误" + exception.Message);
                        }
                        adapter.Dispose();
                        connection.Close();
                        connection.Dispose();
                        table = dataTable;
                    }
                }
            }
            return table;
        }

        public static DataRowCollection GetDBValue(string sqlCommand, string db) => 
            GetDBToDataTable(sqlCommand).Rows;

        public static ArrayList GetDBValue_1(string sqlCommand, string db)
        {
            ArrayList list;
            using (SqlConnection connection = new SqlConnection(getstrConnection(null)))
            {
                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    try
                    {
                        connection.Open();
                    }
                    catch
                    {
                        return null;
                    }
                    SqlDataReader reader = command.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        reader.Close();
                        reader.Dispose();
                        connection.Close();
                        connection.Dispose();
                        return null;
                    }
                    ArrayList list2 = new ArrayList();
                    if (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            list2.Add(reader[i]);
                        }
                    }
                    reader.Close();
                    reader.Dispose();
                    connection.Close();
                    connection.Dispose();
                    list = list2;
                }
            }
            return list;
        }

        public static ArrayList GetDBValue_2(string sqlCommand, string db)
        {
            ArrayList list;
            using (SqlConnection connection = new SqlConnection(getstrConnection(null)))
            {
                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    try
                    {
                        connection.Open();
                    }
                    catch
                    {
                        return null;
                    }
                    SqlDataReader reader = command.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        reader.Close();
                        reader.Dispose();
                        connection.Close();
                        connection.Dispose();
                        return null;
                    }
                    ArrayList list2 = new ArrayList();
                    while (reader.Read())
                    {
                        list2.Add(reader[0]);
                    }
                    reader.Close();
                    reader.Dispose();
                    connection.Close();
                    connection.Dispose();
                    list = list2;
                }
            }
            return list;
        }

        public static object GetDBValue_3(string sqlCommand)
        {
            object obj2;
            using (SqlConnection connection = new SqlConnection(getstrConnection(null)))
            {
                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    try
                    {
                        connection.Open();
                    }
                    catch
                    {
                        return null;
                    }
                    object obj3 = null;
                    try
                    {
                        obj3 = command.ExecuteScalar();
                    }
                    catch (Exception exception)
                    {
                        Form1.WriteLine(1, "DBA数据层_错误" + exception.Message);
                    }
                    command.Dispose();
                    connection.Close();
                    connection.Dispose();
                    obj2 = obj3;
                }
            }
            return obj2;
        }

        public static string getstrConnection(string db)
        {
            try
            {
                DbClass class2;
                if (db == null)
                {
                    db = "rxjhaccount";
                }
                if (World.Db.TryGetValue(db, out class2))
                {
                    return class2.SqlConnect;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}

