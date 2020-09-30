using System;

namespace LineComp
{
        class Program 
        { 
        static void Main(string[] args)
        { 
            Console.WriteLine("Welcome to Line Comparision Computation Using Class");
            Points p1 = new Points(4,5,7,9);
            double l1 = p1.calLength();
            Console.WriteLine(l1);
            Points p2 = new Points(8, 8, 10, 10);
            double l2 = p2.calLength();
            Console.WriteLine(l2);
            int k = l1.CompareTo(l2);

            if (k.Equals(0))
            {
                Console.WriteLine("Lines are equal");
            }

            else
            {
                if (k==1)
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
