namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = new Stack<int>();

            Console.WriteLine("Enter 10 integers:");
            for (var i = 1; i <= 10;)
            {
                Console.Write("{0} => ", i);

                int value;
                if (int.TryParse(Console.ReadLine(), out value))
                {
                    values.Push(value);
                    i++;
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer:");
                }
            }

            Console.WriteLine("Values:");
            for (var i = 1; values.Count > 0; i++)
            {
                Console.WriteLine("{0} => {1}", i, values.Pop());
            }

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
