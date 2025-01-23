using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Simon_Game.StateManager;

namespace Simon_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Simon class
        public static class Simon
        {
            public static List<string> ComputerSequence = new List<string>();
            public static List<string> UserInputSequence = new List<string>();
            private static List<Button> Buttons;
            private static string PlayerName;
            private static int Level = 1;
            private static int temp = 0;
            public static Form1 _form;


            // This function is triggered on clicking start button
            public static void startGame(List<Button> btns, string name, Form1 form)
            {
                Buttons = btns;
                PlayerName = name;
                _form = form;
                ComputerSequence.Clear();
                Scoremanager.SetHighScore(GameSave.SaveGameData.LoadHighScore(PlayerName));
                Task.Delay(1500);
                generateComputerSequence();
            }

            // This function generates computer randomized colour sequence for user to choose accordingly
            public async static void generateComputerSequence()
            {

                Random rand = new Random();
                string[] colors = { "green", "blue", "red", "yellow" };
                int index = rand.Next(colors.Length);

                for (int i = 0; i < 1; i++)
                {
                    ComputerSequence.Add(colors[index]);
                }

                UserInputSequence.Clear();
                await DisplayManager.ShowSequence(Buttons, ComputerSequence, PlayerName, _form);
                DisplayManager.ShowScore();
                DisplayManager.ShowAllUsersWithScores();

            }


            // this function lets the user continue to next level via stateManager
            public static void nextLevel()
            {
                Level = Level + 1;
                generateComputerSequence();
            }


            // this function is used to get input of user and store it in a list
            public async static void GetInput(string color)
            {
                if (temp < ComputerSequence.Count)
                {
                    UserInputSequence.Add(color);

                    // Here we are constantly checking is the user sequence matches computer sequence. 
                    // If not matching we end the game.
                    if (UserInputSequence[temp] != ComputerSequence[temp])
                    {
                        GameSave.SaveGameData.SaveToFile(PlayerStats.UserName, PlayerStats.Score);
                        Simon.endGame();
                        temp = 0;
                        UserInputSequence.Clear();
                        ComputerSequence.Clear();
                        await Task.Delay(5200);
                        generateComputerSequence();
                    }

                    temp++;

                    // Here if the user sequence length reaches computer sequence length we send it to compare if its a win or loose!
                    if (temp == ComputerSequence.Count)
                    {
                        StateManager.GameState.ComparingMethod(ComputerSequence, UserInputSequence, PlayerName);
                        temp = 0;

                    }
                }
            }

            // Message to show at the game over
            public async static void endGame()
            {
                Scoremanager.ResetScore();
                DisplayManager.ShowScore();
                Form namePopUp = new Form
                {
                    Width = 400,
                    Height = 150,
                    Text = "Game Over"
                };
                Label nameLabel = new Label
                {
                    Left = 10,
                    Top = 10,
                    Width = 360,
                    Text = "You clicked more colours! You LOSE!",
                    AutoSize = true,
                    BackColor = Color.LightGray
                };
                namePopUp.Controls.Add(nameLabel);
                Button btnOK = new Button
                {
                    Text = "Restart",
                    Left = 150,
                    Top = 70,
                    DialogResult = DialogResult.OK
                };
                namePopUp.Controls.Add(btnOK);
                namePopUp.ShowDialog();

                await ReadyFunc(_form);
            }

        }

        // Start game button events.
        private async void btn_Start_Click_1(object sender, EventArgs e)
        {

            //form popup for name
            Form namePopUp = new Form();
            namePopUp.Width = 300;
            namePopUp.Height = 150;
            namePopUp.Text = "Player Name";
            namePopUp.StartPosition = FormStartPosition.CenterScreen;
            namePopUp.FormBorderStyle = FormBorderStyle.FixedDialog;
            namePopUp.MinimizeBox = false;
            namePopUp.MaximizeBox = false;

            //form label
            Label nameLabel = new Label();
            nameLabel.Left = 10;
            nameLabel.Top = 10;
            nameLabel.Width = 260;
            nameLabel.Text = "Welcome to Simon! Enter your Name: ";
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.LightGray;
            namePopUp.Controls.Add(nameLabel);

            //form textbox
            TextBox nameTextbox = new TextBox();
            nameTextbox.Left = 10;
            nameTextbox.Top = 40;
            nameTextbox.Width = 260;
            nameTextbox.BackColor = Color.LightGray;
            nameTextbox.AutoSize = true;
            namePopUp.Controls.Add(nameTextbox);

            //ok button
            Button btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.Left = 150;
            btnOK.Top = 70;
            btnOK.DialogResult = DialogResult.OK;
            namePopUp.Controls.Add(btnOK);

            //cancel button
            Button btnCancel = new Button();
            btnCancel.Text = "Cancel";
            btnCancel.Left = 60;
            btnCancel.Top = 70;
            btnCancel.DialogResult = DialogResult.Cancel;
            namePopUp.Controls.Add(btnCancel);

            namePopUp.AcceptButton = btnOK;
            namePopUp.CancelButton = btnCancel;

            // here we check if the name box is empty , if empty we loop it agin
            // if name present we pass it to simon class to start the game
            if (namePopUp.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(nameTextbox.Text))
            {
                string playerName = nameTextbox.Text;

                List<Button> buttons = new List<Button> { btn_Green, btn_Blue, btn_Red, btn_Yellow };
                await ReadyFunc(this);
                lbl_turn.Visible = true;
                Simon.startGame(buttons, playerName, this);
            }

            else
            {
                MessageBox.Show("You must enter your name to start the game.");
            }
        }


        // New Game button click events.
        private async void btn_NewGame_Click(object sender, EventArgs e)
        {
            //form popup for name
            Form namePopUp = new Form();
            namePopUp.Width = 300;
            namePopUp.Height = 180;
            namePopUp.Text = "Player Name";
            namePopUp.StartPosition = FormStartPosition.CenterScreen;
            namePopUp.FormBorderStyle = FormBorderStyle.FixedDialog;
            namePopUp.MinimizeBox = false;
            namePopUp.MaximizeBox = false;

            //form label
            Label nameLabel = new Label();
            nameLabel.Left = 10;
            nameLabel.Top = 10;
            nameLabel.Width = 260;
            nameLabel.Text = "Welcome to Simon! Enter your Name: ";
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.LightGray;
            namePopUp.Controls.Add(nameLabel);

            //form textbox
            TextBox nameTextbox = new TextBox();
            nameTextbox.Left = 10;
            nameTextbox.Top = 40;
            nameTextbox.Width = 260;
            nameTextbox.BackColor = Color.LightGray;
            nameTextbox.AutoSize = true;
            namePopUp.Controls.Add(nameTextbox);

            //ok button
            Button btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.Left = 150;
            btnOK.Top = 70;
            btnOK.DialogResult = DialogResult.OK;
            namePopUp.Controls.Add(btnOK);

            //cancel button
            Button btnCancel = new Button();
            btnCancel.Text = "Cancel";
            btnCancel.Left = 60;
            btnCancel.Top = 70;
            btnCancel.DialogResult = DialogResult.Cancel;
            namePopUp.Controls.Add(btnCancel);

            namePopUp.AcceptButton = btnOK;
            namePopUp.CancelButton = btnCancel;

            if (namePopUp.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(nameTextbox.Text))
            {
                string playerName = nameTextbox.Text;

                List<Button> buttons = new List<Button> { btn_Green, btn_Blue, btn_Red, btn_Yellow };
                Simon.ComputerSequence.Clear();
                Simon.UserInputSequence.Clear();
                Scoremanager.ResetScore();
                await ReadyFunc(this);
                Simon.startGame(buttons, playerName, this);
            }

            else
            {
                MessageBox.Show("You must enter your name to start the game.");
            }
        }

        // function for displaying ready comments
        public static async Task ReadyFunc(Form1 form)
        {
            form.lbl_ready.Text = "Ready";
            await Task.Delay(1000);
            form.lbl_ready.Text = "3";
            await Task.Delay(1000);
            form.lbl_ready.Text = "2";
            await Task.Delay(1000);
            form.lbl_ready.Text = "1";
            await Task.Delay(1000);
            form.lbl_ready.Text = "Go!";
            await Task.Delay(1000);
            form.lbl_ready.Text = "";
        }


        // user input capture and storing buttons
        private async void btn_Green_Click_1(object sender, EventArgs e)
        {
            btn_Green.BackColor = Color.WhiteSmoke;
            Simon.GetInput("green");
            await Task.Delay(150);
            btn_Green.BackColor = Color.Green;
        }

        private async void btn_Red_Click_1(object sender, EventArgs e)
        {
            btn_Red.BackColor = Color.WhiteSmoke;
            Simon.GetInput("red");
            await Task.Delay(150);
            btn_Red.BackColor = Color.Red;
        }

        private async void btn_Yellow_Click_1(object sender, EventArgs e)
        {
            btn_Yellow.BackColor = Color.WhiteSmoke;
            Simon.GetInput("yellow");
            await Task.Delay(150);
            btn_Yellow.BackColor = Color.Yellow;
        }

        private async void btn_Blue_Click_1(object sender, EventArgs e)
        {
            btn_Blue.BackColor = Color.WhiteSmoke;
            Simon.GetInput("blue");
            await Task.Delay(150);
            btn_Blue.BackColor = Color.Blue;
        }

        // function to show the title screen
        private async void Form1_Load(object sender, EventArgs e)
        {
            lbl_title.Visible = true;
            lbl_credits.Visible = true;

            await Task.Delay(1400);
            lbl_title.Text = "SIMON GAME";
            lbl_title.Refresh();
            await Task.Delay(4000);
            lbl_title.Text = "";
            lbl_title.Refresh();
            await Task.Delay(600);

            foreach (Control control in Controls)
            {
                control.Visible = true;
                lbl_credits.Visible = false;
            }
            lbl_turn.Visible = false;
        }
    }
}
