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
            if (User.GetUser(UserNameTextBox.Text, PasswordTextBox.Text) && User.Type == "Manager")
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
                this.Close();
            }
            else if (User.GetUser(UserNameTextBox.Text, PasswordTextBox.Text) && User.Type == "Customer")
            {
                this.Hide();
                ClientForm clientForm = new ClientForm();
                clientForm.ShowDialog();
                this.Close();
            }
        }

        private void RegisterLink_Click(object sender, EventArgs e)
        {
            createAccountUC1.Visible = true;
        }

        private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (User.GetUser(UserNameTextBox.Text, PasswordTextBox.Text) && User.Type == "Manager")
                {
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
                    this.Close();
                }
                else if(User.GetUser(UserNameTextBox.Text, PasswordTextBox.Text) && User.Type == "Customer")
                {
                    this.Hide();
                    ClientForm clientForm = new ClientForm();
                    clientForm.ShowDialog();
                    this.Close();
                }
            }
        }

        private void UserNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (User.GetUser(UserNameTextBox.Text, PasswordTextBox.Text) && User.Type == "Manager")
                {
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
                    this.Close();
                }
                else if (User.GetUser(UserNameTextBox.Text, PasswordTextBox.Text) && User.Type == "Customer")
                {
                    this.Hide();
                    ClientForm clientForm = new ClientForm();
                    clientForm.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
