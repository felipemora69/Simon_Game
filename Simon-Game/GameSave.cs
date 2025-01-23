using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Simon_Game
{
    internal class GameSave
    {
        public static class SaveGameData
        {
            public static string filePath = "saves.txt";

            // Method to save user data to a text file
            public static void SaveToFile(string UserName, int Score)
            {
                try
                {
                   

                    // If file doesn't exist, just create and add the entry
                    if (!File.Exists(filePath))
                    {
                        using (StreamWriter writer = new StreamWriter(filePath, true)) 
                        {
                            writer.WriteLine($"{UserName},{Score}");
                        }
                        return;
                    }

                    // Reading all lines from list and checking if the user exists
                    List<string> lines = File.ReadAllLines(filePath).ToList();
                    bool userExists = false;

                    for (int i = 0; i < lines.Count; i++)
                    {
                        var data = lines[i].Split(',');

                        if (data[0] == UserName)
                        {
                            // checking for user is found. if found and userhighscore is greater than current score 
                            // it will not update the score
                            int Highscore = int.Parse(data[1]);
                            if (Highscore > Score)
                            {
                                lines[i] = $"{UserName},{Highscore}";
                                userExists = true;

                            }
                            // else it will update
                            else
                            {
                                lines[i] = $"{UserName},{Score}";
                                userExists = true;
                                break;
                            }
                            
                        }
                    }

                    if (!userExists)
                    {
                        // Adding new entry for new user
                        lines.Add($"{UserName},{Score}");
                    }

                    
                    File.WriteAllLines(filePath, lines);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // getting highScore based on usernames
            public static int LoadHighScore(string UserName)
            {
                try
                {
                    

                    if (!File.Exists(filePath)) return 0; 

                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            
                            var data = line.Split(',');
                            if (data[0] == UserName && int.TryParse(data[1], out int score))
                            {
                                return score;  
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return 0;  
            }

        
            // Method to retrieve all users and their scores
            public static List<(string UserName, int Score)> GetAllUsers()
              {
                 List<(string UserName, int Score)> users = new List<(string UserName, int Score)>();

                  try
                    {
         
                        if (File.Exists(filePath))
                        {
                        foreach (var line in File.ReadAllLines(filePath)) 
                            {
                                var data = line.Split(',');

                                if (data.Length == 2 && int.TryParse(data[1], out int score))
                                {
                                    users.Add((data[0], score)); 
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while retrieving users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // returning the list from the file for display
                    return users;
               
                }
        }
    }
}

