namespace CurrencyCalculator.LastVersion
{
    public delegate void UpdateEventHandler(ISubject subject, object data);
    public interface ISubject
    {
        // Using an event handler to define an observer method removes the need for explicit extra class(es)
        event UpdateEventHandler OnUpdate;
        void Notify(object data);
    }
}