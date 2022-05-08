namespace Logging
{
    public class CounterDecorator : RecorderDecorator
    {
        private int _counter = 0;
        public CounterDecorator(IRecorder component) : base(component)
        {
        }

        public override void Record(string message)
        {
            Component.Record($"{++_counter} : {message}");
        }
    }
}
