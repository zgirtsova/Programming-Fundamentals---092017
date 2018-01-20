using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Debugging_Exercise___Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            int tetrisSize = int.Parse(Console.ReadLine());

            while (true)
            {
                string currentDirection = Console.ReadLine();
                switch (currentDirection)
                {
                    case "up": Up(tetrisSize); break;
                    case "right": Right(tetrisSize); break;                                               break;
                    case "down": Down(tetrisSize); break;
                    case "left": Left(tetrisSize); break;
                    case "exit": return;
                        
                }
            }
        }

        static void Left(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', n) + new string('*', n));
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', 2 * n));
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', n) + new string('*', n));
            }
        }
        static void Right(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', n) + new string('.', n));
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', 2 * n));
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', n) + new string('.', n));
            }
        }
        static void Up(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', n) + new string('*', n) + new string('.', n));
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', n * 3));
            }
        }
        static void Down(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', n * 3));
            }            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', n) + new string('*', n) + new string('.', n));
            }
        }
    
    }
}
