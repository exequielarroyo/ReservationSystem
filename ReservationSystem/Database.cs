using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
    }
}
