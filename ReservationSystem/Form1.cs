using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ReservationSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        
        MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;database=reservationsystem");
        private void LogInButton_Click(object sender, EventArgs e)
        {
            User.GetUser(UserNameTextBox.Text, PasswordTextBox.Text);
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }
    }
}
