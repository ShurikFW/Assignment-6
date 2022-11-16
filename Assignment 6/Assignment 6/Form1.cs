using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_6
{
    public partial class Form1 : Form
    {
        string playerChoice;
        string computerChoice;
        string[] Options = { "R", "P", "S", "P", "S", "R" };
        Random random = new Random();
        int computerScore;
        int playerScore;
        string draw;

        public Form1()
        {
            InitializeComponent();
        }

        private void MakeChoiseEvent(object sender, EventArgs e)
        {
            Button tempButton = sender as Button;
            playerChoice = (string)tempButton.Tag;
            int i = random.Next(0, Options.Length);
            computerChoice = Options[i];
            label4.Text = "Player is " + UpdateTextandImage(playerChoice, PlayerPic);
            label1.Text = "Computer is " + UpdateTextandImage(computerChoice, CpuPic);
            CheckGame();
        }
        private string UpdateTextandImage(string text, PictureBox pic)
        {
            string word = null;
            switch(text)
            {
                case "R":
                    word = "Rock";
                    pic.Image = Properties.Resources.Rock;
                    break;
                case "P":
                    word = "Paper";
                    pic.Image = Properties.Resources.Paper;
                    break;
                case "S":
                    word = "Scissors";
                    pic.Image = Properties.Resources.Scissors;
                    break;


            }
            return word;

        }
        private void CheckGame()
        {
            if (computerChoice == playerChoice)
            {
                draw = "Draw!";
            }
            else if (playerChoice == "R" && computerChoice == "P" || playerChoice == "S" && computerChoice == "R" || playerChoice == "P" && computerChoice == "S")
            {
                computerScore++;
                draw = null;
            }
            else
            {
                playerScore++;
                draw = null;
            }
            label3.Text = "Computer Score:" + computerScore + Environment.NewLine + draw;
            label2.Text = "Player Score:" + playerScore + Environment.NewLine + draw;
        }

        private void CpuPic_Click(object sender, EventArgs e)
        {

        }

        private void PLAYER_Click(object sender, EventArgs e)
        {

        }

        private void PlayerPic_Click(object sender, EventArgs e)
        {

        }
    }
}
