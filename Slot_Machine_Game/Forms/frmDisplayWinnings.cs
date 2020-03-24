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
    }
}
