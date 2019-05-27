using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.SetWindowSize(Constants.ScreenLength, Constants.ScreenHeight);
            await GameLoop();

        }

        static async Task GameLoop()
        {
            List<BlueEnemy> Enemies = new List<BlueEnemy>
            {
                new BlueEnemy(1, 1),
                new BlueEnemy(17, 1),
                new BlueEnemy(17 + 16, 1),
                new BlueEnemy(17 + 16 + 16, 1),
                new BlueEnemy(1, 12),
                new BlueEnemy(17, 12),
                new BlueEnemy(17 + 16, 12),
                new BlueEnemy(17 + 16 + 16, 30),
                new BlueEnemy(50, 40),
                new BlueEnemy(10, 30)

            };
            bool MoveRight = true;
            bool HitButtom = false;
            while (true)
            {
                Console.Clear();

                if (Enemies.Any(e => e.HitWall()))
                {
                    foreach (var blueEnemy in Enemies)
                    {
                        blueEnemy.MoveDown();
                    }

                    MoveRight = !MoveRight;
                }

                if (HitButtom)
                {
                    System.Windows.Forms.MessageBox.Show("Game Over");
                }

                foreach (var blueEnemy in Enemies)
                {
                    blueEnemy.Move(MoveRight);
                    blueEnemy.DrawEnemy();
                }

                await Task.Delay(TimeSpan.FromSeconds(0.001));
            }
        }

    }

    public class BlueEnemy
    {
        public short X { get; set; }
        public short Y { get; set; }

        public short Length { get; } = 15;
        public short Height { get; } = 5;

        public void DrawEnemy()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write("###############");
            Console.SetCursorPosition(X, Y + 1);
            Console.Write("### ### ### ###");
            Console.SetCursorPosition(X, Y + 2);
            Console.Write("#### ##### ####");
            Console.SetCursorPosition(X, Y + 3);
            Console.Write("### ### ### ###");
            Console.SetCursorPosition(X, Y + 4);
            Console.Write("###############");
        }

        public void Move(bool moveRight)
        {
            if (moveRight)
            {
                X = (short) (X + 1);
            }
            else
            {
                X = (short) (X - 1);
            }
        }

        public bool HitButtom()
        {
            if (Y + Height >= Constants.ScreenHeight)
            {
                return true;
            }

            return false;
        }

        public bool HitWall()
        {
            if (X <= 0)
            {
                return true;
            }

            if (X + Length >= Constants.ScreenLength)
            {
                return true;
            }

            return false;
        }

        public void MoveDown()
        {
            Y = (short) (Y + 1);
        }

        public BlueEnemy(short x, short y)
        {
            X = x;
            Y = y;
        }

    }

    public static class Constants
    {
        public const short ScreenLength = 200;
        public const short ScreenHeight = 50;
    }
}