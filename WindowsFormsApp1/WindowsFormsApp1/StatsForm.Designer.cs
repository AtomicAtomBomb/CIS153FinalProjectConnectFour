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
            this.btn_StatsReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_StatReset = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_PlayerWins
            // 
            this.lbl_PlayerWins.AutoSize = true;
            this.lbl_PlayerWins.BackColor = System.Drawing.Color.White;
            this.lbl_PlayerWins.Location = new System.Drawing.Point(161, 59);
            this.lbl_PlayerWins.Name = "lbl_PlayerWins";
            this.lbl_PlayerWins.Size = new System.Drawing.Size(76, 13);
            this.lbl_PlayerWins.TabIndex = 0;
            this.lbl_PlayerWins.Text = "lbl_PlayerWins";
            // 
            // lbl_AIWins
            // 
            this.lbl_AIWins.AutoSize = true;
            this.lbl_AIWins.BackColor = System.Drawing.Color.White;
            this.lbl_AIWins.Location = new System.Drawing.Point(425, 59);
            this.lbl_AIWins.Name = "lbl_AIWins";
            this.lbl_AIWins.Size = new System.Drawing.Size(57, 13);
            this.lbl_AIWins.TabIndex = 1;
            this.lbl_AIWins.Text = "lbl_AIWins";
            // 
            // lbl_Ties
            // 
            this.lbl_Ties.AutoSize = true;
            this.lbl_Ties.BackColor = System.Drawing.Color.White;
            this.lbl_Ties.Location = new System.Drawing.Point(628, 59);
            this.lbl_Ties.Name = "lbl_Ties";
            this.lbl_Ties.Size = new System.Drawing.Size(43, 13);
            this.lbl_Ties.TabIndex = 2;
            this.lbl_Ties.Text = "lbl_Ties";
            // 
            // lbl_TotalGames
            // 
            this.lbl_TotalGames.AutoSize = true;
            this.lbl_TotalGames.BackColor = System.Drawing.Color.White;
            this.lbl_TotalGames.Location = new System.Drawing.Point(240, 115);
            this.lbl_TotalGames.Name = "lbl_TotalGames";
            this.lbl_TotalGames.Size = new System.Drawing.Size(80, 13);
            this.lbl_TotalGames.TabIndex = 3;
            this.lbl_TotalGames.Text = "lbl_TotalGames";
            // 
            // lbl_PlayerPercent
            // 
            this.lbl_PlayerPercent.AutoSize = true;
            this.lbl_PlayerPercent.BackColor = System.Drawing.Color.White;
            this.lbl_PlayerPercent.Location = new System.Drawing.Point(488, 115);
            this.lbl_PlayerPercent.Name = "lbl_PlayerPercent";
            this.lbl_PlayerPercent.Size = new System.Drawing.Size(89, 13);
            this.lbl_PlayerPercent.TabIndex = 4;
            this.lbl_PlayerPercent.Text = "lbl_PlayerPercent";
            // 
            // lbl_AIPercent
            // 
            this.lbl_AIPercent.AutoSize = true;
            this.lbl_AIPercent.BackColor = System.Drawing.Color.White;
            this.lbl_AIPercent.Location = new System.Drawing.Point(687, 115);
            this.lbl_AIPercent.Name = "lbl_AIPercent";
            this.lbl_AIPercent.Size = new System.Drawing.Size(70, 13);
            this.lbl_AIPercent.TabIndex = 5;
            this.lbl_AIPercent.Text = "lbl_AIPercent";
            // 
            // btn_StatsReturn
            // 
            this.btn_StatsReturn.Location = new System.Drawing.Point(122, 362);
            this.btn_StatsReturn.Name = "btn_StatsReturn";
            this.btn_StatsReturn.Size = new System.Drawing.Size(115, 46);
            this.btn_StatsReturn.TabIndex = 6;
            this.btn_StatsReturn.Text = "Return";
            this.btn_StatsReturn.UseVisualStyleBackColor = true;
            this.btn_StatsReturn.Click += new System.EventHandler(this.btn_StatsReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Player Wins:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(330, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "AI Wins:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total Games Played:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(563, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ties:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(330, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Player Win %:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(583, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "AI Win %:";
            // 
            // btn_StatReset
            // 
            this.btn_StatReset.Location = new System.Drawing.Point(507, 362);
            this.btn_StatReset.Name = "btn_StatReset";
            this.btn_StatReset.Size = new System.Drawing.Size(115, 46);
            this.btn_StatReset.TabIndex = 6;
            this.btn_StatReset.Text = "Reset Stats";
            this.btn_StatReset.UseVisualStyleBackColor = true;
            this.btn_StatReset.Click += new System.EventHandler(this.btn_StatsReset_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(321, 362);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(115, 46);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_StatReset);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_StatsReturn);
            this.Controls.Add(this.lbl_AIPercent);
            this.Controls.Add(this.lbl_PlayerPercent);
            this.Controls.Add(this.lbl_TotalGames);
            this.Controls.Add(this.lbl_Ties);
            this.Controls.Add(this.lbl_AIWins);
            this.Controls.Add(this.lbl_PlayerWins);
            this.Name = "StatsForm";
            this.Text = "StatsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StatsForm_FormClosing);
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
        private System.Windows.Forms.Button btn_StatsReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_StatReset;
        private System.Windows.Forms.Button btn_exit;
    }
}