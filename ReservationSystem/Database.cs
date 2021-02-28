using Guna.UI2.WinForms.Suite;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem
{
    public class Database
    {
        public static MySqlConnection Connection { get; set; } = new MySqlConnection("server=localhost;user id=root;database=reservationsystem");

        public static void Command(string MySqlCommand)
        {
            MySqlCommand command = new MySqlCommand(MySqlCommand, Connection);
            Connection.Open();
            command.ExecuteNonQuery();
            Connection.Close();
        }

        public static DataTable GetRoomData()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT room.roomID,room.roomNumber," +
                " room.roomPersonCount, room.roomStatus, room.roomPrice, room.roomDetails," +
                " room.roomOutDate, room.roomInDate, room.roomPicture FROM room;", Connection);
            DataTable data = new DataTable();
            adapter.Fill(data);

            return data;
        }

        public static DataTable GetRoomLenght()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT COUNT(*) FROM room;", Connection);
            DataTable data = new DataTable();
            adapter.Fill(data);

            return data;
        }
    }
}
