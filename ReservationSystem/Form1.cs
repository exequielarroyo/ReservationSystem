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

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if(User.GetUser(UserNameTextBox.Text, PasswordTextBox.Text))
            {
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.Show();
            }
        }
    }
}
