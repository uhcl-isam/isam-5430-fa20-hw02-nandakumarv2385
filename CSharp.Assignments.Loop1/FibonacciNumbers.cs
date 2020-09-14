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
        public static int FibonacciNumber(int n)
        {
            int p = 0;
            int q = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = p;
                p = q;
                q = temp + q;
            }
            return p;
        }

        static void Main()
        {
            Console.WriteLine("\n\n Recursion : Find the Fibonacci numbers for a n numbers of series :");
            Console.WriteLine("-----------------------------------------------------------------------");

            Console.Write(" Input number of terms for the Fibonacci series : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n The Fibonacci series of {0} terms is : ", n1);
            for (int i = 0; i < n1; i++)
            {
                Console.Write("{0} ", FibonacciNumber(i));
            }
            Console.ReadKey();
        }
    }
}