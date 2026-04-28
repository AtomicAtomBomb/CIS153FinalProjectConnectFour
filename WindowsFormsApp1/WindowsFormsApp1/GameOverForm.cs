using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class GameOverForm : Form
    {
        //I created this variable to hold onto the game board that just finished 
        //so we don't lose it if they want to review the game
        private Form previousGameBoard;

        //I changed the constructor here so it accepts the previous board and the string telling us who won
        public GameOverForm(Form previousBoard, string result)
        {
            InitializeComponent();
            previousGameBoard = previousBoard;

            //Here I'm updating the label on the screen to show whether someone won or if it was a tie
            if (result == "Draw")
            {
                lbl_Result.Text = "It's a Draw!";
            }
            else
            {
                lbl_Result.Text = result + " Wins!";
            }
        }

        private void btn_PlayAgain_Click(object sender, EventArgs e)
        {
            //I check which type of game was just playing so I know which form to open for the rematch
            Form newGame;
            if (previousGameBoard is VsRobot)
            {
                newGame = new VsRobot();
            }
            else
            {
                newGame = new VsPlayer();
            }

            //I make sure the new game opens in the exact same spot on the screen
            newGame.StartPosition = FormStartPosition.Manual;
            newGame.Location = this.Location;
            newGame.Show();

            //I dispose of the old board to free up memory since we are starting fresh
            previousGameBoard.Dispose();
            this.Hide();
        }

        private void btn_ReviewGame_Click(object sender, EventArgs e)
        {
            //Here I turn on that reviewMode flag we created so the player can't keep dropping 
            //pieces on the finished board. I have to check which mode they were in first
            if (previousGameBoard is VsRobot)
            {
                ((VsRobot)previousGameBoard).reviewMode = true;
            }
            else if (previousGameBoard is VsPlayer)
            {
                ((VsPlayer)previousGameBoard).reviewMode = true;
            }

            //I bring the old board back up in the exact same location.
            previousGameBoard.StartPosition = FormStartPosition.Manual;
            previousGameBoard.Location = this.Location;
            previousGameBoard.Show();
            this.Hide();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            //Fully closing out the application
            Application.Exit();
        }

        //I added this to make sure if they click the red 'X' in the corner, it kills the whole app
        private void GameOverForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_PlayAgain_Click_1(object sender, EventArgs e)
        {
            
            if (previousGameBoard is VsRobot)
            {
                VsRobot newform = new VsRobot();
                newform.Show();
                this.Hide();
            }
            else if (previousGameBoard is VsPlayer)
            {
                VsPlayer newform = new VsPlayer();
                newform.Show();
                this.Hide();
            }
            
        }

        private void btn_ReviewGame_Click_1(object sender, EventArgs e)
        {
            previousGameBoard.Show();
            this.Hide();
        }

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btn_Main_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }
    }
}