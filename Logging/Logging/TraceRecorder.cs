using System.Diagnostics;

namespace Logging
{
    public class TraceRecorder : IRecorder
    {
        public void Record(string message)
        {
            Trace.WriteLine(message);
        }
    }
}
