using System;

namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console Calculator\r");
            Console.WriteLine("----------------------------------------------------------------------\n");

            Console.WriteLine("Enter a number, and then press Enter:");
            int left;
            while (!int.TryParse(Console.ReadLine(), out left)) Console.WriteLine("Please enter a valid integer:");

            Console.WriteLine("Enter another number, and then press Enter:");
            int right;
            while (!int.TryParse(Console.ReadLine(), out right)) Console.WriteLine("Please enter a valid integer:");

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\t1 - Add");
            Console.WriteLine("\t2 - Subtract");
            Console.WriteLine("\t3 - Multiply");
            Console.WriteLine("\t4 - Divide");
            Console.Write("What is your option?");

            int option;
            while (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Wrong value. Please, try again.");
            }

            switch (option)
            {
                case 1:
                    Console.WriteLine("The result of {0} + {1} is {2}", left, right, left + right);
                    break;
                case 2:
                    Console.WriteLine("The result of {0} - {1} is {2}", left, right, left - right);
                    break;
                case 3:
                    Console.WriteLine("The result of {0} * {1} is {2}", left, right, left * right);
                    break;
                case 4:
                    while (right == 0)
                    {
                        Console.WriteLine("Enter a non-zero divisor: ");
                        if (int.TryParse(Console.ReadLine(), out var value))
                        {
                            right = value;
                        }
                    }
                    Console.WriteLine("The result of {0} / {1} is {2}", left, right, left / right);
                    break;
            }

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}