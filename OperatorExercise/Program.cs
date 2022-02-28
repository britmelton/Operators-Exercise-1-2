using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Class Exercise Instructions
            //In class Exercise 
            /* Create a simple program to write out the results of addition, subtraction, multiplication, division operations.
             * For division, create two integer variables called a and b. 
             * Create a third integer variable and named quotient (the result of a division) that stores the result of the division of a and b.
             * Create another integer variable named remainder that stores the remainder (using the % operator). 
             * Write out the results using Console.WriteLine or Console.Write
             * Write out the results in the following form: if a = 17 and b = 4, print the following:	
                17/4 is 4 remainder 1	*/
            #endregion


            Console.WriteLine("Enter first number:");
            var c = double.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter second number:");
            var d = double.Parse(Console.ReadLine());
           
            var sum = c + d;
            Console.WriteLine($"\nThe sum of {c}+{d} is {sum}");

            var diff = c - d;
            Console.WriteLine($"the difference of {c}-{d} is {diff}");

            var product = c * d;
            Console.WriteLine($"the product of {c}*{d} is {product}");

            Console.WriteLine("Enter a number: ");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second number: ");
            var b = double.Parse(Console.ReadLine());
            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine($"\n{a}/{b} is {quotient} remainder {remainder}");
        } 
    }
}   
