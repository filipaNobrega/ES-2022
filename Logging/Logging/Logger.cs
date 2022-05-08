using System;

namespace Logging
{
    public class Logger : ILogger
    {
        #region Singleton - usage: Logger.Instance

        private Logger() {}
        public static Logger Instance { get; } = new Logger();

        #endregion

        public IRecorder Recorder { get; set; }

        public void Log(string message)
        {
            if (Recorder == null) return;
            Recorder.Record( message );
        }
    }
}
