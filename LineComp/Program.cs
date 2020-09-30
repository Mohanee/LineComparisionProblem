using System;

namespace LineComp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparision Computation Program"+"\n"+"We'll be calculating length between 2 points");
            int x1 = 3, x2 = 6;
            int y1 = 4, y2 = 9;
            double length = 0;

            length = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            Console.WriteLine("Length of the line is " + length);
        }
    }
}
