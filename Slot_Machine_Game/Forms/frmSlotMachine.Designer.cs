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
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.btnCashOut = new System.Windows.Forms.Button();
            this.btnSpin = new System.Windows.Forms.Button();
            this.btnIncreaseBet = new System.Windows.Forms.Button();
            this.imgListForReels = new System.Windows.Forms.ImageList(this.components);
            this.lblBet = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDecreaseBet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.txtWinnings = new System.Windows.Forms.TextBox();
            this.lblWinnings = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlotReel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlotReel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlotReel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSlotMachineTitle
            // 
            this.lblSlotMachineTitle.AutoSize = true;
            this.lblSlotMachineTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlotMachineTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblSlotMachineTitle.Image = ((System.Drawing.Image)(resources.GetObject("lblSlotMachineTitle.Image")));
            this.lblSlotMachineTitle.Location = new System.Drawing.Point(27, 22);
            this.lblSlotMachineTitle.Name = "lblSlotMachineTitle";
            this.lblSlotMachineTitle.Size = new System.Drawing.Size(754, 51);
            this.lblSlotMachineTitle.TabIndex = 0;
            this.lblSlotMachineTitle.Text = "                                                             ";
            // 
            // pbSlotReel1
            // 
            this.pbSlotReel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSlotReel1.Location = new System.Drawing.Point(20, 144);
            this.pbSlotReel1.Name = "pbSlotReel1";
            this.pbSlotReel1.Size = new System.Drawing.Size(251, 251);
            this.pbSlotReel1.TabIndex = 1;
            this.pbSlotReel1.TabStop = false;
            // 
            // pbSlotReel2
            // 
            this.pbSlotReel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSlotReel2.Location = new System.Drawing.Point(276, 144);
            this.pbSlotReel2.Name = "pbSlotReel2";
            this.pbSlotReel2.Size = new System.Drawing.Size(251, 251);
            this.pbSlotReel2.TabIndex = 2;
            this.pbSlotReel2.TabStop = false;
            // 
            // pbSlotReel3
            // 
            this.pbSlotReel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSlotReel3.Location = new System.Drawing.Point(532, 144);
            this.pbSlotReel3.Name = "pbSlotReel3";
            this.pbSlotReel3.Size = new System.Drawing.Size(251, 251);
            this.pbSlotReel3.TabIndex = 3;
            this.pbSlotReel3.TabStop = false;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Image = ((System.Drawing.Image)(resources.GetObject("lblBalance.Image")));
            this.lblBalance.Location = new System.Drawing.Point(512, 95);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(154, 24);
            this.lblBalance.TabIndex = 5;
            this.lblBalance.Text = "                        ";
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(675, 94);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 29);
            this.txtBalance.TabIndex = 7;
            this.txtBalance.TabStop = false;
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBet
            // 
            this.txtBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBet.Location = new System.Drawing.Point(614, 485);
            this.txtBet.Multiline = true;
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(58, 55);
            this.txtBet.TabIndex = 10;
            this.txtBet.TabStop = false;
            this.txtBet.Text = "0";
            this.txtBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCashOut
            // 
            this.btnCashOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCashOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCashOut.BackgroundImage")));
            this.btnCashOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCashOut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCashOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCashOut.FlatAppearance.BorderSize = 0;
            this.btnCashOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashOut.Location = new System.Drawing.Point(40, 446);
            this.btnCashOut.Name = "btnCashOut";
            this.btnCashOut.Size = new System.Drawing.Size(231, 68);
            this.btnCashOut.TabIndex = 4;
            this.btnCashOut.UseVisualStyleBackColor = false;
            this.btnCashOut.Click += new System.EventHandler(this.btnCashOut_Click);
            // 
            // btnSpin
            // 
            this.btnSpin.BackColor = System.Drawing.Color.Transparent;
            this.btnSpin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSpin.BackgroundImage")));
            this.btnSpin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpin.Enabled = false;
            this.btnSpin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnSpin.FlatAppearance.BorderSize = 0;
            this.btnSpin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpin.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSpin.Location = new System.Drawing.Point(298, 405);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(203, 202);
            this.btnSpin.TabIndex = 3;
            this.btnSpin.UseVisualStyleBackColor = false;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // btnIncreaseBet
            // 
            this.btnIncreaseBet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnIncreaseBet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncreaseBet.BackgroundImage")));
            this.btnIncreaseBet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIncreaseBet.FlatAppearance.BorderSize = 0;
            this.btnIncreaseBet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncreaseBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncreaseBet.Location = new System.Drawing.Point(675, 483);
            this.btnIncreaseBet.Name = "btnIncreaseBet";
            this.btnIncreaseBet.Size = new System.Drawing.Size(63, 59);
            this.btnIncreaseBet.TabIndex = 2;
            this.btnIncreaseBet.UseVisualStyleBackColor = false;
            this.btnIncreaseBet.Click += new System.EventHandler(this.btnIncreaseBet_Click);
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
            this.lblBet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblBet.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet.ForeColor = System.Drawing.Color.White;
            this.lblBet.Location = new System.Drawing.Point(610, 446);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(61, 29);
            this.lblBet.TabIndex = 11;
            this.lblBet.Text = "BET";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(505, 419);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 170);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(18, 419);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(276, 170);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // btnDecreaseBet
            // 
            this.btnDecreaseBet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDecreaseBet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDecreaseBet.BackgroundImage")));
            this.btnDecreaseBet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDecreaseBet.FlatAppearance.BorderSize = 0;
            this.btnDecreaseBet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecreaseBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecreaseBet.Location = new System.Drawing.Point(544, 483);
            this.btnDecreaseBet.Name = "btnDecreaseBet";
            this.btnDecreaseBet.Size = new System.Drawing.Size(63, 59);
            this.btnDecreaseBet.TabIndex = 15;
            this.btnDecreaseBet.UseVisualStyleBackColor = false;
            this.btnDecreaseBet.Click += new System.EventHandler(this.btnDecreaseBet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(20, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 51);
            this.label1.TabIndex = 16;
            this.label1.Text = "                   ";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerName.Location = new System.Drawing.Point(276, 95);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(100, 29);
            this.txtPlayerName.TabIndex = 17;
            this.txtPlayerName.TabStop = false;
            this.txtPlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWinnings
            // 
            this.txtWinnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWinnings.Location = new System.Drawing.Point(167, 531);
            this.txtWinnings.Name = "txtWinnings";
            this.txtWinnings.Size = new System.Drawing.Size(100, 29);
            this.txtWinnings.TabIndex = 18;
            this.txtWinnings.TabStop = false;
            this.txtWinnings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblWinnings
            // 
            this.lblWinnings.AutoSize = true;
            this.lblWinnings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblWinnings.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnings.ForeColor = System.Drawing.Color.White;
            this.lblWinnings.Location = new System.Drawing.Point(43, 528);
            this.lblWinnings.Name = "lblWinnings";
            this.lblWinnings.Size = new System.Drawing.Size(123, 29);
            this.lblWinnings.TabIndex = 19;
            this.lblWinnings.Text = "Winnings";
            // 
            // frmSlotMachine
            // 
            this.AcceptButton = this.btnIncreaseBet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.CancelButton = this.btnCashOut;
            this.ClientSize = new System.Drawing.Size(802, 624);
            this.Controls.Add(this.lblWinnings);
            this.Controls.Add(this.txtWinnings);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDecreaseBet);
            this.Controls.Add(this.lblBet);
            this.Controls.Add(this.btnIncreaseBet);
            this.Controls.Add(this.txtBet);
            this.Controls.Add(this.btnCashOut);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.lblBalance);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSlotMachineTitle;
        private System.Windows.Forms.PictureBox pbSlotReel1;
        private System.Windows.Forms.PictureBox pbSlotReel2;
        private System.Windows.Forms.PictureBox pbSlotReel3;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.Button btnCashOut;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Button btnIncreaseBet;
        private System.Windows.Forms.ImageList imgListForReels;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDecreaseBet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.TextBox txtWinnings;
        private System.Windows.Forms.Label lblWinnings;
    }
}