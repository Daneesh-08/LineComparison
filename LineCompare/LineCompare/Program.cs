﻿using System;

namespace LineCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the initial x & y co-ordinate of 1st line : ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the final x & y co-ordinate of 1st line :");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double diffX1 = x2 - x1;
            double diffY1 = y2 - y1;
            double length1 = Math.Sqrt(Math.Pow(diffX1, 2) + Math.Pow(diffY1, 2));
            Console.WriteLine("Enter the initial x & y co-ordinate of 2nd line : ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            double y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the final x & y co-ordinate of 2nd line :");
            double x4 = Convert.ToDouble(Console.ReadLine());
            double y4 = Convert.ToDouble(Console.ReadLine());
            double diffX2 = x4 - x3;
            double diffY2 = y4 - y3;
            double length2 = Math.Sqrt(Math.Pow(diffX2, 2) + Math.Pow(diffY2, 2));
            if (length1.Equals(length2))
                Console.WriteLine("Lengths of both lines ARE EQUAL");
            else
                Console.WriteLine("Lengths of both lines ARE NOT EQUAL");
        }
    }
}
