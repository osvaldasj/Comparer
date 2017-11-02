using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SQLite;

namespace WebService
{
    public class DatabaseManager
    {

        private SQLiteConnection _connection;

        public DatabaseManager()
        {
            SQLiteConnection.CreateFile("Database.db");
            _connection = new SQLiteConnection("Data Source=Database.db;Version=3;");
            _connection.Open();
        }

        public void asdascsd()
        {
            SQLiteCommand com = new SQLiteCommand("kodas sql kalba query", _connection);
            SQLiteDataReader reader = com.ExecuteReader();
            //com.ExecuteNonQuery();
            while (reader.Read())
                Console.WriteLine("Name: " + reader["Name"] + " Price: " + reader["Price"]);
        }


    }
}