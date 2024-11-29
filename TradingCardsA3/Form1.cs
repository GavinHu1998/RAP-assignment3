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
            Player newPlayer = new Player("Cristiano Ronaldo", "Juventus Legends", Properties.Resources.CristianoRonaldo, "Forward", 12, 4, 18, 2);
            bindingSource1.Add(newPlayer);
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
