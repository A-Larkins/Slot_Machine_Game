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


        private void frmWinLose_Load(object sender, EventArgs e)
        {

            if (txtDisplayWinnings.Text == "300")
            {
                lblWinnings.Text = "Jackpot, go crazy folks!";
            }
            if (txtDisplayWinnings.Text == "0")
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
