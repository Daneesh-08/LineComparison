using System;

namespace LineCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program on Master Branch !!");
            Console.WriteLine("\n");
            Console.WriteLine("Enter the initial x & y co-ordinate of the line : ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the final x & y co-ordinate of the line :");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double diffX = x2 - x1;
            double diffY = y2 - y1;
            double lengthOfLine = Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2));
            Console.WriteLine("\n");
            Console.WriteLine("Length of the line : " + lengthOfLine);
        }
    }
}
