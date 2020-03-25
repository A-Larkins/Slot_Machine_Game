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

// Main game form. 

namespace Slot_Machine_Game.Forms
{
    public partial class frmSlotMachine : Form
    {
        // Class attributes.
        // Keep track of num bets, winnings, score.
        private int numberOfBets = 0;
        private int winnings = 0;
        private int score = GlobalsClass.playerObject.getBalance();

        // Constructor.
        public frmSlotMachine()
        {
            InitializeComponent();
        }

        // Load event method to show the balance that
        // the player entered in the welcome form.
        private void frmSlotMachine_Load(object sender, EventArgs e)
        {
            txtBalance.Text = score.ToString();
        }

        // Click event handler method for the + button.
        // Increments the current bet.
        // Bet must be 1-3.
        private void btnIncreaseBet_Click(object sender, EventArgs e)
        {

        }

        // Click event handler method for the - button.
        // Decrements the current bet.
        private void btnDecreaseBet_Click(object sender, EventArgs e)
        {

        }

        // Click event handler method for the spin button.
        private void btnSpin_Click(object sender, EventArgs e)
        {

        }

        // Click event handler method to exit slot machine form
        // and go to display winnings form.
        private void btnCashOut_Click(object sender, EventArgs e)
        {
            Form frmDisplayWinnings = new Forms.frmDisplayWinnings();
            frmDisplayWinnings.Show();
            this.Hide();
        }

        // This method uses an object of the stopwatch class
        // to set a timer for 3 seconds between each random
        // fruit image.
        private void spinFruitReels ()
        {

        }

        // Get a random fruit image for reel 1.
        private void spinReel_1()
        {

        }

        // Get a random fruit image for reel 2.
        private void spinReel_2()
        {

        }

        // Get a random fruit image for reel 3.
        private void spinReel_3()
        {

        }




    }
}
