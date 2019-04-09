using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***** This program can give the result of base ^ Exponent *****\n");
            Console.Write("Enter the value of the base:");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the value of the exponent:");
            int num2 = int.Parse(Console.ReadLine());

            int start = 3;
            double result = num1 * num1;

            while (start <= num2)
            {
                result = num1 * result;
                start++;
            }


            Console.WriteLine($"Result is - {result}");

            Console.ReadLine();
        }
    }
}
