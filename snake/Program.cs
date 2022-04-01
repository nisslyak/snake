using System;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point();
            p1.x = 1;
            p1.y = 3;
            p1.sym = char.Parse("*");
            p1.Draw();


            Point p2 = new Point();
            p2.x = 4;
            p2.y = 5;
            p2.sym=char.Parse("@");
            p2.Draw();

            Console.ReadLine();

        }
    }
}
