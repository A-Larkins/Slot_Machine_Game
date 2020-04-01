/*
 * Andrew Larkins
 * Eric Friedman
 * CIS-3309
 * Slot Machine Game
 * 03/21/20
 * updated 4/1/20
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Slot_Machine_Game.Classes;

// Final form to show total winnings.
// Player can play again or exit the game.

namespace Slot_Machine_Game.Forms
{
    public partial class frmDisplayFinalWinnings : Form
    {
        public frmDisplayFinalWinnings()
        {
            InitializeComponent();
        }

        // Show winnings upon load with this event handler.
        // Update leaderboard!!
        private void frmDisplayWinnings_Load(object sender, EventArgs e)
        {
            lblCoinsWon.Text = GlobalsClass.playerObject.getScore().ToString();
            GlobalsClass.leaderboardObject.update(GlobalsClass.playerObject.playerToString());
        }

        // Exit button click event handler.
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Play again button click event handler.
        // Reset player.
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            GlobalsClass.playerObject.reset();
            Form newGame = new frmWelcomePage();
            newGame.Show();
            this.Close();
        }

        // Click event handler for the button to view top 5 leaderboard
        // in a messagebox.
        private void btnViewTop5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GlobalsClass.leaderboardObject.getDisplay(), "Leaderboard");
        }




    }
}
