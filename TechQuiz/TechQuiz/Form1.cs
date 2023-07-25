using System.Diagnostics.Metrics;

namespace TechQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private readonly object lockObj = new object();
        int TimeRemaining = 5000;
        public void endGame()
        {
            label2.Text = "";
            label3.Text = "";
            label4.Text = "THANKS FOR PLAYING ALONG";
            Image image = Image.FromFile("..\\..\\..\\pics\\" + "GAMEOVER" + ".jpg");
            pictureBox1.Image = image;
            label1.Text = "PLAYER SCORE: " + player.getScore();
        }

        public void Aesthetics(string OptionA, string OptionB, string OptionC, string Question)
        {
            label4.Text = Question;
            label4.AutoSize = false;
            label4.Width = panel1.Width;
            label4.TextAlign = ContentAlignment.MiddleCenter;

            label1.Text = OptionA;
            label1.AutoSize = false;
            label1.Width = groupBox1.Width;
            label1.TextAlign = ContentAlignment.MiddleCenter;

            label2.Text = OptionB;
            label2.AutoSize = false;
            label2.Width = groupBox1.Width;
            label2.TextAlign = ContentAlignment.MiddleCenter;

            label3.Text = OptionC;
            label3.AutoSize = false;
            label3.Width = groupBox1.Width;
            label3.TextAlign = ContentAlignment.MiddleCenter;

        }

        GamePlay gamePlay = new GamePlay();
        Player player = new Player();
        int Score = 0;
        public void passOptions(string _OptionA, string _OptionB, string _OptionC, string Answer)
        {
            gamePlay.setOptionA(_OptionA);
            gamePlay.setOptionB(_OptionB);
            gamePlay.setOptionC(_OptionC);
            gamePlay.setGameAnswer(Answer);
        }
        public void ButtonReset()
        {
            btnA.BackColor = Color.Gray;
            btnB.BackColor = Color.Gray;
            btnC.BackColor = Color.Gray;
        }


        string[] game = File.ReadAllLines(@"GameFile.txt");
        int counter = 0;
        public void setupGame(string[] _game, int Counter)
        {
            //create a function that will filter each line into filename 

            string[] GameData = game[Counter].Split(",");

            string OptionA = "A - " + GameData[1];
            string OptionB = "B - " + GameData[2];
            string OptionC = "C - " + GameData[3];
            string OptionD = "QUESTION : " + GameData[4];


            passOptions(OptionA, OptionB, OptionC, GameData[0]);

            Aesthetics(OptionA, OptionB, OptionC, OptionD);


            Image image = Image.FromFile("..\\..\\..\\pics\\" + GameData[0] + ".jpg");
            pictureBox1.Image = image;
        }


        /*
                private void btnA_Click(object sender, EventArgs e)
                {
                    player.setAnswer(label1.Text);

                    string[] GameData = game[counter - 1].Split(",");

                    if (player.getAnswer().Contains(gamePlay.getAnswer()))
                    {
                        btnA.BackColor = Color.Green;
                        Score++;
                        player.setScore(Score);
                    }
                    else
                    {
                        btnA.BackColor = Color.Red;
                    }

                }
        */

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter == game.Length - 1)
            {
                timer1.Stop();
                endGame();
            }
            else
            {
                ButtonReset();
                timer1.Interval = TimeRemaining;
                setupGame(game, counter);
                counter++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            btnA.Tag = label1;
            btnB.Tag = label2;
            btnC.Tag = label3;
        }
        /*
                private void button2_Click(object sender, EventArgs e)
                {
                    player.setAnswer(label2.Text);

                    string[] GameData = game[counter - 1].Split(",");

                    if (player.getAnswer().Contains(gamePlay.getAnswer()))
                    {
                        btnB.BackColor = Color.Green;
                        Score++;
                        player.setScore(Score);
                    }
                    else
                    {
                        btnB.BackColor = Color.Red;

                    }

                }
        */
        private void StartTimer()
        {
            while (counter < game.Length - 1)
            {
                lock (lockObj)
                {
                    ButtonReset();
                    timer1.Interval = 5000;
                    setupGame(game, counter);
                    counter++;
                }
                Task.Delay(5000).Wait(); // Wait for 5 seconds before moving to the next set.
            }

            btnA.Click += HandleUserInput;
            btnB.Click += HandleUserInput;
            btnC.Click += HandleUserInput;

            // Game has ended when the loop finishes.
            endGame();
        }

        private void HandleUserInput(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            Label associatedLabel = clickedButton.Tag as Label;
            string userAnswer = associatedLabel.Text.Split(" - ")[1];


            lock (lockObj)
            {
                string[] GameData = game[counter - 1].Split(",");

                if (userAnswer.Contains(gamePlay.getAnswer()))
                {
                    Image image2 = Image.FromFile("..\\..\\..\\pics\\" + "correct" + ".jpg");
                    pictureBox2.Image = image2;
                    Score++;
                    player.setScore(Score);
                }
                else
                {
                    Image image2 = Image.FromFile("..\\..\\..\\pics\\" + "wrong" + ".jpg");
                    pictureBox2.Image = image2;
                }



                if (counter < game.Length - 1)
                {
                    ButtonReset();
                    setupGame(game, counter);
                    counter++;
                }
                else
                {
                    timer1.Stop();
                    endGame();
                }
            }
        }

        void resetTime()
        {
            timer1.Stop();
            timer1.Interval = 5000;
            timer1.Start();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            resetTime();
            HandleUserInput(sender, e);
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            resetTime();
            HandleUserInput(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resetTime();
            HandleUserInput(sender, e);
        }



        /*
                private void button3_Click(object sender, EventArgs e)
                {
                    player.setAnswer(label3.Text);

                    string[] GameData = game[counter - 1].Split(",");

                    if (player.getAnswer().Contains(gamePlay.getAnswer()))
                    {
                        btnC.BackColor = Color.Green;
                        Score++;
                        player.setScore(Score);
                    }
                    else
                    {
                        btnC.BackColor = Color.Red;
                    }

                }
        */
    }
}