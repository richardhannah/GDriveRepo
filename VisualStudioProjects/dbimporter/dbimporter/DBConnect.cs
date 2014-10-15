using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace dbimporter
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        
        public DBConnect(string server, string uid, string password)
        {
            database = "test";
            connection = new MySqlConnection("SERVER=" + server + ";DATABASE=" + database + ";UID=" + uid + ";PASSWORD=" + password);
        
        }

        public DBConnect(string server, string database, string uid, string password)
        {
            connection = new MySqlConnection("SERVER=" + server + ";DATABASE=" + database + ";UID=" + uid + ";PASSWORD=" + password);
        
        }

        public List<string> getTableSchema(string table)
        {
            connection.Open();

            List<string> result = new List<string>();
            string queryString = "describe " + table;

            MySqlCommand cmd = new MySqlCommand(queryString, connection);

            MySqlDataReader readData = cmd.ExecuteReader();

            while (readData.Read())
            {
                result.Add(readData["Type"].ToString());
            }


            

            connection.Close();
            return result;
        }

        

        public List<string> Select(string querystring)
        {
            List<string> result = new List<string>();

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(querystring, connection);

            MySqlDataReader readData = cmd.ExecuteReader();

            while (readData.Read())
            {
                result.Add(readData["snum"].ToString());
            }

            connection.Close();
            return result;
        }
    }
}
