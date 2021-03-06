﻿namespace Slot_Machine_Game.Forms
{
    partial class frmDisplayWinnings
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
            this.txtDisplayWinnings = new System.Windows.Forms.TextBox();
            this.lblWinnings = new System.Windows.Forms.Label();
            this.lblPlus = new System.Windows.Forms.Label();
            this.lblCoins = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplayWinnings
            // 
            this.txtDisplayWinnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayWinnings.Location = new System.Drawing.Point(94, 121);
            this.txtDisplayWinnings.Name = "txtDisplayWinnings";
            this.txtDisplayWinnings.ReadOnly = true;
            this.txtDisplayWinnings.Size = new System.Drawing.Size(138, 80);
            this.txtDisplayWinnings.TabIndex = 0;
            this.txtDisplayWinnings.TabStop = false;
            this.txtDisplayWinnings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblWinnings
            // 
            this.lblWinnings.AutoSize = true;
            this.lblWinnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnings.Location = new System.Drawing.Point(63, 49);
            this.lblWinnings.Name = "lblWinnings";
            this.lblWinnings.Size = new System.Drawing.Size(254, 26);
            this.lblWinnings.TabIndex = 1;
            this.lblWinnings.Text = "Display Winnings Here";
            this.lblWinnings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPlus
            // 
            this.lblPlus.AutoSize = true;
            this.lblPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlus.Location = new System.Drawing.Point(19, 127);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Size = new System.Drawing.Size(69, 73);
            this.lblPlus.TabIndex = 2;
            this.lblPlus.Text = "+";
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoins.Location = new System.Drawing.Point(238, 123);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(201, 73);
            this.lblCoins.TabIndex = 3;
            this.lblCoins.Text = "Coins";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(455, 120);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(313, 80);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Play!";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmDisplayWinnings
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 271);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblCoins);
            this.Controls.Add(this.lblPlus);
            this.Controls.Add(this.lblWinnings);
            this.Controls.Add(this.txtDisplayWinnings);
            this.Location = new System.Drawing.Point(551, 620);
            this.Name = "frmDisplayWinnings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Winnings Payout";
            this.Load += new System.EventHandler(this.frmWinLose_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplayWinnings;
        private System.Windows.Forms.Label lblWinnings;
        private System.Windows.Forms.Label lblPlus;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.Button btnOK;

    }
}