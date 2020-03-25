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


// This class shows a description of the slot
// machine and a table showing the payout
// combinations. Only user action is to
// click on the play to load the slot machine.

namespace Slot_Machine_Game.Forms
{
    public partial class frmExplainRulesPage : Form
    {
        // Constructor.
        public frmExplainRulesPage()
        {
            InitializeComponent();
        }

        // Button to go to main form after the user
        // reads rules and winnings.
        private void btnPlay_Click(object sender, EventArgs e)
        {
            Form frmSlot = new Forms.frmSlotMachine();
            frmSlot.Show();
            this.Hide();
        }

    }
}
