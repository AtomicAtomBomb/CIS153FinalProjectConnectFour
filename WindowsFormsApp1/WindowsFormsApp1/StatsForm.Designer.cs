namespace WindowsFormsApp1
{
    partial class StatsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_PlayerWins = new System.Windows.Forms.Label();
            this.lbl_AIWins = new System.Windows.Forms.Label();
            this.lbl_Ties = new System.Windows.Forms.Label();
            this.lbl_TotalGames = new System.Windows.Forms.Label();
            this.lbl_PlayerPercent = new System.Windows.Forms.Label();
            this.lbl_AIPercent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_PlayerWins
            // 
            this.lbl_PlayerWins.AutoSize = true;
            this.lbl_PlayerWins.Location = new System.Drawing.Point(56, 59);
            this.lbl_PlayerWins.Name = "lbl_PlayerWins";
            this.lbl_PlayerWins.Size = new System.Drawing.Size(76, 13);
            this.lbl_PlayerWins.TabIndex = 0;
            this.lbl_PlayerWins.Text = "lbl_PlayerWins";
            // 
            // lbl_AIWins
            // 
            this.lbl_AIWins.AutoSize = true;
            this.lbl_AIWins.Location = new System.Drawing.Point(169, 59);
            this.lbl_AIWins.Name = "lbl_AIWins";
            this.lbl_AIWins.Size = new System.Drawing.Size(57, 13);
            this.lbl_AIWins.TabIndex = 1;
            this.lbl_AIWins.Text = "lbl_AIWins";
            // 
            // lbl_Ties
            // 
            this.lbl_Ties.AutoSize = true;
            this.lbl_Ties.Location = new System.Drawing.Point(288, 59);
            this.lbl_Ties.Name = "lbl_Ties";
            this.lbl_Ties.Size = new System.Drawing.Size(43, 13);
            this.lbl_Ties.TabIndex = 2;
            this.lbl_Ties.Text = "lbl_Ties";
            // 
            // lbl_TotalGames
            // 
            this.lbl_TotalGames.AutoSize = true;
            this.lbl_TotalGames.Location = new System.Drawing.Point(398, 59);
            this.lbl_TotalGames.Name = "lbl_TotalGames";
            this.lbl_TotalGames.Size = new System.Drawing.Size(80, 13);
            this.lbl_TotalGames.TabIndex = 3;
            this.lbl_TotalGames.Text = "lbl_TotalGames";
            // 
            // lbl_PlayerPercent
            // 
            this.lbl_PlayerPercent.AutoSize = true;
            this.lbl_PlayerPercent.Location = new System.Drawing.Point(536, 59);
            this.lbl_PlayerPercent.Name = "lbl_PlayerPercent";
            this.lbl_PlayerPercent.Size = new System.Drawing.Size(89, 13);
            this.lbl_PlayerPercent.TabIndex = 4;
            this.lbl_PlayerPercent.Text = "lbl_PlayerPercent";
            // 
            // lbl_AIPercent
            // 
            this.lbl_AIPercent.AutoSize = true;
            this.lbl_AIPercent.Location = new System.Drawing.Point(686, 59);
            this.lbl_AIPercent.Name = "lbl_AIPercent";
            this.lbl_AIPercent.Size = new System.Drawing.Size(70, 13);
            this.lbl_AIPercent.TabIndex = 5;
            this.lbl_AIPercent.Text = "lbl_AIPercent";
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_AIPercent);
            this.Controls.Add(this.lbl_PlayerPercent);
            this.Controls.Add(this.lbl_TotalGames);
            this.Controls.Add(this.lbl_Ties);
            this.Controls.Add(this.lbl_AIWins);
            this.Controls.Add(this.lbl_PlayerWins);
            this.Name = "StatsForm";
            this.Text = "StatsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_PlayerWins;
        private System.Windows.Forms.Label lbl_AIWins;
        private System.Windows.Forms.Label lbl_Ties;
        private System.Windows.Forms.Label lbl_TotalGames;
        private System.Windows.Forms.Label lbl_PlayerPercent;
        private System.Windows.Forms.Label lbl_AIPercent;
    }
}