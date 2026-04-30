using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VsRobot robotplay = new VsRobot();
            robotplay.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VsPlayer secondform = new VsPlayer();
            secondform.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Creating the stats form
            StatsForm stats = new StatsForm();

            //Setting the location so the window doesn't jump around
            stats.StartPosition = FormStartPosition.Manual;
            stats.Location = this.Location;

            //Showing the stats and hiding the menu
            stats.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
