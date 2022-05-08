namespace Logging
{
    public class ConsoleRecorder : IRecorder
    {
        public void Record(string message)
        {
            Console.WriteLine(message);
        }
    }
}
