using System;
using System.Collections.Generic;

namespace CurrencyCalculator.SecondVersion
{
    public class CurrencyValue : ISubject
    {
        private double _value = 0;
        private readonly List<IObserver> _observers = new List<IObserver>();

        public double this[CurrencyType currencyType]
        {
            get
            {
                switch (currencyType)
                {
                    case CurrencyType.Euros:
                        return _value;
                    case CurrencyType.Dollars:
                        return _value * 1.10020;
                    case CurrencyType.Pounds:
                        return _value * 0.83380;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(currencyType), currencyType, null);
                }
            }
            set
            {
                switch (currencyType)
                {
                    case CurrencyType.Euros:
                        _value = value;
                        break;
                    case CurrencyType.Dollars:
                        _value = value * 0.90893;
                        break;
                    case CurrencyType.Pounds:
                        _value = value * 1.19933;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(currencyType), currencyType, null);
                }
                Notify( currencyType );
            }
        }

        public void Attach(IObserver observer)
        {
            if (_observers.Contains(observer)) return;
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            if (!_observers.Contains(observer)) return;
            _observers.Remove(observer);
        }

        public void Notify(object data)
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(this, data);
            }
        }
    }
}