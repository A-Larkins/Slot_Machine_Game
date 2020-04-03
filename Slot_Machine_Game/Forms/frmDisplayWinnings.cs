using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Form showed instead of the messagebox to show how much
// the player has won after each spin.


namespace Slot_Machine_Game.Forms
{
    public partial class frmDisplayWinnings : Form
    {

        // Constructor that  creates form that shows
        // the winnings that was passed to it.
        public frmDisplayWinnings(string inWinnings)
        {
            InitializeComponent();
            txtDisplayWinnings.Text = inWinnings;

        }

        // Load form method. If there's a jackpot or 0 give a special message,
        // otherwise print the winnings.
        private void frmWinLose_Load(object sender, EventArgs e)
        {
            // convert txt winnings to int
            int winnings = Convert.ToInt32(txtDisplayWinnings.Text);

            if (winnings == 300)
            {
                lblWinnings.Text = "Jackpot, go crazy folks!";
            }
            else if (winnings == 100)
            {
                lblWinnings.Text = "And boom goes the dynamite.";
            }
            else if (winnings == 150 || winnings == 200)
            {
                lblWinnings.Text = "Now gamble it all away...";
            }
            else if (winnings >= 25 && winnings <= 75)
            {
                lblWinnings.Text = "It's not broken.. !?!";
            }
            else if (winnings == 15)
            {
                lblWinnings.Text = "It's all about the cherries...";
            }
            else if (winnings == 3)
            {
                lblWinnings.Text = "Losing feels worse than winning feels good.";
            }

            else if (winnings == 0)
            {
                lblWinnings.Text = "Slump? You're not in a slump. You're just not hitting...";
            }
            else 
            {
                lblWinnings.Text = "You win!";
            }

        }

        // Ok button just hides the form.
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
