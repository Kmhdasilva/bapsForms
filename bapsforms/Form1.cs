using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bapsforms
{
    public partial class Form1 : Form
    {
        private static List<Room> rooms = new List<Room>();
        string MyConString = "SERVER=localhost;" + "DATABASE=baps;" + "UID=root;" + "PASSWORD=;";

        public Form1()
        {
            InitializeComponent();
            database_connection();
            CreateButtons();
        }

       private void database_connection()
        {
            MySqlConnection databaseConnection = new MySqlConnection(MyConString);
            MySqlCommand commandDatabase = databaseConnection.CreateCommand();
            MySqlDataReader Reader;
            commandDatabase.CommandText = "SELECT * FROM tbl_rooms";
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
