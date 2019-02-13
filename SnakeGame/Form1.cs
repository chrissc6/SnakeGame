using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{

    public partial class Form1 : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();

        public Form1()
        {
            InitializeComponent();

            new Settings();

            GameTime.Interval = 1000 / Settings.Speed;
            GameTime.Tick += UpdateScreen;
            GameTime.Start();

            StartGame();
        }

        private void StartGame()
        {
            labelGO.Visible = false;

            new Settings();

            Snake.Clear();
            Circle head = new Circle {X = 10, Y = 5};
            Snake.Add(head);

            labelScore.Text = Settings.Score.ToString();

            GenerateFood();
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            if(Settings.GameOver)
            {
                if (Input.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                if(Input.KeyPressed(Keys.Right) && Settings.Ddirection != Direction.Left)
                {
                    Settings.Ddirection = Direction.Right;
                    MovePlayer();
                }
                else if (Input.KeyPressed(Keys.Left) && Settings.Ddirection != Direction.Right)
                {
                    Settings.Ddirection = Direction.Left;
                    MovePlayer();
                }
                else if (Input.KeyPressed(Keys.Up) && Settings.Ddirection != Direction.Down)
                {
                    Settings.Ddirection = Direction.Up;
                    MovePlayer();
                }
                else if (Input.KeyPressed(Keys.Down) && Settings.Ddirection != Direction.Up)
                {
                    Settings.Ddirection = Direction.Down;
                    MovePlayer();
                }
                MovePlayer();

            }
            myPB1.Invalidate();
        }

        private void MovePlayer()
        {
            for (int i = Snake.Count -1; i >= 0; i--)
            {
                if(i == 0)
                {
                    switch (Settings.Ddirection)
                    {
                        case Direction.Up:
                            Snake[i].Y--;
                            break;
                        case Direction.Down:
                            Snake[i].Y++;
                            break;
                        case Direction.Left:
                            Snake[i].X--;
                            break;
                        case Direction.Right:
                            Snake[i].X++;
                            break;
                        default:
                            break;
                    }

                    int MaxX = myPB1.Size.Width / Settings.Width;
                    int MaxY = myPB1.Size.Height / Settings.Height;

                    if(Snake[i].X < 0 || Snake[i].Y < 0 || Snake[i].X >= MaxX || Snake[i].Y >= MaxY)
                    {
                        Die();
                    }

                    for (int a = 1; a < Snake.Count; a++)
                    {
                        if (Snake[i].X == Snake[a].X && Snake[i].Y == Snake[a].Y)
                        {
                            Die();
                        }
                    }

                    if(Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {
                        Eat();
                    }
                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }

        private void Eat()
        {
            Circle circle = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };

            Settings.Score += Settings.Points;
            labelScore.Text = Settings.Score.ToString();

            GenerateFood();

            Snake.Add(circle);
        }

        private void Die()
        {
            Settings.GameOver = true;
        }

        private void GenerateFood()
        {
            int MaxX = myPB1.Size.Width / Settings.Width;
            int MaxY = myPB1.Size.Height / Settings.Height;

            Random rng = new Random();
            food = new Circle();
            food.X = rng.Next(0, MaxX);
            food.Y = rng.Next(0, MaxY);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void myPB1_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            myPB1.BackColor = Color.SlateGray;
            

            if(Settings.GameOver != true)
            {
                

                for (int i = 0; i < Snake.Count; i++)
                {
                    Brush snakeColor;

                    if (i == 0)
                    {
                        snakeColor = Brushes.Black;
                    }
                    else
                    {
                        snakeColor = Brushes.Red;
                    }

                    canvas.FillEllipse(snakeColor,
                        new Rectangle(Snake[i].X * Settings.Width,
                            Snake[i].Y * Settings.Height,
                            Settings.Width, Settings.Height));

                    canvas.FillEllipse(Brushes.DarkSalmon,
                        new Rectangle(food.X * Settings.Width,
                            food.Y * Settings.Height,
                            Settings.Width, Settings.Height));

                }
            }
            else
            {
                string GameOver = $"Game over. \nYour Score: {Settings.Score} \nPress ENTER to play again";

                labelGO.Text = GameOver;
                labelGO.Visible = true;
            }
        }

        private void labelGO_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void Form1_KeyUp_1(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }
    }
}
