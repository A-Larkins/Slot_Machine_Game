namespace Slot_Machine_Game.Forms
{
    partial class frmExplainRulesPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExplainRulesPage));
            this.lblRules = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pbWinningsTable = new System.Windows.Forms.PictureBox();
            this.lblWinningsTable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbWinningsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.Location = new System.Drawing.Point(68, 27);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(349, 120);
            this.lblRules.TabIndex = 0;
            this.lblRules.Text = resources.GetString("lblRules.Text");
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(488, 27);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(239, 120);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play!";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pbWinningsTable
            // 
            this.pbWinningsTable.Image = ((System.Drawing.Image)(resources.GetObject("pbWinningsTable.Image")));
            this.pbWinningsTable.Location = new System.Drawing.Point(72, 181);
            this.pbWinningsTable.Name = "pbWinningsTable";
            this.pbWinningsTable.Size = new System.Drawing.Size(655, 410);
            this.pbWinningsTable.TabIndex = 3;
            this.pbWinningsTable.TabStop = false;
            // 
            // lblWinningsTable
            // 
            this.lblWinningsTable.AutoSize = true;
            this.lblWinningsTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinningsTable.ForeColor = System.Drawing.Color.Maroon;
            this.lblWinningsTable.Location = new System.Drawing.Point(270, 181);
            this.lblWinningsTable.Name = "lblWinningsTable";
            this.lblWinningsTable.Size = new System.Drawing.Size(253, 37);
            this.lblWinningsTable.TabIndex = 4;
            this.lblWinningsTable.Text = "Winnings Table";
            // 
            // frmExplainRulesPage
            // 
            this.AcceptButton = this.btnPlay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 603);
            this.Controls.Add(this.lblWinningsTable);
            this.Controls.Add(this.pbWinningsTable);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblRules);
            this.Name = "frmExplainRulesPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rules Page";
            ((System.ComponentModel.ISupportInitialize)(this.pbWinningsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox pbWinningsTable;
        private System.Windows.Forms.Label lblWinningsTable;
    }
}