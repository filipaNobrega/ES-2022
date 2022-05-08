namespace Logging
{
    public interface ILogger
    {
        IRecorder Recorder { get; set; }
        void Log(string message);
    }
}
