using System.Diagnostics;

namespace Logging
{
    public class EventLogRecorder : IRecorder
    {
        private readonly EventLog _eventLog = new EventLog();

        public EventLogRecorder(string applicationName, string logName = "Application")
        {
            if ( ! EventLog.Exists(applicationName))
            {
                EventLog.CreateEventSource(applicationName, logName);
            }
            _eventLog.Source = applicationName;
            _eventLog.Log = logName;            
        }

        public void Record(string message)
        {
            if (string.IsNullOrEmpty(message)) return;
            _eventLog.WriteEntry(message);
        }
    }
}
