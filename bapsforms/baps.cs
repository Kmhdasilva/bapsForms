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
    public partial class baps : Form
    {
        private static List<Room> rooms = new List<Room>();
        string MyConString = "SERVER=localhost;" + "DATABASE=baps;" + "UID=root;" + "PASSWORD=;";

        public baps()
        {
            InitializeComponent();
            database_connection();
            CreateButtons();
        }

        private void CreateButtons()
        {
            int top = 50;
            int left = 100;

            foreach(var room in rooms)
            {
                Button roomButton = new Button();
                roomButton.Left = left;
                roomButton.Top = top;
                roomButton.Text = "";
                this.Controls.Add(roomButton);
                top += roomButton.Height + 2;
            }
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
