using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe_MED;

namespace TicTacToe_MED
{
    public partial class TwoPlayersGame : Form
    {
        private TextBox playerXTextBox;
        private TextBox playerOTextBox;


        private char currentPlayer = 'X'; // Initialize the current player to X
        private bool gameOver = false;   // Track if the game is over
        private Button[,] buttons;       // 2D array to hold buttons

        public TwoPlayersGame(string playerXName, string playerOName)
        {
            InitializeComponent();
            InitializeButtonsArray();

            // Initialize player names
            playerXTextBox = new TextBox();
            playerXTextBox.Text = playerXName;
            playerXTextBox.Location = new Point(50, 10);
            this.Controls.Add(playerXTextBox);

            playerOTextBox = new TextBox();
            playerOTextBox.Text = playerOName;
            playerOTextBox.Location = new Point(250, 10);
            this.Controls.Add(playerOTextBox);

            currentPlayer = 'X'; // Start with player X
        }



        private void InitializeButtonsArray()
        {
            // Initialize the 2D array with buttons
            buttons = new Button[3, 3]
            {
                { button1n1, button1n2, button1n3 },
                { button2n1, button2n2, button2n3 },
                { button3n1, button3n2, button3n3 }
            };
        }

        private void CheckForWinner()
        {
            // Check rows for a win
            for (int row = 0; row < 3; row++)
            {
                if (buttons[row, 0].Text == currentPlayer.ToString() &&
                    buttons[row, 1].Text == currentPlayer.ToString() &&
                    buttons[row, 2].Text == currentPlayer.ToString())
                {
                    MessageBox.Show(currentPlayer + " wins!");
                    gameOver = true;
                    return;
                }
            }

            // Check columns for a win
            for (int col = 0; col < 3; col++)
            {
                if (buttons[0, col].Text == currentPlayer.ToString() &&
                    buttons[1, col].Text == currentPlayer.ToString() &&
                    buttons[2, col].Text == currentPlayer.ToString())
                {
                    MessageBox.Show(currentPlayer + " wins!");
                    gameOver = true;
                    return;
                }
            }

            // Check diagonals for a win
            if (buttons[0, 0].Text == currentPlayer.ToString() &&
                buttons[1, 1].Text == currentPlayer.ToString() &&
                buttons[2, 2].Text == currentPlayer.ToString())
            {
                MessageBox.Show(currentPlayer + " wins!");
                gameOver = true;
                return;
            }

            if (buttons[0, 2].Text == currentPlayer.ToString() &&
                buttons[1, 1].Text == currentPlayer.ToString() &&
                buttons[2, 0].Text == currentPlayer.ToString())
            {
                MessageBox.Show(currentPlayer + " wins!");
                gameOver = true;
                return;
            }

            // Check for a draw
            bool isDraw = true;
            foreach (Button button in buttons)
            {
                if (button.Text == "")
                {
                    isDraw = false;
                    break;
                }
            }

            if (isDraw)
            {
                MessageBox.Show("It's a draw!");
                gameOver = true;
            }
        }


        private void HandleButtonClick(Button button)
        {
            if (!gameOver && button.Text == "")
            {
                button.Text = currentPlayer.ToString();
                button.ForeColor = (currentPlayer == 'X') ? Color.Red : Color.Blue;
                button.Font = new Font(button.Font.FontFamily, 24);
                CheckForWinner();

                if (gameOver)
                {
                    string winnerName = (currentPlayer == 'X') ? playerXTextBox.Text : playerOTextBox.Text;
                    MessageBox.Show(winnerName + " wins!");
                }

                currentPlayer = (currentPlayer == 'X') ? 'O' : 'X'; // Switch players
            }
        }


        // Event handlers for button clicks
        private void button1n1_Click(object sender, EventArgs e) { 
            HandleButtonClick(button1n1); 
            CheckForWinner();
        }
        private void button1n2_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button1n2);
            CheckForWinner();
        }
        private void button1n3_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button1n3);
            CheckForWinner();
        }
        private void button2n1_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button2n1);
            CheckForWinner();
        }
        private void button2n2_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button2n2);
            CheckForWinner();
        }
        private void button2n3_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button2n3);
            CheckForWinner();
        }
        private void button3n1_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button3n1);
            CheckForWinner();
        }
        private void button3n2_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button3n2);
            CheckForWinner();
        }
        private void button3n3_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button3n3);
            CheckForWinner();
        }

        private void backToPreviousFormButton_Click(object sender, EventArgs e)
        {
            
            StartInterface startInterface = new StartInterface();
            startInterface.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this button is for reseting the game
            //it will reset the game to the initial state
            //and will allow the players to play again
            //without having to close the game and open it again
            foreach (Button button in buttons)
            {
                button.Text = "";
            }

            gameOver = false;
            currentPlayer = 'X';

        }
    }
}
