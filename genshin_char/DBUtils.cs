using MySql.Data.MySqlClient;

namespace genshin_char
{
    internal class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "genshin";
            string user = "root";
            string password = "root";

            return DBMySQLUtils.GetDBConnection(host, port, database, user, password);
        }
    }
}