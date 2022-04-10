using System;

namespace CurrencyCalculator.LastVersion
{
    public class CurrencyValue : ISubject
    {
        public event UpdateEventHandler OnUpdate;
        private double _value = 0;

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
                Notify(currencyType);
            }
        }

        public void Notify(object data)
        {
            if (OnUpdate == null) return;
            OnUpdate(this, data);
        }
    }
}