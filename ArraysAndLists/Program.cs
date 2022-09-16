using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //DONE:

            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // Create an int Array and populate numbers 1-10 - DONE

            //DONE 
                /* Create two Lists of type int. - DONE
                 * Name one List "evens"- DONE
                 * Name the other List "odds"- DONE
                 */

            var evens = new List<int>();
            var odds = new List<int>();

            //DONE 
                /* Using either a foreach or for loop,
                 * nest an if statement to check to see
                 *  if a number is even or odd.
                 * Then add those numbers to either the evens List
                 * or the odds List
                 */

            foreach(int i in numbers)
            {                
                if (i % 2 == 0)
                {
                    evens.Add(i);
                }
                else
                {
                    odds.Add(i);
                }
            }

            //DONE
                /* Now using foeach or for loops,
                 * display each List of even and odd numbers
                 *
                 * Try to be creative in your display
                 */

            Console.Write("Here are all the numbers in the list: ");
            foreach (int i in numbers) Console.Write($"{i} ");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Here are all the odd numbers in the list: ");
            foreach (int i in odds) Console.Write($"{i} ");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Here are all the even numbers in the list: ");
            foreach (int i in evens) Console.Write($"{i} ");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
