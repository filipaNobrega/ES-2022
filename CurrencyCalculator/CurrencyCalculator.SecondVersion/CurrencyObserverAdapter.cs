using System.Windows.Forms;

namespace CurrencyCalculator.SecondVersion
{
    // Using the Adapter pattern to convert currency and update specific TextBox ("adaptee")
    public class CurrencyObserverAdapter : IObserver
    {
        private readonly TextBox _textBox;
        private readonly CurrencyType _currencyType;

        public CurrencyObserverAdapter(TextBox textBox, CurrencyType currencyType)
        {
            _textBox = textBox;
            _currencyType = currencyType;
        }

        public void Update(ISubject subject, object data)
        {
            CurrencyValue currencyValue = subject as CurrencyValue;
            if(currencyValue == null) return;

            if(_currencyType == (CurrencyType) data) return;

            _textBox.Text = string.Format("{0}", currencyValue[_currencyType]);
        }
    }
}