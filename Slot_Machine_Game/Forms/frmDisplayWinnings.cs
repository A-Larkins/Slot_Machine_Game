/*
 * Andrew Larkins
 * Eric Friedman
 * CIS-3309
 * Slot Machine Game
 * 03/21/20
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
    public partial class frmDisplayWinnings : Form
    {
        public frmDisplayWinnings()
        {
            InitializeComponent();
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

        // Might show a top 10 leaderboard since we have
        // a player class to work with.
        // private void btnLeaderBoard_Click(.., .. ) { }

    }
}
