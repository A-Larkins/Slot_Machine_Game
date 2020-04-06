/*
 * Andrew Larkins
 * Eric Friedman
 * CIS-3309
 * Slot Machine Game
 * 03/20/20
 */ 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Slot_Machine_Game.Classes;


// Welcome form to get user's name and starting money balance.
// Name must be validated and balance must be greater than 0.

namespace Slot_Machine_Game
{
    public partial class frmWelcomePage : Form
    {
        // Class attributes to get name and balance.
        private string playerInputName;
        private int playerInputBalance = 0;

        // intro music
        SoundPlayer jackpotSound = new SoundPlayer(@"D:\GitHub\Slot_Machine_Game\Slot_Machine_Game\Resources\intro_music.wav");

        // Constructor.
        public frmWelcomePage()
        {
            InitializeComponent();

        }

        // Event handler for when the OK button is clicked. Check if name is valid,
        // check if money is > 0, update player object,
        // load and go to next form: rules form.
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                // try to get player name and balance
                playerInputName = txtName.Text;
                playerInputBalance = Convert.ToInt32(txtBalance.Text);

                if (playerInputName == "")
                {
                    MessageBox.Show("Enter a valid name.", "Error");
                    txtName.Focus();
                }
                else if (playerInputBalance < 1)
                {
                    MessageBox.Show("You must have money to play.", "Error");
                    txtBalance.Text = "";
                    txtName.Focus();
                }
                else // else we're good to go.
                {
                    GlobalsClass.playerObject.playerClass(txtName.Text,
                        Int32.Parse(txtBalance.Text));
                    Form frmExplainRulesPage = new Forms.frmExplainRulesPage();
                    frmExplainRulesPage.Show();
                    this.Hide();
                }
            }
            catch // catch error and reset
            {
                MessageBox.Show("Enter valid name and balance that is a whole number and" +
                    " greater than 0.", "Error");
                txtName.Text = "";
                txtBalance.Text = "";
                txtName.Focus();
            }
        }

        // Load event to play intro music.
        private void frmWelcomePage_Load(object sender, EventArgs e)
        {
            //jackpotSound.Play();
        }
    }
}
