using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StatsForm : Form
    {
        public StatsForm()
        {
            InitializeComponent();
            LoadStats(); //I call this right away so the text updates as soon as the form opens
        }

        private void LoadStats()
        {
            string path = "stats.txt";

            //I check to make sure the file exists before I try to read it
            if (File.Exists(path))
            {
                //I split the text file by commas to get my individual numbers back
                string[] data = File.ReadAllText(path).Split(',');

                //I parse them as doubles so my percentage math works correctly later
                double pWins = double.Parse(data[0]);
                double aWins = double.Parse(data[1]);
                double ties = double.Parse(data[2]);
                double total = double.Parse(data[3]);

                //I update all the labels on the screen with our data
                lbl_PlayerWins.Text = "Player Wins: " + pWins;
                lbl_AIWins.Text = "AI Wins: " + aWins;
                lbl_Ties.Text = "Ties: " + ties;
                lbl_TotalGames.Text = "Total Games: " + total;

                //I calculate the win percentages here, making sure we don't divide by zero!
                if (total > 0)
                {
                    lbl_PlayerPercent.Text = "Player Win %: " + Math.Round((pWins / total) * 100, 1) + "%";
                    lbl_AIPercent.Text = "AI Win %: " + Math.Round((aWins / total) * 100, 1) + "%";
                }
            }
            else
            {
                //If they open stats before ever playing a game, I just show this message
                lbl_TotalGames.Text = "No games played yet.";
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            //Sending the user back to the main menu at the exact same screen location
            Form1 menuForm = new Form1();
            menuForm.StartPosition = FormStartPosition.Manual;
            menuForm.Location = this.Location;
            menuForm.Show();
            this.Hide();
        }
    }
}