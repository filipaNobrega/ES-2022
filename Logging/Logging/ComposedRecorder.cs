using System.Collections.Generic;

namespace Logging
{
    public class ComposedRecorder : IRecorder
    {
        private readonly List<IRecorder> _recorders = new List<IRecorder>();

        public void Append ( IRecorder recorder )
        {
            if (_recorders.Contains(recorder)) return;
            _recorders.Add( recorder );
        }

        public void Remove ( IRecorder recorder )
        {
            if (!_recorders.Contains(recorder)) return;
            _recorders.Remove(recorder);
        }

        public void Record(string message)
        {
            foreach (var recorder in _recorders)
            {
                recorder.Record(message);
            }
        }
    }
}
