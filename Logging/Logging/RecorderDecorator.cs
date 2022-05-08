namespace Logging
{
    public abstract class RecorderDecorator : IRecorder
    {
        protected IRecorder Component { get; }

        public RecorderDecorator( IRecorder component )
        {
            Component = component;
        }

        public abstract void Record(string message);
    }
}
