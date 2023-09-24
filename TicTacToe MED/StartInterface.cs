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

        private void twoPlayersButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have chosen to play against another player. Please enter your names.");

            TwoPlayersGame twoPlayersGame = new TwoPlayersGame("Mohamed","Sami");
            twoPlayersGame.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RobotVersusGame robotVersusGame = new RobotVersusGame();
            robotVersusGame.Show();
            this.Hide();
        }
    }
}
