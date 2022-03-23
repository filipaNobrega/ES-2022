namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = ReadInt("Enter the value of N : ");

            var array = new int[size];

            Console.WriteLine($"Enter {size} integers:");

            for (var i = 1; i <= size;)
            {
                Console.Write("{0} => ", i);

                int value;
                if (int.TryParse(Console.ReadLine(), out value))
                {
                    array[i - 1] = value;
                    i++;
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer:");
                }
            }

            Console.WriteLine("Min                : {0}", array.Min());
            Console.WriteLine("3 max values       : {0}", string.Join(", ", array.OrderByDescending(i => i).Take(3)));
            Console.WriteLine("Average            : {0}", array.Sum() / size);

            int count = array.Count(i => i > 10);
            Console.WriteLine("# bigger than 10   : {0}", count);
            Console.WriteLine("% bigger than 10   : {0}", count * 100 / size);
            Console.WriteLine("Av. bigger than 10 : {0}", count > 0 ? array.Where(i => i > 10).Sum() / count : "-");

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
