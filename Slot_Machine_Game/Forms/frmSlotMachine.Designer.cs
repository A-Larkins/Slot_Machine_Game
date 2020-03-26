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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSlotMachine));
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
            this.imgListForReels = new System.Windows.Forms.ImageList(this.components);
            this.lblBet = new System.Windows.Forms.Label();
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
            this.lblSlotMachineTitle.Location = new System.Drawing.Point(248, 19);
            this.lblSlotMachineTitle.Name = "lblSlotMachineTitle";
            this.lblSlotMachineTitle.Size = new System.Drawing.Size(297, 51);
            this.lblSlotMachineTitle.TabIndex = 0;
            this.lblSlotMachineTitle.Text = "Slot Machine!";
            // 
            // pbSlotReel1
            // 
            this.pbSlotReel1.Location = new System.Drawing.Point(12, 84);
            this.pbSlotReel1.Name = "pbSlotReel1";
            this.pbSlotReel1.Size = new System.Drawing.Size(250, 250);
            this.pbSlotReel1.TabIndex = 1;
            this.pbSlotReel1.TabStop = false;
            // 
            // pbSlotReel2
            // 
            this.pbSlotReel2.Location = new System.Drawing.Point(268, 84);
            this.pbSlotReel2.Name = "pbSlotReel2";
            this.pbSlotReel2.Size = new System.Drawing.Size(250, 250);
            this.pbSlotReel2.TabIndex = 2;
            this.pbSlotReel2.TabStop = false;
            // 
            // pbSlotReel3
            // 
            this.pbSlotReel3.Location = new System.Drawing.Point(524, 84);
            this.pbSlotReel3.Name = "pbSlotReel3";
            this.pbSlotReel3.Size = new System.Drawing.Size(250, 250);
            this.pbSlotReel3.TabIndex = 3;
            this.pbSlotReel3.TabStop = false;
            // 
            // lblWinnings
            // 
            this.lblWinnings.AutoSize = true;
            this.lblWinnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnings.Location = new System.Drawing.Point(46, 522);
            this.lblWinnings.Name = "lblWinnings";
            this.lblWinnings.Size = new System.Drawing.Size(103, 24);
            this.lblWinnings.TabIndex = 4;
            this.lblWinnings.Text = "Winnings:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(310, 522);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(91, 24);
            this.lblBalance.TabIndex = 5;
            this.lblBalance.Text = "Balance:";
            // 
            // txtWinnings
            // 
            this.txtWinnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWinnings.Location = new System.Drawing.Point(155, 519);
            this.txtWinnings.Name = "txtWinnings";
            this.txtWinnings.Size = new System.Drawing.Size(100, 29);
            this.txtWinnings.TabIndex = 1;
            this.txtWinnings.TabStop = false;
            this.txtWinnings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(407, 519);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 29);
            this.txtBalance.TabIndex = 7;
            this.txtBalance.TabStop = false;
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBet
            // 
            this.txtBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBet.Location = new System.Drawing.Point(194, 364);
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
            this.btnCashOut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCashOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashOut.Location = new System.Drawing.Point(552, 519);
            this.btnCashOut.Name = "btnCashOut";
            this.btnCashOut.Size = new System.Drawing.Size(167, 31);
            this.btnCashOut.TabIndex = 4;
            this.btnCashOut.Text = "Cash Out";
            this.btnCashOut.UseVisualStyleBackColor = true;
            this.btnCashOut.Click += new System.EventHandler(this.btnCashOut_Click);
            // 
            // btnSpin
            // 
            this.btnSpin.Enabled = false;
            this.btnSpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpin.Location = new System.Drawing.Point(407, 382);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(284, 77);
            this.btnSpin.TabIndex = 3;
            this.btnSpin.Text = "SPIN!";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // btnIncreaseBet
            // 
            this.btnIncreaseBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncreaseBet.Location = new System.Drawing.Point(223, 425);
            this.btnIncreaseBet.Name = "btnIncreaseBet";
            this.btnIncreaseBet.Size = new System.Drawing.Size(81, 55);
            this.btnIncreaseBet.TabIndex = 2;
            this.btnIncreaseBet.Text = "+";
            this.btnIncreaseBet.UseVisualStyleBackColor = true;
            this.btnIncreaseBet.Click += new System.EventHandler(this.btnIncreaseBet_Click);
            // 
            // btnDecreaseBet
            // 
            this.btnDecreaseBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecreaseBet.Location = new System.Drawing.Point(136, 425);
            this.btnDecreaseBet.Name = "btnDecreaseBet";
            this.btnDecreaseBet.Size = new System.Drawing.Size(81, 55);
            this.btnDecreaseBet.TabIndex = 1;
            this.btnDecreaseBet.Text = "-";
            this.btnDecreaseBet.UseVisualStyleBackColor = true;
            this.btnDecreaseBet.Visible = false;
            this.btnDecreaseBet.Click += new System.EventHandler(this.btnDecreaseBet_Click);
            // 
            // imgListForReels
            // 
            this.imgListForReels.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListForReels.ImageStream")));
            this.imgListForReels.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListForReels.Images.SetKeyName(0, "pic1_seven.png");
            this.imgListForReels.Images.SetKeyName(1, "pic2_banana.png");
            this.imgListForReels.Images.SetKeyName(2, "pic3_apple.png");
            this.imgListForReels.Images.SetKeyName(3, "pic4_orange.png");
            this.imgListForReels.Images.SetKeyName(4, "pic5_cherry.png");
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet.Location = new System.Drawing.Point(142, 382);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(46, 24);
            this.lblBet.TabIndex = 11;
            this.lblBet.Text = "Bet:";
            // 
            // frmSlotMachine
            // 
            this.AcceptButton = this.btnSpin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCashOut;
            this.ClientSize = new System.Drawing.Size(788, 581);
            this.Controls.Add(this.lblBet);
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
            this.Load += new System.EventHandler(this.frmSlotMachine_Load);
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
        private System.Windows.Forms.ImageList imgListForReels;
        private System.Windows.Forms.Label lblBet;
    }
}