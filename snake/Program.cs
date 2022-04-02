using System;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point(1, 3, Char.Parse("*"));
            p1.Draw();


            Point p2 = new Point(4,5, Char.Parse("&"));
            p2.Draw();

            Console.ReadLine();

        }
    }
}
