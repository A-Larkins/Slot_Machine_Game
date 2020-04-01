/*
 * Andrew Larkins
 * Eric Friedman
 * CIS-3309
 * Slot Machine Game
 * 03/20/20
 * updated 4/1/20
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// In combination of the player class, this class is used
// to store a leaderboard to show the Top 10 players of all time.
// Create text file, update text file. 

namespace Slot_Machine_Game.Classes
{
    class LeaderboardClass
    {
        // Class attributes
        // List of tuples so we can easily keep track of types: (string, int)
        private List<Tuple<string, int>> listOfLeaderboard = new List<Tuple<string, int>>();   
        private string playerData;
        private string leaderBoardFile = "leaderboard.txt";
        StreamReader readFromLeaderboard;
        StreamWriter writeToLeaderboard;
        

        // write to the leaderboard file
        public void writeToFile()
        {
            if (File.Exists(leaderBoardFile))
            {
                File.Delete(leaderBoardFile); // Delete if exists, we want to update.
            }

            try
            {
                using (writeToLeaderboard = new StreamWriter(leaderBoardFile, true))
                {
                    foreach (Tuple<string, int> inScore in listOfLeaderboard)
                    {
                        writeToLeaderboard.WriteLine(inScore);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Can't write to leaderboard...", "Error");
            }

        }

        // Read from the leaderboard file.
        public void readFromFile()
        {
            if (File.Exists(leaderBoardFile) == false)
            {
                using (readFromLeaderboard = new StreamReader(leaderBoardFile , true))
                {
                    while (!(readFromLeaderboard.EndOfStream)) // not EOF
                    {
                        playerData = readFromLeaderboard.ReadLine();
                        // what is looks like
                        string formattedList = "";
                        formattedList = playerData.TrimEnd(')');
                        formattedList = playerData.TrimStart('(');
                        formattedList.Trim();
                        // store in array
                        string[] inArr = formattedList.Split(',');
                        // name is index 0, score 1
                        string name = inArr[0];
                        int score = Convert.ToInt32(inArr[1]);

                        // fill tuple
                        Tuple<string, int> leaders = Tuple.Create<string, int>(name, score);
                        listOfLeaderboard.Add(leaders);
                    }
                }
            }
        }

        // Leaderboard gets updated after player chooses to cash out.
        public void update(string inScore)
        {
            string[] scoreArr = inScore.Split(':');
            string theName = scoreArr[0];
            int theScore = Convert.ToInt32(scoreArr[1]);
            Tuple<string, int> displayTup = Tuple.Create<string, int>(theName, theScore);
            // Add the display tupple
            listOfLeaderboard.Add(displayTup);
            readFromFile();
            listOfLeaderboard = listOfLeaderboard.OrderByDescending(y => y.Item2).ToList();
            // keep top 5
            while (listOfLeaderboard.Count >=6)
            {
                listOfLeaderboard.RemoveAt(5);
            }
            writeToFile();
        }


        // method to return a single string of name and score
        public string getDisplay()
        {
            string ret = "";
            string playerScore;
            foreach (Tuple<string, int> inScore in listOfLeaderboard)
            {
                playerScore = "Name: " + inScore.Item1 + " Score: " + inScore.Item2;
                ret += playerScore + "\n";
            }
            return ret;
        }


    }
}
