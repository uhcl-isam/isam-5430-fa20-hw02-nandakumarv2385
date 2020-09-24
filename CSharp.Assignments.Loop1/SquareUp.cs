using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignments.Loop1
{
    public class SquareUp
    {
        /// <summary>
        /// Create an app that inputs one number, n >= 0. The app will print out n*n integers with the following pattern; for n=3, the app will print out 0, 0, 1,    0, 2, 1,    3, 2, 1 on separate lines (spaces added to show the 3 groups).
        /// </summary>
        public static void Main()
        {
            // Write your codes here
            // Write your codes here
            int i, j, n;
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = n; j >= 1; j--)
                {
                    if (i >= j)
                        Console.Write(j + " ");
                    else
                        Console.Write("0 ");
                }
                Console.WriteLine();
            }
        }
    }

}
