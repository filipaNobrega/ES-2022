namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence : ");
            string text = Console.ReadLine();

            if ( text != null && text.Length < 60 )
            {
                Console.WriteLine("# characters        : {0}", text.Length);

                char[] delimiters = new char[] { ' ', '\r', '\n' };
                string[] words = text.Split(delimiters);
                Console.WriteLine("# words             : {0}", words.Length);

                Console.WriteLine("# Uppercase letters : {0}", text.Count(char.IsUpper));
                Console.WriteLine("# Lowercase letters : {0}", text.Count(char.IsLower));
                Console.WriteLine("# Digits            : {0}", text.Count(char.IsDigit));
            }

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
