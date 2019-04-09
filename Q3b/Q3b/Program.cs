using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3b
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("****** Can you solve the following algebraic expression: 2(x - 3) + x = 12 ******\n");

            int x = 6;//Store the answer here

            Console.Write("Enter your guess at the value of x : ");
            int guess = int.Parse(Console.ReadLine());//store the users guess

            //use if statement to display if it was correct
            if (guess == x)
            {
                Console.WriteLine("\nWell done, that is correct!");
            }
            else
            {
                Console.WriteLine("\nSorry that is incorrect.");
            }

            Console.ReadLine();
        }
    }
}
