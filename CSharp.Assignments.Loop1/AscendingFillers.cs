using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Create an application that reads a bunch of non-negative integers line-by-line until a negative integer or the end-of-line (CTRL-Z) has reached. The app will print out the sum of all the fillers that will make all the values entered so far will appear in increasing order, where each value is larger than the previous number. That is each filler is added to each input, such that the numbers will all appear in increasing order (e.g. 1, 2, 3, 10). The only exception is when the element is 0, where the current number and the subsequent numbers will restart from zero.
    /// </summary>
    /// <param name="a"></param>
    /// <remarks>In essence, this app will calculate the sum of all these values added to the original numbers such that our projected numbers will appear in increasing order.</remarks>
    /// <returns>The sum of all the fillers</returns>
    public class AscendingFillers
    {
        public static void Main()
        {
            // Complete your loop codes here.
            bool negative = false;
            int count = 0;
            List<int> number = new List<int>();
            List<int> extra = new List<int>();
            while (negative == false)
            {
                string input = Console.ReadLine();
                int n;
                Int32.TryParse(input, out n);
                if (n < 0)
                {
                    negative = true;
                }
                else
                {
                    if ((number.Count) == 0)
                    {
                        number.Insert(count, n);
                        count = count + 1;
                    }
                    else
                    {
                        if (n == 0)
                        {
                            number.Insert(count, n);
                            count = count + 1;
                        }
                        else if (n == number.ElementAt(count - 1))
                        {
                            n = n + 1;
                            extra.Add(1);
                            number.Insert(count, n);
                            count = count + 1;
                        }
                        else if (n < number.ElementAt(count - 1))
                        {
                            int a;
                            int b;
                            a = n;
                            a = number.ElementAt(count - 1) + 1;
                            b = a - n;
                            extra.Add(b);
                            number.Insert(count, a);
                            count = count + 1;
                        }
                        else
                        {
                            number.Insert(count, n);
                            count = count + 1;
                        }
                    }
                }
            }
            foreach (int a in number)
                Console.WriteLine(a);
            int sum = extra.AsQueryable().Sum();
            Console.WriteLine("\nSum:");
            Console.WriteLine(sum);
        }
    }
}