using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;


            if (a == 17 && b == 4)
            Console.WriteLine($"\n{a}/{b} is {quotient} remainder {remainder}");



            Console.WriteLine("\n\nwhat is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());
            double area = AreaOfCircle(radius);
            Console.WriteLine($"\nThe area of a circle with radius of {radius} is {area}");
     
        }

        public static double AreaOfCircle(double radius)
        {
            double pi = Math.PI;

            return pi * radius * radius;

        }
    }
}
