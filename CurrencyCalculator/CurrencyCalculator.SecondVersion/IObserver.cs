namespace CurrencyCalculator.SecondVersion
{
    public interface IObserver
    {
        void Update(ISubject subject, object data);
    }
}