using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon_Game
{

    // All of the display is done in this class
    public class DisplayManager
    {

        public static Form1 _form;

        // This function is used to display computer generated sequence
        public static async Task ShowSequence(List<Button> buttons, List<string> sequence , string PlayerName, Form1 form)
        {

            _form = form;
            _form.output_PlayerName.Text = PlayerName;
            await Task.Delay(1000);
            foreach (string color in sequence)
            {
                Button button;
                

                switch (color)
                {
                    case "green": // Green
                        button = buttons[0];
                        button.BackColor = Color.WhiteSmoke;
                        
                        await Task.Delay(500);
                        button.BackColor = Color.Green;

                        break;

                    case "blue": // Blue
                        button = buttons[1];

                        button.BackColor = Color.WhiteSmoke;
                        await Task.Delay(500);
                        button.BackColor = Color.Blue;

                        break;

                    case "red": // Red
                        button = buttons[2];
                        button.BackColor = Color.WhiteSmoke;
                        
                        await Task.Delay(500);
                        button.BackColor = Color.Red;

                        break;

                    case "yellow": // Yellow
                        button = buttons[3];
                        button.BackColor = Color.WhiteSmoke;
                        
                        await Task.Delay(500);
                        button.BackColor = Color.Yellow;
                        
                        break;

                    default:
                        throw new Exception("Unknown Color");
                }

                await Task.Delay(200);
            }

        }


        public static void ShowScore()
        {
            int score;
            int highScore;
            score = Scoremanager.GetScore();
            highScore = Scoremanager.GetHighScore();
            _form.lbl_Score.Text = "Current Score : " + score.ToString();
            _form.lbl_HighScore.Text = "Player HighScore : " + highScore.ToString();
        }

        public static void ShowAllUsersWithScores()
        {
            var users = GameSave.SaveGameData.GetAllUsers();
            users = users.OrderByDescending(u => u.Score).ToList();
            _form.user_1.Text = users[0].UserName + " : " + users[0].Score;
            _form.user_2.Text = users[1].UserName + " : " + users[1].Score;
            _form.user_3.Text = users[2].UserName + " : " + users[2].Score;
        }


    }
}
