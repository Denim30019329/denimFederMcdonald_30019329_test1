using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("****** This program will give the sum total of 5 prices ******\n");

            //declared variable
            double total = 0;

            //for loop to ask for price 5 times
            for (int i = 1;i <= 5; i++)
            {
                Console.Write($"Enter the price of item {i}: ");
                total += double.Parse(Console.ReadLine());//add and save total to total variable
            }

            //display the total
            Console.WriteLine($"The total of the items is ${total}");

            Console.ReadLine();
        }
    }
}
