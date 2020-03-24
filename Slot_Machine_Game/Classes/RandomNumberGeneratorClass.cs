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

// Generates a random number.

namespace Slot_Machine_Game.Classes
{
    class RandomNumberGeneratorClass
    {
        // Class attributes.
        private Random randomNumber;
        private int returnRandomNumber;
        // Represents random fruit pic to use.
        // There are 5 values.
        private int[] arrRepOfPics = new int[] { 0,1,2,3,4 };

        // COnstructor.
        public RandomNumberGeneratorClass ()
        {
            randomNumber = new Random();
        }

        // Method to return a random num from the array.
        public int returnRandomNum ()
        {
            return returnRandomNumber = randomNumber.Next(0, arrRepOfPics.Length);
        }

    }
}
