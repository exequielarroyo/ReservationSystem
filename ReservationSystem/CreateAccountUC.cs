using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationSystem
{
    public partial class CreateAccountUC : UserControl
    {
        public CreateAccountUC()
        {
            InitializeComponent();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (NumberTextBox.Text != "Mobile or phone number")
            {
                Database.Command("INSERT INTO USER(userName, userPassword,userFirstName, userLastName, userNumber, userSex, userBirthdate, userEmail, userType) VALUE('" + UserNameTextBox.Text + "', '" + PasswordTextBox.Text + "', '" + FirstnameTextBox.Text + "', '" + LastnameTextBox.Text + "', '" + NumberTextBox.Text + "', '" + SexComboBox.Text + "', '" + BirthdatePicker.Text + "', '" + EmailTextBox.Text + "', '" + "Customer" + "');");
            }
        }

        private void CreateAccountUC_Load(object sender, EventArgs e)
        {
            BirthdatePicker.MaxDate = DateTime.Now;
        }
    }
}
