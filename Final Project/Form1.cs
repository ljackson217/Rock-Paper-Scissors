// Lindsay Allen (Jackson)
// CIS162AD - #31778
// Final Project

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class rockPaperScissorsForm : Form
    {
        public rockPaperScissorsForm()
        {
            InitializeComponent();
        }

        // initializes variables
        Random rand = new Random(); // creates a new random object
        string[] compChoices = { "Rock", "Paper", "Scissors" }; // array of selections for the computer
        int compChoiceIndex;
        int x = 0;
        int y = 0;

        private void goButton_Click(object sender, EventArgs e)
        {
            // assigns random index of compChoices array to variable
            compChoiceIndex = rand.Next(compChoices.Length);

            // calls methods
            DisplayPlayersChoices(compChoiceIndex);
            WinningColor();


            // displays the scores of each player
            while (x < 3 || y < 3)
            {
                if (IsWinner(compChoiceIndex))  // if user wins, score is incremented by 1
                { 
                    x++;
                    yourScoreOutput.Text = Convert.ToString(x);
                    
                }
                else if (computerWins(compChoiceIndex)) // if computer wins, score is incremented by 1
                {
                    y++;
                    computerScoreOutput.Text = Convert.ToString(y);
                    
                }
                break;
            }


            // if user reaches a score of 3 first, a message displays user wins and the form is reset
            if (x == 3)
            {
                MessageBox.Show("You Win!");
                resetForm();
            }

            // if computer reaches a score of 3 first, a message is displayed and the form is reset
            if (y == 3)
            {
                MessageBox.Show("The computer wins this time.");
                resetForm();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Method takes the index value of randomly assigned computer choice for either rock, paper, or scissors
        // 0 -> "rock"  1 -> "paper"    2 -> "scissors"
        // compares index value to user's selected radio button
        // returns true if user wins round. Returns false if computer wins round or there is a tie
        Boolean IsWinner(int index)
        {
            if (index == 0 && scissorsRadioButton.Checked)
            {
                return false;
            }

            if (index == 0 && paperRadioButton.Checked)
            {
                return true;
            }

            if (index == 0 && rockRadioButton.Checked)
            {
                return false;
            }

            if (index == 1 && scissorsRadioButton.Checked)
            {
                return true;
            }

            if (index == 1 && paperRadioButton.Checked)
            {
                return false;
            }

            if (index == 1 && rockRadioButton.Checked)
            {
                return false;
            }

            if (index == 2 && scissorsRadioButton.Checked)
            {
                return false;
            }

            if (index == 2 && paperRadioButton.Checked)
            {
                return false;
            }

            else
            {
                return true;
            }
        }


        // Method takes the index value of randomly assigned computer choice for either rock, paper, or scissors
        // 0 -> "rock"  1 -> "paper"    2 -> "scissors"
        // compares index value to user's selected radio button
        // returns true if computer wins round. Returns false if user wins round or there is a tie
        Boolean computerWins(int index)
        {
            if (index == 0 && scissorsRadioButton.Checked)
            {
                return true;
            }

            if (index == 0 && paperRadioButton.Checked)
            {
                return false;
            }

            if (index == 0 && rockRadioButton.Checked)
            {
                return false;
            }

            if (index == 1 && scissorsRadioButton.Checked)
            {
                return false;
            }

            if (index == 1 && paperRadioButton.Checked)
            {
                return false;
            }

            if (index == 1 && rockRadioButton.Checked)
            {
                return true;
            }

            if (index == 2 && scissorsRadioButton.Checked)
            {
                return false;
            }

            if (index == 2 && paperRadioButton.Checked)
            {
                return true;
            }

            else
            {
                return false;
            }
        }



        // Displays player's choices
        void DisplayPlayersChoices(int compChoiceIndex)
        {
            // computer selection
            computerChoice.Text = compChoices[compChoiceIndex];
            compChoiceLabel.Visible = true;
            computerChoice.Visible = true;

            //  user selection
            if (rockRadioButton.Checked)
            {
                yourChoice.Text = "Rock";
            }

            if (paperRadioButton.Checked)
            {
                yourChoice.Text = "Paper";
            }

            if (scissorsRadioButton.Checked)
            {
                yourChoice.Text = "Scissors";
            }

            yourChoiceLabel.Visible = true;
            yourChoice.Visible = true;

            // hides the "please make a seletion" label
            makeSelectionLabel.Visible = false;
        }


        // Changes the color of the winner selection to green, losing selection to red, and tie to blue
        void WinningColor()
        {
            if (IsWinner(compChoiceIndex))
            {
                yourChoice.ForeColor = System.Drawing.Color.Green;
                computerChoice.ForeColor = System.Drawing.Color.Red;
            }

            else if (computerWins(compChoiceIndex))
            {
                yourChoice.ForeColor = System.Drawing.Color.Red;
                computerChoice.ForeColor = System.Drawing.Color.Green;
            }

            else
            {
                yourChoice.ForeColor = System.Drawing.Color.Blue;
                computerChoice.ForeColor = System.Drawing.Color.Blue;
            }
        }

        // Method resets form
        void resetForm()
        {
            x = 0;
            y = 0;

            yourScoreOutput.Text = "";
            computerScoreOutput.Text = "";

            yourChoiceLabel.Visible = false;
            yourChoice.Visible = false;

            compChoiceLabel.Visible = false;
            computerChoice.Visible = false;

            makeSelectionLabel.Visible = true;

            rockRadioButton.Checked = true;
            paperRadioButton.Checked = false;
            scissorsRadioButton.Checked = false;
        }


    }


}
