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
            this.SuspendLayout();
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Location = new System.Drawing.Point(378, 180);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(53, 13);
            this.lbl_Result.TabIndex = 0;
            this.lbl_Result.Text = "lbl_Result";
            // 
            // btn_PlayAgain
            // 
            this.btn_PlayAgain.Location = new System.Drawing.Point(174, 286);
            this.btn_PlayAgain.Name = "btn_PlayAgain";
            this.btn_PlayAgain.Size = new System.Drawing.Size(75, 23);
            this.btn_PlayAgain.TabIndex = 1;
            this.btn_PlayAgain.Text = "btn_PlayAgain";
            this.btn_PlayAgain.UseVisualStyleBackColor = true;
            // 
            // btn_ReviewGame
            // 
            this.btn_ReviewGame.Location = new System.Drawing.Point(356, 286);
            this.btn_ReviewGame.Name = "btn_ReviewGame";
            this.btn_ReviewGame.Size = new System.Drawing.Size(75, 23);
            this.btn_ReviewGame.TabIndex = 2;
            this.btn_ReviewGame.Text = "btn_ReviewGame";
            this.btn_ReviewGame.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(499, 286);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "btn_Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // GameOverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}