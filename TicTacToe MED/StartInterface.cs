using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_MED
{
    public partial class StartInterface : Form
    {
        public StartInterface()
        {
            
            InitializeComponent();
        }

        //Start interface Load
        private void StartInterface_Load(object sender, EventArgs e)
        {
            playersNamesPanel.Visible = false;
        }


        private void twoPlayersButton_Click(object sender, EventArgs e)
        {
            playersNamesPanel.Visible=true;
            

            // Check if both player names are provided
            

            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            RobotVersusGame robotVersusGame = new RobotVersusGame();
            robotVersusGame.Show();
            this.Hide();
        }

        private void StartGame2PlayerBtn_Click(object sender, EventArgs e)
        {
            string player1Name = player1NameTextBox.Text;
            string player2Name = player2NameTextBox.Text;

            if (string.IsNullOrWhiteSpace(player1Name) || string.IsNullOrWhiteSpace(player2Name))
            {
                MessageBox.Show("Please enter names for both players.");
                return;
            }

            TwoPlayersGame twoPlayersGame = new TwoPlayersGame(player1Name, player2Name);
            twoPlayersGame.Show();
            this.Hide();
        }

        private void goToStrtChoiceBtn_Click(object sender, EventArgs e)
        {
            playersNamesPanel.Visible = false;
        }
    }
}
