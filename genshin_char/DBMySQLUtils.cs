using System;
using MySql.Data.MySqlClient;

namespace genshin_char
{
    internal class DBMySQLUtils
    {
        public static MySqlConnection GetDBConnection(string host, int port, string database, string user, string password)
        {
            String connString = $"Server={host};database={database};port={port};user={user};password={password};";
            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }
    }
}