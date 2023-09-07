using System;
using System.Linq;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter string expression:");
                string expr = Console.ReadLine();

                // validate string for bracket matching
                if (Brackets.AreBracketsBalanced(expr))
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }

                Console.WriteLine();
            }
        }
    }
}
