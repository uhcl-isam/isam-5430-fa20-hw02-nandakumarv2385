using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Create an app that lets you enter a bunch of integers until the
    /// end of line with a CTRL-Z. We will say that a "clump" of these numbers
    /// is a series of 2 or more adjacent elements of the same value. The app will
    /// simply print out the number that is the count of these clumps.
    /// </summary>
    public class CountClumps
    {
        public static void Main()
        {
            int a, b = 0, sum = 0;
            string input, n;
            int j = 0;
            
            input = Console.ReadLine();

            if (input == null)
            {
                Console.WriteLine("Ctrl has been pressed");
                sum = 0;
            }
            else
            {
                a = Convert.ToInt32(input);
                while (true)
                {
                    n = Console.ReadLine();
                    if (n == null)
                    {
                        Console.WriteLine("Ctrl has been pressed");

                        break;
                    }
                    else
                    {

                        j = Convert.ToInt32(n);

                        if (a == b)
                        {
                            if (j == 0)
                            {
                                sum++;
                                j++;
                            }
                        }
                        else
                        {

                            j = 0;

                        }
                        a = b;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
