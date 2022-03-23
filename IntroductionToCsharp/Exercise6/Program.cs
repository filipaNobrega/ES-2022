namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibonacciNumbers = new List<int> { 1, 1 };
            while (fibonacciNumbers.Count < 20)
            {
                fibonacciNumbers.Add(fibonacciNumbers[^1] + fibonacciNumbers[^2]);
            }
            foreach (var item in fibonacciNumbers)
            {
                Console.WriteLine(item);
            }

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
