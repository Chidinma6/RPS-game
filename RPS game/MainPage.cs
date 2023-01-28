using System;
using System.Windows.Forms;

namespace RPS_game
{
    public partial class MainPage : Form
    {

        int rounds = 3;
        int timePerRound = 6;
        bool gameOver = false;

        string[] ComputerchoiceList = { "rock", "paper", "scissors", "paper", "scissors", "rock" };

        int randomNumber = 0;
        Random rnd = new Random();

        string Computerchoice;

        string playerChoice;

        int playerpoints;
        int Computerpoints;
        public MainPage()
        {
            InitializeComponent();

            countdownTimer.Enabled = false;
            playerChoice = "none";
            countdownlbl.Text = "5";
        }

        private void paperBtn_Click(object sender, EventArgs e)
        {
            picplayer.Image = Properties.Resources.paper;
            playerChoice = "paper";
        }

        private void scissorsBtn_Click(object sender, EventArgs e)
        {
            picplayer.Image = Properties.Resources.scissors;
            playerChoice = "scissors";
        }

        private void rockBtn_Click(object sender, EventArgs e)
        {
            picplayer.Image = Properties.Resources.rock;
            playerChoice = "rock";
        }

        private void playerlbl_Click(object sender, EventArgs e)
        {

        }

        private void pointslbl_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rulesBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form.
            rules home = new rules(); // Create new instance of the new
            home.Show(); // Show it

            countdownTimer.Enabled = false;
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            playerpoints = 0;
            Computerpoints = 0;
            rounds = 3;
            pointslbl.Text = "Player: " + playerpoints + " - " + "CPU: " + Computerpoints;

            playerChoice = "none";
            countdownlbl.Text = "5";

            countdownTimer.Enabled = true;

            picplayer.Image = Properties.Resources.qq1;
            piccomputer.Image = Properties.Resources.qq1;

            gameOver = false;
        }

        private void picplayer_Click(object sender, EventArgs e)
        {

        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            timePerRound -= 1;
            countdownlbl.Text = timePerRound.ToString();
            roundslbl.Text = "Rounds: " + rounds;

            if (timePerRound < 1)
            {
                countdownTimer.Enabled = false;
                timePerRound = 6;

                randomNumber = rnd.Next(0, ComputerchoiceList.Length);

                Computerchoice = ComputerchoiceList[randomNumber];

                switch (Computerchoice)
                {
                    case "rock":
                        piccomputer.Image = Properties.Resources.rock;
                        break;
                    case "paper":
                        piccomputer.Image = Properties.Resources.paper;
                        break;
                    case "scissors":
                        piccomputer.Image = Properties.Resources.scissors;
                        break;
                }

                if (rounds > 0)
                {
                    checkGame();
                }
                else
                {
                    if (playerpoints > Computerpoints)
                    {
                        MessageBox.Show("Player Wins This Game");
                    }
                    else
                    {
                        MessageBox.Show("Computer Wins This Game");
                    }

                    gameOver = true;
                }

            }
        }

        private void checkGame()
        {
            // Computer and player win rules

                if (playerChoice == "rock" && Computerchoice == "paper")
                {

                    Computerpoints += 1;

                    rounds -= 1;

                    MessageBox.Show("Computer Wins, Paper Covers Rocks");

                }

                else if (playerChoice == "scissors" && Computerchoice == "rock")
                {
                    Computerpoints += 1;

                    rounds -= 1;

                    MessageBox.Show("Computer Wins, Rock Breaks Scissors");
                }
                else if (playerChoice == "paper" && Computerchoice == "scissors")
                {

                    Computerpoints += 1;

                    rounds -= 1;

                    MessageBox.Show("Computer Wins, Scissors cuts paper");

                }
                else if (playerChoice == "rock" && Computerchoice == "scissors")
                {

                    playerpoints += 1;

                    rounds -= 1;

                    MessageBox.Show("Player Wins, Rock Breaks Scissors");

                }
                else if (playerChoice == "paper" && Computerchoice == "rock")
                {

                    playerpoints += 1;

                    rounds -= 1;

                    MessageBox.Show("Player Wins, Paper Covers Rocks");

                }
                else if (playerChoice == "scissors" && Computerchoice == "paper")
                {
                    playerpoints += 1;

                    rounds -= 1;

                    MessageBox.Show("Player Wins, Scissors cuts paper");

                }
                else if (playerChoice == "none")
                {
                    MessageBox.Show("Make your Choice");
                }
                else
                {
                    MessageBox.Show("Draw");

                }

                startNextRound();
            }

            private void startNextRound()
            {

                if (gameOver == true)
                {
                    return;
                }

                pointslbl.Text = "Player: " + playerpoints + " - " + "CPU: " + Computerpoints;

                playerChoice = "none";

                countdownTimer.Enabled = true;

                picplayer.Image = Properties.Resources.qq1;
                piccomputer.Image = Properties.Resources.qq1;
            }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void countdownlbl_Click(object sender, EventArgs e)
        {

        }

        private void roundslbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           countdownTimer.Enabled=true;
        }

        private void pausebtn_Click(object sender, EventArgs e)
        {
            countdownTimer.Enabled = false;
        }
    }
    }

