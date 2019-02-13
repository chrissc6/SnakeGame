using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public enum Direction {Up, Down, Left, Right};

    class Settings
    {
        //static so we dont have to create a new settings object

        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static int Points { get; set; }
        public static bool GameOver { get; set; }

        public static Direction Ddirection { get; set; }

        public Settings()
        {
            Width = 15;
            Height = 15;
            Speed = 10;
            Score = 0;
            Points = 1;
            GameOver = false;
            Ddirection = Direction.Down;
        }
    }
}
