using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationSystem
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }


        private static int lenght = 0;
        List<Card> cards = new List<Card>(lenght);
        
        private void ClientForm_Load(object sender, EventArgs e)
        {
            cards.Clear();
            lenght = int.Parse(Database.GetRoomLenght().Rows[0][0].ToString());

            FirstNameTextBox.Text = $"Hi {User.FirstName}";
            UserProfilePictureBox.Image = User.Picture;

            DataTable rooms = new DataTable();
            rooms = Database.GetRoomData();

            for (int i = 0; i < lenght; i++)
            {
                cards.Add(new Card());
                cards[i].ID = int.Parse(rooms.Rows[i][0].ToString());
                cards[i].Number = int.Parse(rooms.Rows[i][1].ToString());
                cards[i].PersonCount = int.Parse(rooms.Rows[i][2].ToString());
                cards[i].Status = rooms.Rows[i][3].ToString();
                cards[i].Price = Convert.ToDecimal(rooms.Rows[i][4].ToString());
                cards[i].Details = rooms.Rows[i][5].ToString();
                cards[i].OutDate = Convert.ToDateTime(rooms.Rows[i][6].ToString());
                cards[i].InDate = Convert.ToDateTime(rooms.Rows[i][7].ToString());
                MemoryStream stream = new MemoryStream((byte[])(rooms.Rows[i][8]));
                cards[i].Picture = Image.FromStream(stream);
            }

            DisplayCards(cards);
        }

        private void DisplayCards(List<Card> cards)
        {
            RoomNumber.Text = cards[0].Number.ToString();
            RoomStatus.Text = cards[0].Status;
            RoomPrice.Text = cards[0].Price.ToString();
            RoomDetails.Text = cards[0].Details;
            guna2PictureBox1.Image = cards[0].Picture;

            List<Cards> UCCards = new List<Cards>();

            for (int i = 1; i < lenght; i++)
            {
                UCCards.Add(new Cards());
                UCCards[i-1].gunaLabel1.Text = cards[i].Number.ToString();
                UCCards[i-1].gunaLabel2.Text = cards[i].Status;
                UCCards[i-1].gunaLabel3.Text = cards[i].Price.ToString();
                UCCards[i-1].gunaLabel4.Text = cards[i].Details;
                UCCards[i - 1].guna2PictureBox2.Image = cards[i].Picture;
                flowLayoutPanel1.Controls.Add(UCCards[i-1]);
            }
        }

        private void ScrollBar_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar.Maximum = flowLayoutPanel1.VerticalScroll.Maximum;
            
            flowLayoutPanel1.AutoScrollPosition = new Point(0, ScrollBar.Value);
        }

        private void FirstNameTextBox_Click(object sender, EventArgs e)
        {
            if (SignoutPanel.Visible)
                SignoutPanel.Visible = false;
            else
                SignoutPanel.Visible = true;
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
