using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TradingCardsA3.DataSet;

namespace TradingCardsA3
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            InitializePlayers();

            //private Dictionary<string, Image> playerPhotos = new Dictionary<string, Image>();


    }
    

        public class Player
        {
            public string Name { get; set; }
            public string Team { get; set; }
            public Image Photo { get; set; }
            public string Position { get; set; }
            public int Goals { get; set; }
            public int Assists { get; set; }
            public int MatchesPlayed { get; set; }
            public int YellowCards { get; set; }


            public Player(string name, string team, Image photo, string position, int goals, int assists, int matchesPlayed, int yellowCards)
            {
                Name = name;
                Team = team;
                Photo = photo;
                Position = position;
                Goals = goals;
                Assists = assists;
                MatchesPlayed = matchesPlayed;
                YellowCards = yellowCards;
            }
        }

        private void InitializePlayers()
        {

            List<Player> players = new List<Player>
            {
            new Player("Lionel Messi", "Paris FC",  Properties.Resources.Messi, "Forward", 15, 10,20, 2),
            new Player ("Kylian Mbappé", "Paris FC", Properties.Resources.KyliamMbappe, "Forward", 18, 8, 22, 3 ),
            new Player ("Sergio Ramos", "Paris FC", Properties.Resources.SergioRamos, "Defender", 2, 1, 18, 5),
            new Player ("Erling Haaland", "Manchester Strikers", Properties.Resources.ErlingHaaland, "Forward", 20, 6, 21, 1),
            new Player ("Kevin De Bruyne","Manchester Strikers", Properties.Resources.KevinDeBruyne,"Midfielder", 5, 15, 19, 2),
            new Player ("Ruben Dias", "Manchester Strikers",Properties.Resources.RubenDias, "Defender", 1, 0,  20, 4),
            new Player ("Cristiano Ronaldo", "Juventus Legends", Properties.Resources.CristianoRonaldo, "Forward", 12, 4, 18, 2 ),
            new Player ("Paulo Dybala", "Juventus Legends", Properties.Resources.PauloDybala, "Forward", 7, 6, 19, 1 ),
            new Player ("Leonardo Bonucci", "Juventus Legends", Properties.Resources.LeonardoBonucci,"Defender", 3, 1, 21, 5 ),
            new Player ("Wojciech Szczesny", "Juventus Legends", Properties.Resources.WojciechSzczesny, "Goalkeeper", 0, 0, 20, 0)
            };

            bindingSource1.DataSource = players;
            listBox1.DataSource = bindingSource1;
            listBox1.DisplayMember = "Name"; // Display player's name in the listbox
        }

      

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Player selectedPlayer = (Player)listBox1.SelectedItem;

                labelName.Text = selectedPlayer.Name;
                labelTeam.Text = selectedPlayer.Team;
                pictureBox1.Image = selectedPlayer.Photo;

                labelStat1.Text = "Goals: " + selectedPlayer.Goals.ToString();
                labelStat2.Text = "Assists: " + selectedPlayer.Assists.ToString();

                // Change card border color based on team
                switch (selectedPlayer.Team)
                {
                    case "Paris FC":
                        panelCard.BackColor = Color.Blue; // Team color (example)
                        break;
                    case "Manchester Strikers":
                        panelCard.BackColor = Color.Red;
                        break;
                    default:
                        panelCard.BackColor = Color.Gray;
                        break;
                }

                // Add logic to display stats in green/red based on value
                labelStat1.ForeColor = selectedPlayer.Goals > 10 ? Color.Green : Color.Red;
                labelStat2.ForeColor = selectedPlayer.Assists > 10 ? Color.Green : Color.Red;
            }
        }

        private void buttonAddCard_Click(object sender, EventArgs e)
        {
            // Create a form to input new player details
            Form addPlayerForm = new Form();
            addPlayerForm.Text = "Add New Player";
            addPlayerForm.Size = new Size(300, 500);

            // Create input fields
            Label[] labels = new Label[]
            {
        new Label { Text = "Name:", Location = new Point(10, 20) },
        new Label { Text = "Team:", Location = new Point(10, 60) },
        new Label { Text = "Position:", Location = new Point(10, 100) },
        new Label { Text = "Goals:", Location = new Point(10, 140) },
        new Label { Text = "Assists:", Location = new Point(10, 180) },
        new Label { Text = "Matches Played:", Location = new Point(10, 220) },
        new Label { Text = "Yellow Cards:", Location = new Point(10, 260) }
            };

            TextBox[] textBoxes = new TextBox[]
            {
        new TextBox { Location = new Point(150, 20), Width = 120 },
        new TextBox { Location = new Point(150, 60), Width = 120 },
        new TextBox { Location = new Point(150, 100), Width = 120 },
        new TextBox { Location = new Point(150, 140), Width = 120 },
        new TextBox { Location = new Point(150, 180), Width = 120 },
        new TextBox { Location = new Point(150, 220), Width = 120 },
        new TextBox { Location = new Point(150, 260), Width = 120 }
            };

            Button btnSelectPhoto = new Button
            {
                Text = "Select Photo",
                Location = new Point(10, 300),
                Width = 120
            };

            Button btnSave = new Button
            {
                Text = "Save Player",
                Location = new Point(150, 300),
                Width = 120
            };

            Image selectedPhoto = null;

            // Photo selection event
            btnSelectPhoto.Click += (s, ev) =>
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        selectedPhoto = Image.FromFile(openFileDialog.FileName);
                    }
                }
            };

            // Save player event
            btnSave.Click += (s, ev) =>
            {
                try
                {
                    // Validate inputs
                    if (string.IsNullOrWhiteSpace(textBoxes[0].Text) ||
                        string.IsNullOrWhiteSpace(textBoxes[1].Text) ||
                        selectedPhoto == null)
                    {
                        MessageBox.Show("Please fill in all required fields and select a photo.");
                        return;
                    }

                    // Create new player
                    Player newPlayer = new Player(
                        textBoxes[0].Text,           // Name
                        textBoxes[1].Text,            // Team
                        selectedPhoto,                // Photo
                        textBoxes[2].Text,            // Position
                        int.Parse(textBoxes[3].Text), // Goals
                        int.Parse(textBoxes[4].Text), // Assists
                        int.Parse(textBoxes[5].Text), // Matches Played
                        int.Parse(textBoxes[6].Text)  // Yellow Cards
                    );

                    // Add player to the list
                    bindingSource1.Add(newPlayer);

                    // Close the form
                    addPlayerForm.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding player: " + ex.Message);
                }
            };

            // Add controls to the form
            for (int i = 0; i < labels.Length; i++)
            {
                addPlayerForm.Controls.Add(labels[i]);
                addPlayerForm.Controls.Add(textBoxes[i]);
            }
            addPlayerForm.Controls.Add(btnSelectPhoto);
            addPlayerForm.Controls.Add(btnSave);

            // Show the form
            addPlayerForm.ShowDialog();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelStat1_Click(object sender, EventArgs e)
        {

        }

        private void labelStat2_Click(object sender, EventArgs e)
        {

        }

        private void buttonViewCard_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelCard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }
    }
}
