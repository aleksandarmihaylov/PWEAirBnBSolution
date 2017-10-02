using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PWEAirBnB.DAL
{
    public class BaseRepository
    {
        protected SqlConnection CreateConnection()
        {
            SqlConnection connection = new SqlConnection();
            connection = new SqlConnection();
            connection.ConnectionString = "Server=DESKTOP-PVFC580\\SQLEXPRESS;Database=PWEAirBNB;Integrated Security=SSPI;";
            return connection;
        }
    }
}