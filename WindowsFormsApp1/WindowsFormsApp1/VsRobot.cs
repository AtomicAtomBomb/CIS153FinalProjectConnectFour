using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class VsRobot : Form
    {
        Board getboard;
        bool player1Turn = true;
        int p = 0;
        int colpos;
        
        //I added this flag to lock the board when we are just reviewing a finished game
        public bool reviewMode = false;
        bool gameover = false;

        public VsRobot()
        {
            InitializeComponent();
            getboard = new Board();
            setupboard();
        }

        public void setupboard()
        {
            //Here I'm looping through all the buttons on the form to build our grid dynamically
            foreach (var button in this.Controls.OfType<Button>())
            {
                if (button.Name != "btn_Return")
                {
                    button.Click += OnCellClick;
                    button.MouseEnter += CellShowPreview;
                    button.MouseLeave += CellClearPreview;
                    int lastUnderscore = button.Name.LastIndexOf('_');
                    int row = Int32.Parse(button.Name.Substring(button.Name.IndexOf('_') + 1, 1));
                    int col = Int32.Parse(button.Name.Substring(lastUnderscore + 1));

                    //Creating a new cell and passing it to my board class
                    Cell c = new Cell(row, col, button);
                    getboard.setgameboard(c);
                }
            }
        }

        private void OnCellClick(object sender, EventArgs e)
        {
            //If the game is over and we are just looking at the board, or it's not the player's turn, I ignore the click
            if (reviewMode || !player1Turn) return;

            Button btn = (Button)sender;
            int col = Int32.Parse(btn.Name.Substring(btn.Name.LastIndexOf('_') + 1));

            //I try to drop the piece. If it works, I check if the player won.
            if (getboard.DropPiece(col, 1))
            {
                if (CheckGameState(1)) return; //Stop everything if the player just won

                //Now it's the computer's turn
                player1Turn = false;
                ExecuteAIMove();
            }
        }

        private void ExecuteAIMove()
        {
            int bestCol = -1;

            //RULE 1: I check if the AI can win right now. If yes, take the win.
            bestCol = FindWinningColumn(2);

            //RULE 2: If the AI can't win, I check if the player is about to win. If yes, block them
            if (bestCol == -1) bestCol = FindWinningColumn(1);

            //RULE 3: If no one is about to win, I use basic strategy
            //I tell the AI to prefer the middle columns over the outside edges
            if (bestCol == -1)
            {
                Random num = new Random();
                colpos = num.Next(0, 6);
                if (getboard.getcell(0,colpos).getStatus() != 0)
                {
                    colpos = num.Next(0, 6);
                }
                if (getboard.getcell(0, colpos).getStatus() == 0)
                {
                    bestCol = colpos;
                }    
            }

            //if (bestCol == -1)
            //{

            //    int[] preferredMoves = { 3, 2, 4, 1, 5, 0, 6 };
            //    foreach (int col in preferredMoves)
            //    {
            //        //I make sure the column isn't full before picking it
            //        if (getboard.getcell(0, col).getStatus() == 0)
            //        {
            //            bestCol = col;
            //            break;
            //        }
            //    }
            //}

            //Drop the AI's piece in the column I decided on
            p++;
            getboard.DropPiece(bestCol, 2);
            CheckGameState(2); //Check if the AI just won
            player1Turn = true; //Give the turn back to the player
        }

        //I made this helper method for the AI to "test" dropping a piece to see if it causes a win
        private int FindWinningColumn(int playerNum)
        {
            for (int col = 0; col < Board.columns; col++)
            {
                //I look for the lowest empty spot in the column
                for (int row = Board.rows - 1; row >= 0; row--)
                {
                    //NEW FIX: Grab the cell first
                    Cell testCell = getboard.getcell(row, col);

                    //SAFETY CHECK: Make sure the cell exists before checking its status
                    if (testCell != null && testCell.getStatus() == 0)
                    {
                        //I temporarily place a piece here to see what happens
                        testCell.setStatus(playerNum);
                        int winner = getboard.CheckForWin();
                        
                        //I immediately take the piece back out so I don't mess up the actual board
                        testCell.setStatus(0);

                        //If that move resulted in a win, I return this column number
                        if (winner == playerNum) return col;
                        break;
                    }
                }
            }
            return -1; //Return -1 if I couldn't find any winning moves
        }

        private bool CheckGameState(int playerNum)
        {
            int winner = getboard.CheckForWin();

            //I check for a tie by seeing if the entire top row is full
            bool isDraw = true;
            for (int i = 0; i < Board.columns; i++)
            {
                //NEW FIX: Grab the cell first to make sure it actually exists
                Cell topCell = getboard.getcell(0, i);

                //SAFETY CHECK: If the cell is completely missing (null), 
                //OR if it exists and is empty (status 0), it is NOT a draw yet
                if (topCell == null || topCell.getStatus() == 0)
                {
                    isDraw = false;
                }
            }

            //If someone won or it's a tie, the game is over
            if (winner != 0 || isDraw)
            {
                string result = isDraw ? "Draw" : "Player " + winner;

                //I save the stats to our text file right as the game ends
                SaveStats(winner);

                //I open the Game Over screen and pass it this form so we can review it later
                btn_Return.Visible = true;
                GameOverForm endScreen = new GameOverForm(this, result);
                
                endScreen.StartPosition = FormStartPosition.Manual;
                endScreen.Location = this.Location;
                endScreen.Show();
                this.Hide();
                return true;
            }
            return false;
        }

        //Here is my logic for making the stats persistent using a text file
        private void SaveStats(int winner)
        {
            string path = "stats.txt";
            int pWins = 0, aWins = 0, ties = 0, total = 0;

            //If the file already exists, I read the old numbers first so I don't overwrite them
            if (System.IO.File.Exists(path))
            {
                string[] data = System.IO.File.ReadAllText(path).Split(',');
                pWins = Int32.Parse(data[0]);
                aWins = Int32.Parse(data[1]);
                ties = Int32.Parse(data[2]);
                total = Int32.Parse(data[3]);
            }

            //I update the numbers based on who just won
            total++;
            if (winner == 1) pWins++;
            else if (winner == 2) aWins++;
            else ties++;

            //I save everything back to the text file separated by commas
            System.IO.File.WriteAllText(path, $"{pWins},{aWins},{ties},{total}");
        }

        private void VsRobot_Load(object sender, EventArgs e)
        {

        }
        private void CellShowPreview(object sender, EventArgs e)
        {
            if (!reviewMode)
            {
                Button btn = (Button)sender;

                movePreview(btn);
            }
        }

        private void CellClearPreview(object sender, EventArgs e)
        {
            if (!reviewMode)
            {
                Button btn = (Button)sender;

                clearPreview(btn);
            }
        }

        private void movePreview(Button clickedButton)
        {
            int lastUnderscore = clickedButton.Name.LastIndexOf('_');
            int col = Int32.Parse(clickedButton.Name.Substring(lastUnderscore + 1));

            getboard.ShowPreview(col, 1);
        }

        private void clearPreview(Button clickedButton)
        {
            int lastUnderscore = clickedButton.Name.LastIndexOf('_');
            int col = Int32.Parse(clickedButton.Name.Substring(lastUnderscore + 1));

            bool ClearPreview = true;

            if (ClearPreview == true)
            {
                getboard.ClearStatusAndColor(col);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void VsRobot_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }

}