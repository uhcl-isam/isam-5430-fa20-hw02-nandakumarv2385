using System;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// The Main app will prompt the user for the last number of the Fibonacci numbers.
    /// Then, the app will write a sequence of numbers in a Fibonacci sequence up to the last number.
    /// Fibonacci numbers are the numbers in the following integer sequence, called the Fibonacci sequence, 
    /// and characterized by the fact that every number after the first two is the sum of the two preceding ones.
    /// The first two numbers are 0 and 1 so the numbers will be 0 1 1 2 3 5 8 13 21 34 55 89...
    /// </summary>
    public class FibonacciNumbers
    {
        public static void Main()
        {
            Console.WriteLine("Enter the last number of Fibonacci Sequence of numbers.");
            int end = int.Parse(Console.ReadLine());
            int i, j, k;
            if (end <= 0)
            {
                Console.WriteLine("0");
            }
            else if (end == 1)
            {
                Console.WriteLine("0 1 1");
            }
            else
            {
                i = 0;
                Console.WriteLine(i);
                j = 1;
                Console.WriteLine(j);

                k = i + j;
                Console.WriteLine(k);
                while (k < end)
                {

                    i = k + j;
                    if (i <= end)
                        Console.WriteLine(i);

                    j = k;
                    k = i;

                }
            }
        }
    }
}