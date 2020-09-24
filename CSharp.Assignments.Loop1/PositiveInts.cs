using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments.Loop1
{
    public class PositiveInts
    {
        /// <summary>
        /// First prompt for the value of n, then Write all the positive integers up to the integer n on separate lines. [Demonstration]
        /// </summary>
        public static void Main()
        {
            Console.Error.WriteLine("Enter the value of n");
            // write your codes here.
            int a = Convert.ToInt32(Console.ReadLine());
            int i;
            if (a > 0)
            {
                for (i = 1; i <= a; i++)
                {
                    Console.WriteLine(i);
                }
            }
         }
    }
}
