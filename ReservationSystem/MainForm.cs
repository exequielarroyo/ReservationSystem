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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FirstNameTextBox.Text = $"Hi {User.FirstName}";

            RoomDataGrid.DataSource = Database.GetRoomData();
        }

        private string ID;

        private void RoomDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ID = RoomDataGrid.SelectedRows[0].Cells[0].Value.ToString();
            RoomNumberTextbox.Text = RoomDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            PersonCountNumeric.Value = int.Parse(RoomDataGrid.SelectedRows[0].Cells[2].Value.ToString());
            string status = RoomDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            StatusComboBox.SelectedIndex = (status == "Available") ? 0 : 1;
            PriceTextBox.Text = RoomDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            DetailsTextBox.Text = RoomDataGrid.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            RoomNumberTextbox.Text = "Room number";
            PersonCountNumeric.Value = 0;
            StatusComboBox.SelectedIndex = -1;
            PriceTextBox.Text = "0.00";
            DetailsTextBox.Text = "Details";
            AddButton.Enabled = false;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Database.Command("DELETE FROM room WHERE room.roomID = '" + this.ID + "';");
            RoomDataGrid.DataSource = Database.GetRoomData();
        }

        private void RoomNumberTextbox_TextChanged(object sender, EventArgs e)
        {
            AddButton.Enabled = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < RoomDataGrid.RowCount; i++)
            {
                if (RoomNumberTextbox.Text == RoomDataGrid.Rows[i].Cells[1].Value.ToString())
                    count++;
            }
            if (count == 1)
            {
                Database.Command("UPDATE room SET room.roomNumber = '" + int.Parse(RoomNumberTextbox.Text) + "', room.roomPersonCount = '" + int.Parse(PersonCountNumeric.Value.ToString()) + "', room.roomStatus= '" + StatusComboBox.Text + "', room.roomPrice=" + Convert.ToDecimal(PriceTextBox.Text) + ", room.roomDetails='" + DetailsTextBox.Text + "' WHERE room.roomID = '" + this.ID + "';");
            }
            else
                Database.Command("INSERT INTO room(roomNumber, roomPersonCount, roomStatus, roomPrice, roomDetails)" + " VALUE('" + RoomNumberTextbox.Text + "', '" + PersonCountNumeric.Value + "', '" + StatusComboBox.Text + "', '" + Convert.ToDecimal(PriceTextBox.Text) + "', '" + DetailsTextBox.Text + "'); ");

            RoomDataGrid.DataSource = Database.GetRoomData();
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }

        private void FirstNameTextBox_Click(object sender, EventArgs e)
        {
            if (SignoutPanel.Visible)
                SignoutPanel.Visible = false;
            else
                SignoutPanel.Visible = true;
        }
    }
}
