using Habanero.DB;
using ImTools;
using MySql.Data.MySqlClient;
using Stripe.Terminal;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bapsforms
{
    class Database_connect
    {

        private static List<Room> rooms = new List<Room>();
        string MyConString = "SERVER=localhost;" + "DATABASE=scannerapp;" + "UID=root;" + "PASSWORD=;";
        private void database_connection()
        {
            MySqlConnection databaseConnection = new MySqlConnection(MyConString);
            MySqlCommand commandDatabase = databaseConnection.CreateCommand();
            MySqlDataReader Reader;
            commandDatabase.CommandText = "SELECT * FROM Producten";
            databaseConnection.Open();
            Reader = commandDatabase.ExecuteReader();
            while (Reader.Read())
            {
                string thisrow = "";
                for (int i = 0; i < Reader.FieldCount; i++)
                    thisrow += Reader.GetValue(i).ToString() + ",";

                rooms.Add(new Room(
                    Reader.GetInt32("id"),
                    Reader.GetString("name"),
                    Reader.GetInt32("floor")
                ));
            }
            databaseConnection.Close();
        }
    }
}
