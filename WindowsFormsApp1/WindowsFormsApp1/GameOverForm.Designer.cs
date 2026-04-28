namespace WindowsFormsApp1
{
    partial class GameOverForm
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
            this.lbl_Result = new System.Windows.Forms.Label();
            this.btn_PlayAgain = new System.Windows.Forms.Button();
            this.btn_ReviewGame = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Main = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.BackColor = System.Drawing.Color.MintCream;
            this.lbl_Result.Font = new System.Drawing.Font("Stencil", 50F);
            this.lbl_Result.Location = new System.Drawing.Point(133, 35);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(429, 80);
            this.lbl_Result.TabIndex = 0;
            this.lbl_Result.Text = "lbl_Result";
            // 
            // btn_PlayAgain
            // 
            this.btn_PlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlayAgain.Location = new System.Drawing.Point(45, 260);
            this.btn_PlayAgain.Name = "btn_PlayAgain";
            this.btn_PlayAgain.Size = new System.Drawing.Size(229, 64);
            this.btn_PlayAgain.TabIndex = 1;
            this.btn_PlayAgain.Text = "Play Again";
            this.btn_PlayAgain.UseVisualStyleBackColor = true;
            this.btn_PlayAgain.Click += new System.EventHandler(this.btn_PlayAgain_Click_1);
            // 
            // btn_ReviewGame
            // 
            this.btn_ReviewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReviewGame.Location = new System.Drawing.Point(280, 260);
            this.btn_ReviewGame.Name = "btn_ReviewGame";
            this.btn_ReviewGame.Size = new System.Drawing.Size(229, 64);
            this.btn_ReviewGame.TabIndex = 2;
            this.btn_ReviewGame.Text = "Review Board";
            this.btn_ReviewGame.UseVisualStyleBackColor = true;
            this.btn_ReviewGame.Click += new System.EventHandler(this.btn_ReviewGame_Click_1);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Exit.Location = new System.Drawing.Point(703, 35);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(66, 64);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click_1);
            // 
            // btn_Main
            // 
            this.btn_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Main.Location = new System.Drawing.Point(515, 260);
            this.btn_Main.Name = "btn_Main";
            this.btn_Main.Size = new System.Drawing.Size(229, 64);
            this.btn_Main.TabIndex = 4;
            this.btn_Main.Text = "Return To Main";
            this.btn_Main.UseVisualStyleBackColor = true;
            this.btn_Main.Click += new System.EventHandler(this.btn_Main_Click);
            // 
            // GameOverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Main);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_ReviewGame);
            this.Controls.Add(this.btn_PlayAgain);
            this.Controls.Add(this.lbl_Result);
            this.Name = "GameOverForm";
            this.Text = "GameOverForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.Button btn_PlayAgain;
        private System.Windows.Forms.Button btn_ReviewGame;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Main;
    }
}