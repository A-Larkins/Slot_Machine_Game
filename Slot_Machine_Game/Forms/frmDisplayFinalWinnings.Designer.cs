namespace Slot_Machine_Game.Forms
{
    partial class frmDisplayFinalWinnings
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
            this.lblWinnings = new System.Windows.Forms.Label();
            this.lblCoinsWon = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnViewTop5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWinnings
            // 
            this.lblWinnings.AutoSize = true;
            this.lblWinnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnings.ForeColor = System.Drawing.Color.Maroon;
            this.lblWinnings.Location = new System.Drawing.Point(38, 20);
            this.lblWinnings.Name = "lblWinnings";
            this.lblWinnings.Size = new System.Drawing.Size(176, 26);
            this.lblWinnings.TabIndex = 0;
            this.lblWinnings.Text = "Total Winnings:";
            // 
            // lblCoinsWon
            // 
            this.lblCoinsWon.AutoSize = true;
            this.lblCoinsWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoinsWon.Location = new System.Drawing.Point(109, 63);
            this.lblCoinsWon.Name = "lblCoinsWon";
            this.lblCoinsWon.Size = new System.Drawing.Size(25, 26);
            this.lblCoinsWon.TabIndex = 1;
            this.lblCoinsWon.Text = "0";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.Location = new System.Drawing.Point(12, 157);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(113, 44);
            this.btnPlayAgain.TabIndex = 2;
            this.btnPlayAgain.Text = "Play Again!";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(131, 157);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 44);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnViewTop5
            // 
            this.btnViewTop5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTop5.Location = new System.Drawing.Point(12, 107);
            this.btnViewTop5.Name = "btnViewTop5";
            this.btnViewTop5.Size = new System.Drawing.Size(232, 44);
            this.btnViewTop5.TabIndex = 1;
            this.btnViewTop5.Text = "View Top 5 Leaderboard";
            this.btnViewTop5.UseVisualStyleBackColor = true;
            this.btnViewTop5.Click += new System.EventHandler(this.btnViewTop5_Click);
            // 
            // frmDisplayWinnings
            // 
            this.AcceptButton = this.btnViewTop5;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(257, 225);
            this.Controls.Add(this.btnViewTop5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lblCoinsWon);
            this.Controls.Add(this.lblWinnings);
            this.Name = "frmDisplayWinnings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Over";
            this.Load += new System.EventHandler(this.frmDisplayWinnings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWinnings;
        private System.Windows.Forms.Label lblCoinsWon;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnViewTop5;
    }
}