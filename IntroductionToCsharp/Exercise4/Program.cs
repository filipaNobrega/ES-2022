namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = ReadInt("Enter the value of x : ");
            int y = ReadInt("Enter the value of y : ");

            Console.WriteLine("The greatest common divisor (GCD) between {0} and {1} is {2}", x, y, GreatestCommonDivisor(x, y));

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }

        private static int GreatestCommonDivisor(int x, int y)
        {
            if (x < y)
            {
                return GreatestCommonDivisor(y, x);
            }
            return y == 0 ? x : GreatestCommonDivisor(y, x % y);
        }

        private static int ReadInt(string prompt)
        {
            // The int.Parse() method will throw an exception which crashes the program whereas
            // the int.TryParse() will return a boolean indicating whether the operation succeeded

            Console.Write(prompt);

            int value;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Wrong value. Please, try again.");
            }

            return value;
        }
    }
}