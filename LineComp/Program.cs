using System;

namespace LineComp
{
     public class Points
        {
            int x1, y1, x2, y2;
        double length;

           public Points(int x1, int y1, int x2, int y2)
            {
                this.x1 = x1;
                this.y1 = y1;
                this.x2 = x2;
                this.y2 = y2;
            }

            public double calLength()
            {
                length = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
                return length;
            }

        }


        class Program 
        { 
        static void Main(string[] args)
        { 
            Console.WriteLine("Welcome to Line Comparision Computation Using Class");
            //Console.WriteLine("Enter the coordinates of pt1 and pt2");
            Points p1 = new Points(4,5,7,9);
            double l1 = p1.calLength();
            Console.WriteLine(l1);
            Points p2 = new Points(8, 8, 10, 10);
            double l2 = p2.calLength();
            Console.WriteLine(l2);
            int k = l1.CompareTo(l2);

            Console.WriteLine("check1");
            if (k.Equals(0))
            {
                Console.WriteLine("Lines are equal");
            }

            else
            {
                if (k>1)
                {
                    Console.WriteLine("Line 1 is greater than Line 2");
                }

                if(k<1)
                {
                    Console.WriteLine("Line 1 is shorter than Line 2");
                }
            }


        }
    }
}
