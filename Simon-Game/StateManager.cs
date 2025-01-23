using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Simon_Game
{
    internal class StateManager
    {

        // All of the player stats
        public static class PlayerStats
        {

            public static string UserName = "";
            public static int Score { get; set; }
            public static int NumberOfWins { get; set; }
            public static int NumberOfLosses { get; set; }
        }

        public static class GameState
        {
            //GameState class will handle comparing wins and losses
            private static bool state;
            private static int NumberOfWins = 0;
            private static int NumberOfLosses = 0;

            //ComparingMethod will compare both lists and save to state variable
            public static void ComparingMethod(List<string> random, List<string> user, string name)
            {
                PlayerStats.UserName = name;
                state = random.SequenceEqual(user);
                UpdateWinsLosses();

            }
            //GetState will return the state which is boolean (true or false) based on the comparission in ComparingMethod.
            public static bool GetState()
            {
                return state;
            }

            //UpdateWinsLosses will update the number of losses and wins
            public static void UpdateWinsLosses()
            {
                if (state)
                {
                    int score;
                    NumberOfWins++;
                    Scoremanager.UpdateScore();
                    DisplayManager.ShowScore();
                    Form1.Simon.nextLevel();
                    score = Scoremanager.GetScore();
                    PlayerStats.Score = score;
                }
                else
                {
                    NumberOfLosses++;
                }
            }

            //return NumberOfWins to be used later
            public static int GetNumberOfWins()
            {
                return NumberOfWins;
            }

            //return NumberOfLosses to be used later
            public static int GetNumberOfLosses()
            {
                return NumberOfLosses;
            }

        }
    }
}
