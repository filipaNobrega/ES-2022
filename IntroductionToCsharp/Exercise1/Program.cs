namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = ReadInt("Enter the value of x : ");
            int y = ReadInt("Enter the value of y : ");

            if (x > y)
            {
                Console.WriteLine($"{x} is greater than {y}");
            }
            else if (x < y)
            {
                Console.WriteLine($"{x} is less  than {y}");
            }
            else
            {
                Console.WriteLine($"{x} is equal to {y}");
            }

            Console.Write("Press any key to exit...");
            Console.ReadKey();
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
