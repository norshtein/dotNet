using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Final.Service
{
    public class Connection
    {
        private static MySqlConnection conn = null;
        public static MySqlConnection getInstance()
        {
            if (Connection.conn == null)
                conn = new MySqlConnection("server = 112.74.204.135;user id=root;password=sty970323;database=NET");
            return conn;
        }
        private Connection() {}
    }
}