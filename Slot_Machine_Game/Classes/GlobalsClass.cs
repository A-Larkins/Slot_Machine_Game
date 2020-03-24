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

// Instantiate objects of different types that
// the forms can use.

namespace Slot_Machine_Game.Classes
{
    class GlobalsClass
    {
        public static InternalGameLogicClass internalGameLogicObject =
            new InternalGameLogicClass();
        public static LeaderboardClass leaderboardObject =
            new LeaderboardClass();
        public static PlayerClass playerObject =
            new PlayerClass();
        public static RandomNumberGeneratorClass rngObject =
            new RandomNumberGeneratorClass();
    }
}
