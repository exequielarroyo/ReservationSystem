using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ReservationSystem
{
    public static class User
    {
        static MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;database=reservationsystem");

        public static int ID { get; set; }
        public static string Name { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string Number { get; set; }
        public static string Sex { get; set; }
        public static DateTime Birthdate { get; set; }
        public static string Email { get; set; }
        public static string Type { get; set; }
        public static Image Picture { get; set; }

        public static bool GetUser(string username, string password)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT COUNT(*) FROM user" +
                " WHERE (user.userName = '" + username + "' " +
                "AND user.userPassword = '" + password + "') OR (user.userEmail = '" + username + "'" +
                " AND user.userPassword = '" + password + "') " +
                "OR (user.userNumber = '" + username + "' AND user.userPassword = '" + password + "');", connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            int count = int.Parse(data.Rows[0][0].ToString());

            if (count == 1)
            {
                MySqlDataAdapter adapterGetUser = new MySqlDataAdapter("SELECT user.userID, user.userName, user.userFirstName, user.userLastName, " +
                    "user.userNumber, user.userSex, user.userBirthdate, user.userEmail, user.userType, user.userPicture FROM user WHERE (user." +
                    "userName = '" + username + "' AND user.userPassword = '" + password + "') OR (user.userEmail = '" + username + "' AND user.userPas" +
                    "sword = '" + password + "') OR (user.userNumber = '" + username + "' AND user.userPassword = '" + password + "');", connection);
                DataTable user = new DataTable();
                adapterGetUser.Fill(user);

                ID = int.Parse(user.Rows[0][0].ToString());
                Name = user.Rows[0][1].ToString();
                FirstName = user.Rows[0][2].ToString();
                LastName = user.Rows[0][3].ToString();
                Number = user.Rows[0][4].ToString();
                Sex = user.Rows[0][5].ToString();
                Birthdate = Convert.ToDateTime(user.Rows[0][6].ToString());
                Email = user.Rows[0][7].ToString();
                Type = user.Rows[0][8].ToString();
                MemoryStream memoryStream = new MemoryStream((byte[])user.Rows[0][9]);
                Picture = Image.FromStream(memoryStream);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
