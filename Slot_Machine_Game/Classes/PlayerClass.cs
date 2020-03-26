/*
 * Andrew Larkins
 * Eric Friedman
 * CIS-3309
 * Slot Machine Game
 * 03/20/20
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Player class used to store inName
// and money inBalance of the player.

namespace Slot_Machine_Game.Classes
{
    class PlayerClass
    {
        // class attributes.
        private string name;
        private int balance = 0;
        private int finalScore = 0;
        

        // Constructor sets name and balance.
        public void playerClass(string inName, int inBalance)
        {
            name = inName;
            balance = inBalance;
        }

        // Getter methods.
        public string getName()
        {
            return name;
        }
        public int getBalance()
        {
            return balance;
        }
        public int getScore()
        {
            return finalScore;
        }
        // Setter method.
        public void setScore(int finalScore)
        {
            this.finalScore = finalScore;
        }

        // Return totalScore.
        public int calculateScore()
        {
            return finalScore = finalScore - balance;
        }

        // Reset to be used after game is over.
        public void reset()
        {
            name = "";
            balance = 0;
            finalScore = 0;
            
        }

        public string playerToString()
        {
            string strFinalScore = name + ": " + finalScore;
            return strFinalScore;
        }


    }
}
