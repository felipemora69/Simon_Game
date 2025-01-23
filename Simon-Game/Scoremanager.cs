using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon_Game
{
    internal class Scoremanager
    {
        private static int currentScore = 0;
        private static int highScore = 0;


        // Methods for manipulating score
        public static void UpdateScore()
        {
            currentScore += 2;
            if (currentScore > highScore)
            {
                highScore = currentScore;
            }
        }
        public static void SetHighScore(int score) 
        {
            highScore = score;
        
        }
        public static int GetScore() {

            return currentScore;
        }
        public static int GetHighScore()
        {
            return highScore;
        }
        public static void ResetScore()
        {
            currentScore = 0;   
        }

        
    }
}
