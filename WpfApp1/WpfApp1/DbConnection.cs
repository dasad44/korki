﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    class DbConnection
    {
        private string connectionString = "datasource=127.0.0.1; port=3306; username=root; password=; database=zadanko; CharSet=utf8";

        public string[] connectToDB(string query, List<string> reserveList)
        {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            OpenConnection(databaseConnection);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // As our database, the array will contain : ID 0, FIRST_NAME 1,LAST_NAME 2, ADDRESS 3
                        reserveList.Add(reader.GetString(0));
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                    return null;
                }
                CloseConnection(databaseConnection);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            return null;
        }

        public string[] Executequery(string query)
        {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            OpenConnection(databaseConnection);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader = commandDatabase.ExecuteReader();

            CloseConnection(databaseConnection);

            return null;
        }


        private void CloseConnection(MySqlConnection databaseConnection)
        {
            databaseConnection.Close();
        }

        private void OpenConnection(MySqlConnection databaseConnection)
        {
            try
            {
                databaseConnection.Open();
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
            }
        }
    }
}
