using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rectangle_Position
{
    class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int CalcArea() { return Width * Height;}
        public int Bottom { get { return Top + Height;} }
        public int Right { get { return Left + Width; } }
        public bool isInside(Rectangle r)
        {
            return (r.Left <= Left) && (r.Right >= Right) && (r.Top <= Top) && (r.Bottom >= Bottom);
        }
    }
    class Program
    {
        static void Main(string[] args) 
        {
            Rectangle r1 = ReadRectangle();
            Rectangle r2 = ReadRectangle();
            Console.WriteLine(r1.isInside(r2) ? "Inside" : "Not inside");
        }
        static Rectangle ReadRectangle()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Rectangle rect = new Rectangle();
            rect.Left = input[0];
            rect.Top = input[1];
            rect.Width = input[2];
            rect.Height = input[3];
            return rect;
        }
    }
    
}
