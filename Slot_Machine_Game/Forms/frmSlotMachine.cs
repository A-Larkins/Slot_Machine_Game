﻿/*
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
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Slot_Machine_Game.Classes;

// Main game form. 

namespace Slot_Machine_Game.Forms
{
    public partial class frmSlotMachine : Form
    {
        // Class attributes. Keep track of num bets, winnings, totalScore.
        private int currentBet = 0;
        private int winnings = 0;
        private int totalScore = GlobalsClass.playerObject.getBalance();
        private string name = GlobalsClass.playerObject.getName();

        // Array for keeping track of which pictures are picked using the random nums
        // returned from RNG.
        private int randNumForReel_1;
        private int randNumForReel_2;
        private int randNumForReel_3;

        // spin noise
        //SoundPlayer spinNoise = new SoundPlayer(@"D:\GitHub\Slot_Machine_Game\Slot_Machine_Game\Resources\reel_spin.mp3");
        // jackpot noise
        SoundPlayer jackpotNoise = new SoundPlayer(@"D:\GitHub\Slot_Machine_Game\Slot_Machine_Game\Resources\jackpot.wav");
        // win noise
        SoundPlayer winNoise = new SoundPlayer(@"D:\GitHub\Slot_Machine_Game\Slot_Machine_Game\Resources\slot_win.wav");
        // lose noise
        SoundPlayer loseNoise = new SoundPlayer(@"D:\GitHub\Slot_Machine_Game\Slot_Machine_Game\Resources\lose.wav");

        // Constructor.
        public frmSlotMachine()
        {
            InitializeComponent();
        }

        // Load event method to show the balance that the player entered in the welcome form.
        //   button is hidden until bet is > 1.
        private void frmSlotMachine_Load(object sender, EventArgs e)
        {

            txtBalance.Text = totalScore.ToString();
            txtPlayerName.Text = name;
            txtPlayerName.Enabled = false;
            //txtBalance.Enabled = false;
        }

        // Click event handler method for the + button. Increments the current bet.
        // Bet must be 1-3. Spin button is disabled until a non 0 bet is placed.
        private void btnIncreaseBet_Click(object sender, EventArgs e)
        {
            currentBet++;
            if(currentBet>totalScore)
            {
                btnDecreaseBet.Visible = true;
                MessageBox.Show("You don't have enough coins for that bet...", "Error");
                btnIncreaseBet.Visible = false;
                btnSpin.Focus();
                currentBet--;
            }
            else
            {
                if(currentBet <= 3)
                {
                    btnDecreaseBet.Visible = true;
                    txtBet.Text = currentBet.ToString();
                    if(currentBet==3)
                    {
                        btnIncreaseBet.Visible = false;
                    }
                }
                else if (currentBet == 3)
                {
                    btnIncreaseBet.Visible = false;
                }
                if (currentBet != 0)
                {
                    btnSpin.Enabled = true;
                }
            }
        }

        // Click event handler method for the - button. Decrements the current bet.
        // The bet has to be greater than 1 to work.
        private void btnDecreaseBet_Click(object sender, EventArgs e)
        {
            if (currentBet > 1)
            {
                btnIncreaseBet.Visible = true;
                currentBet--;
                txtBet.Text = currentBet.ToString();
                if (currentBet == 1)
                {
                    btnDecreaseBet.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Can't decrease any further...","Error");
            }
        }

        // Click event handler method for the spin button. Uses the spin method.
        // Go and get the calculation of the winnings from calculate reels method.
        // Check for jackpot. Add winnings to score. Display score in text box.
        // Check for 0. If neither then player won. Add winnings to total.
        // Display Score and winnings in the text boxes.
        // Let user play until they have 0 coins.
        private void btnSpin_Click(object sender, EventArgs e)
        {
            //spinNoise.Play();
            if (currentBet <= totalScore)
            {

                btnSpin.BackColor = Color.SteelBlue;
                spin();

                winnings = calculateReelCombos();

                txtWinnings.Text = winnings.ToString();

                // Show form Display Winnings for winnings.
                // pass in the winnings.
                if (winnings > 0)
                {
                    frmDisplayWinnings frmRef = new frmDisplayWinnings(txtWinnings.Text);
                    frmRef.Show();
                    totalScore += winnings;
                    txtBalance.Text = totalScore.ToString();
                }
                else if (winnings == 0)
                {
                    frmDisplayWinnings frmRef = new frmDisplayWinnings(txtWinnings.Text);
                    frmRef.Show();
                    totalScore -= currentBet;
                    txtBalance.Text = totalScore.ToString();
                    if (totalScore <=0 )
                    {
                        frmRef.Hide();
                    }
                }

                if (totalScore <= 0)
                {

                    youFailed();

                    Form frmDisplayWinnings = new Forms.frmDisplayFinalWinnings();
                    frmDisplayWinnings.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("You don't have the coins for that bet...", "Error");
            }


            
        }

        //  Helper method to display a long messagebox about failure.
        private void youFailed()
        {
            loseNoise.Play();
            MessageBox.Show("Give up, just quit, because in this life, " +
                "you can’t win. Yeah, you can try, but in the end you’re just " +
                "gonna lose, big time, because the world is run by the Man. The " +
                "Man, oh, you don’t know the Man? He’s everywhere. In the White " +
                "House… down the hall… Ms. Mullins, she’s the Man. And the Man " +
                "ruined the ozone, he’s burning down the Amazon, and he kidnapped " +
                "Shamu and put her in a chlorine tank! And there used to be a way " +
                "to stick it to the Man. It was called rock ‘n roll, but guess what, " +
                "oh no, the Man ruined that, too, with a little thing called MTV! So " +
                "don’t waste your time trying to make anything cool or pure or awesome " +
                "’cause the Man is just gonna call you a fat washed up loser and crush " +
                "your soul. So do yourselves a favor and just GIVE UP!", "Out Of Coins");
        }


        // Click event handler method to exit slot machine form
        // and go to display winnings form. player object's score is total score.
        private void btnCashOut_Click(object sender, EventArgs e)
        {
            GlobalsClass.playerObject.setScore(totalScore);
            Form frmDisplayWinnings = new Forms.frmDisplayFinalWinnings();
            frmDisplayWinnings.Show();
            this.Hide();
        }

        // This method uses an object of the stopwatch class to set a timer
        // to spin for 3 seconds. Goes and gets a random num
        // using RNG and displays that image from the image list to the
        // picture boxes on the form.
        private void spin()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            while (timer.Elapsed < TimeSpan.FromSeconds(3))
            {
                randNumForReel_1 = GlobalsClass.rngObject.getRandomNum();
                randNumForReel_2 = GlobalsClass.rngObject.getRandomNum();
                randNumForReel_3 = GlobalsClass.rngObject.getRandomNum();

                pbSlotReel1.Image = imgListForReels.Images[randNumForReel_1];
                pbSlotReel1.Refresh();
                pbSlotReel2.Image = imgListForReels.Images[randNumForReel_2];
                pbSlotReel2.Refresh();
                pbSlotReel3.Image = imgListForReels.Images[randNumForReel_3];
                pbSlotReel3.Refresh();

                // not much time between so it'll flash.
                Task.Delay(120).Wait();
            }
            timer.Stop();
        }

        // Method to calculate combos. Populate an array with the proper picture from
        // the pic list. Count how many of each pic. Ex: If the random pic is a 7 then
        // count a 7 which is at index 0. If the second pic is a 7 then count another.
        // Check for 3 of the same pics. After the pics are checked, return the value
        // of the pic * the amount bet.
        private int calculateReelCombos()
        {
            int[] spinResult = new int[5];
            spinResult[randNumForReel_1]++;
            spinResult[randNumForReel_2]++;
            spinResult[randNumForReel_3]++;

            // winning combos
            // 3 pics match
            // case 1: 777
            if (spinResult[0] == 3)
            {
                jackpotNoise.Play();
                return 100 * currentBet;
            }
            // case 2: banana, banana, banana
            else if (spinResult[1] == 3)
            {
                winNoise.Play();
                return 50 * currentBet;
            }
            // case 3: apple, apple, apple
            else if (spinResult[2] == 3)
            {
                winNoise.Play();
                return 25 * currentBet;

            }
            // case 4: orange, orange, orange
            else if (spinResult[3] == 3)
            {
                winNoise.Play();
                return 10 * currentBet;
            }
            // case 5: cherry, cherry, cherry
            else if (spinResult[4] == 3)
            {
                winNoise.Play();
                return 5 * currentBet;
            }
            // 2 pics match
            // case 6: banana, banana
            else if (spinResult[1] == 2)
            {
                winNoise.Play();
                switch (currentBet)
                {
                    case 2: return 5;
                    case 3: return 6;
                    default: return 4;
                }   
            }
            // case 7: apple, apple
            else if (spinResult[2] == 2)
            {
                winNoise.Play();
                switch (currentBet)
                {
                    case 2: return 4;
                    case 3: return 5;
                    default: return 3;
                }
            }
            // case 8: orange, orange
            else if (spinResult[3] == 2)
            {
                winNoise.Play();
                switch (currentBet)
                {
                    case 2: return 3;
                    case 3: return 4;
                    default: return 2;
                }
            }
            // case 9: cherry, cherry
            else if (spinResult[4] == 2)
            {
                winNoise.Play();
                switch (currentBet)
                {
                    case 2: return 2;
                    case 3: return 3;
                    default: return 1;
                }
            }
            // no matches
            // case 10: you lose
            else
            {
                loseNoise.Play();
                return 0;
            }
        }



    }
}
