namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Right-click the project and select Properties.
            // In the Debug tab, choose Open debug launch profile UI and change Command-line arguments.
            if (args.Length < 1)
            {
                Console.WriteLine("Command-line Usage: Exercise5 <filename>");
                return;
            }

            try
            {
                var lines = File.ReadAllLines(args[0]);
                foreach (var line in lines)
                {
                    foreach (var character in line)
                    {
                        if (char.IsWhiteSpace(character))
                        {
                            continue;
                        }

                        Console.Write(char.ToUpper(character));
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
