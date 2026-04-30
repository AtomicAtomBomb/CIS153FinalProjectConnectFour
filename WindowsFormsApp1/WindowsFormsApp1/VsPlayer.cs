using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class VsPlayer : Form
    {
        bool player1Turn = true;
        bool player2Turn = false;
        Board getboard;

        public bool reviewMode = false;
        public VsPlayer()
        {
            InitializeComponent();
            getboard = new Board();
            setupboard();
            //getboard.getcell(0, 5).getButton().BackColor = Color.Green;
            //the above line doesnt matter, I included this so you two can know how to pull a specific point, 
            //each button is individually named so in the instance you need to know a specific point check names

        }
        public void setupboard()
        {
            string name;
            char delim = '_';
            int posDelim;
            int col;
            int row;
            Cell c;
            foreach (var button in this.Controls.OfType<Button>())
            {
                if (button.Name != "btn_Return")
                {
                    button.Click += OnCellClick;
                    button.MouseEnter += CellShowPreview;
                    button.MouseLeave += CellClearPreview;

                    name = button.Name;
                    posDelim = name.IndexOf(delim);
                    row = Int32.Parse(name.Substring(posDelim + 1, 1));
                    name = name.Substring(posDelim + 2);
                    posDelim = name.IndexOf(delim);
                    col = Int32.Parse(name.Substring(posDelim + 1));

                    c = new Cell(row, col, button);

                    getboard.setgameboard(c);
                    //this finds each button and stores them for get button
                    //if you touch this program please let me know any changes
                }
            }
        }
        private void VsPlayer_Load(object sender, EventArgs e)
        {

        }

        public void revertButtonColor(object sender, EventArgs e)
        {
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.BackColor = Color.White;
            }
        }

        private void HandleMove(Button clickedButton)
        {
                int lastUnderscore = clickedButton.Name.LastIndexOf('_');
            int col = Int32.Parse(clickedButton.Name.Substring(lastUnderscore + 1));
            if (player1Turn == true)
            {
                bool moveWasLegal = getboard.DropPiece(col, 1);
                player1Turn = false;
                player2Turn = true;
                if (moveWasLegal)
                {
                    int winner = getboard.CheckForWin();
                    bool isDraw = true;
                    for (int i = 0; i < Board.columns; i++)
                    {
                        Cell topCell = getboard.getcell(0, i);

                        if (topCell == null || topCell.getStatus() == 0)
                        {
                            isDraw = false;
                        }
                    }
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
                    }
                }
            }
            else if (player2Turn == true)
            {
                bool moveWasLegal = getboard.DropPiece(col, 2);
                player2Turn = false;
                player1Turn = true;
                if (moveWasLegal)
                {
                    int winner = getboard.CheckForWin();
                    bool isDraw = true;
                    for (int i = 0; i < Board.columns; i++)
                    {
                        Cell topCell = getboard.getcell(0, i);

                        if (topCell == null || topCell.getStatus() == 0)
                        {
                            isDraw = false;
                        }
                    }
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
                    }
                }
            }
        }

        private void OnCellClick(object sender, EventArgs e)
        {
            if (!reviewMode)
            {
                Button btn = (Button)sender;

                HandleMove(btn);
            }
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

            bool ShowPreview = true;

            if (ShowPreview == true && player1Turn == true)
            {
                getboard.ShowPreview(col, 1);
                //ShowPreview = false;
            }
            else
            {
                getboard.ShowPreview(col, 2);
            }
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

        private void VsPlayer_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
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

        //This closes the entire program when the user clicks the x on the top bar.
        private void VsPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }

}
