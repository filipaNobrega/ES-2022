namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Enter a sentence : ");
                string text = Console.ReadLine();

                if(!string.IsNullOrEmpty(text))
                {
                    Console.WriteLine(text.ToUpper());
                }

                Console.WriteLine("Press the 0 key to exit, or press any other key to continue...");
            } while (Console.ReadKey().Key != 0);
        }
    }
}
