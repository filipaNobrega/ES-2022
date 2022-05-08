using System;

namespace Logging
{
    public class DateDecorator : RecorderDecorator
    {
        public DateDecorator(IRecorder component) : base(component)
        {
        }

        public override void Record(string message)
        {
            string dateinfo = DateTime.Now.ToString("yyyy-MM-dd") + " " + DateTime.Now.ToLongTimeString();
            Component.Record($"{dateinfo} : {message}");
        }
    }
}
