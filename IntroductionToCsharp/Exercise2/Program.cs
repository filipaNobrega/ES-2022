namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;

            Console.WriteLine("Enter 10 integers:");

            int i = 1;
            while (i <= 10)
            {
                int value;
                if (int.TryParse(Console.ReadLine(), out value))
                {
                    sum += value;
                    i++;
                }
                else
                {
                    Console.WriteLine("Wrong value. Please, try again.");
                }
            }

            Console.WriteLine("Total: {0}", sum);
            Console.WriteLine("Average: {0}", sum / 10.0);

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
