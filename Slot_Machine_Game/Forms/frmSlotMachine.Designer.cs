namespace Slot_Machine_Game.Forms
{
    partial class frmSlotMachine
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
            this.lblSlotMachineTitle = new System.Windows.Forms.Label();
            this.pbSlotReel1 = new System.Windows.Forms.PictureBox();
            this.pbSlotReel2 = new System.Windows.Forms.PictureBox();
            this.pbSlotReel3 = new System.Windows.Forms.PictureBox();
            this.lblWinnings = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtWinnings = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.btnCashOut = new System.Windows.Forms.Button();
            this.btnSpin = new System.Windows.Forms.Button();
            this.btnIncreaseBet = new System.Windows.Forms.Button();
            this.btnDecreaseBet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlotReel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlotReel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlotReel3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSlotMachineTitle
            // 
            this.lblSlotMachineTitle.AutoSize = true;
            this.lblSlotMachineTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlotMachineTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblSlotMachineTitle.Location = new System.Drawing.Point(249, 30);
            this.lblSlotMachineTitle.Name = "lblSlotMachineTitle";
            this.lblSlotMachineTitle.Size = new System.Drawing.Size(297, 51);
            this.lblSlotMachineTitle.TabIndex = 0;
            this.lblSlotMachineTitle.Text = "Slot Machine!";
            // 
            // pbSlotReel1
            // 
            this.pbSlotReel1.Location = new System.Drawing.Point(75, 99);
            this.pbSlotReel1.Name = "pbSlotReel1";
            this.pbSlotReel1.Size = new System.Drawing.Size(165, 158);
            this.pbSlotReel1.TabIndex = 1;
            this.pbSlotReel1.TabStop = false;
            // 
            // pbSlotReel2
            // 
            this.pbSlotReel2.Location = new System.Drawing.Point(312, 99);
            this.pbSlotReel2.Name = "pbSlotReel2";
            this.pbSlotReel2.Size = new System.Drawing.Size(165, 158);
            this.pbSlotReel2.TabIndex = 2;
            this.pbSlotReel2.TabStop = false;
            // 
            // pbSlotReel3
            // 
            this.pbSlotReel3.Location = new System.Drawing.Point(543, 99);
            this.pbSlotReel3.Name = "pbSlotReel3";
            this.pbSlotReel3.Size = new System.Drawing.Size(165, 158);
            this.pbSlotReel3.TabIndex = 3;
            this.pbSlotReel3.TabStop = false;
            // 
            // lblWinnings
            // 
            this.lblWinnings.AutoSize = true;
            this.lblWinnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnings.Location = new System.Drawing.Point(71, 300);
            this.lblWinnings.Name = "lblWinnings";
            this.lblWinnings.Size = new System.Drawing.Size(97, 24);
            this.lblWinnings.TabIndex = 4;
            this.lblWinnings.Text = "Winnings";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(308, 300);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(85, 24);
            this.lblBalance.TabIndex = 5;
            this.lblBalance.Text = "Balance";
            // 
            // txtWinnings
            // 
            this.txtWinnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWinnings.Location = new System.Drawing.Point(174, 296);
            this.txtWinnings.Name = "txtWinnings";
            this.txtWinnings.Size = new System.Drawing.Size(100, 29);
            this.txtWinnings.TabIndex = 1;
            this.txtWinnings.TabStop = false;
            this.txtWinnings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(399, 297);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 29);
            this.txtBalance.TabIndex = 7;
            this.txtBalance.TabStop = false;
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBet
            // 
            this.txtBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBet.Location = new System.Drawing.Point(294, 351);
            this.txtBet.Multiline = true;
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(110, 55);
            this.txtBet.TabIndex = 10;
            this.txtBet.TabStop = false;
            this.txtBet.Text = "0";
            this.txtBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCashOut
            // 
            this.btnCashOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashOut.Location = new System.Drawing.Point(543, 296);
            this.btnCashOut.Name = "btnCashOut";
            this.btnCashOut.Size = new System.Drawing.Size(165, 30);
            this.btnCashOut.TabIndex = 4;
            this.btnCashOut.Text = "Cash Out";
            this.btnCashOut.UseVisualStyleBackColor = true;
            // 
            // btnSpin
            // 
            this.btnSpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpin.Location = new System.Drawing.Point(424, 349);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(284, 57);
            this.btnSpin.TabIndex = 3;
            this.btnSpin.Text = "SPIN!";
            this.btnSpin.UseVisualStyleBackColor = true;
            // 
            // btnIncreaseBet
            // 
            this.btnIncreaseBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncreaseBet.Location = new System.Drawing.Point(183, 351);
            this.btnIncreaseBet.Name = "btnIncreaseBet";
            this.btnIncreaseBet.Size = new System.Drawing.Size(81, 55);
            this.btnIncreaseBet.TabIndex = 2;
            this.btnIncreaseBet.Text = "+";
            this.btnIncreaseBet.UseVisualStyleBackColor = true;
            // 
            // btnDecreaseBet
            // 
            this.btnDecreaseBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecreaseBet.Location = new System.Drawing.Point(75, 351);
            this.btnDecreaseBet.Name = "btnDecreaseBet";
            this.btnDecreaseBet.Size = new System.Drawing.Size(81, 55);
            this.btnDecreaseBet.TabIndex = 1;
            this.btnDecreaseBet.Text = "-";
            this.btnDecreaseBet.UseVisualStyleBackColor = true;
            // 
            // frmSlotMachine
            // 
            this.AcceptButton = this.btnSpin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDecreaseBet);
            this.Controls.Add(this.btnIncreaseBet);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.btnCashOut);
            this.Controls.Add(this.txtBet);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtWinnings);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblWinnings);
            this.Controls.Add(this.pbSlotReel3);
            this.Controls.Add(this.pbSlotReel2);
            this.Controls.Add(this.pbSlotReel1);
            this.Controls.Add(this.lblSlotMachineTitle);
            this.Name = "frmSlotMachine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slot Machine";
            ((System.ComponentModel.ISupportInitialize)(this.pbSlotReel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlotReel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlotReel3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSlotMachineTitle;
        private System.Windows.Forms.PictureBox pbSlotReel1;
        private System.Windows.Forms.PictureBox pbSlotReel2;
        private System.Windows.Forms.PictureBox pbSlotReel3;
        private System.Windows.Forms.Label lblWinnings;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtWinnings;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.Button btnCashOut;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Button btnIncreaseBet;
        private System.Windows.Forms.Button btnDecreaseBet;
    }
}