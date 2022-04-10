using System;
using System.Windows.Forms;

namespace CurrencyCalculator.LastVersion
{
    public partial class MainForm : Form
    {
        private CurrencyValue _currencyValue;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OnEuroTextBoxChanged(object sender, EventArgs e)
        {
            if (!EuroTextBox.ContainsFocus) return;

            if (double.TryParse(EuroTextBox.Text, out double euros))
            {
                _currencyValue[CurrencyType.Euros] = euros;

                EuroErrorProvider.SetError(EuroTextBox, string.Empty);
            }
            else
            {
                EuroErrorProvider.SetError(EuroTextBox, "Invalid double!");
            }
        }

        private void OnDollarTextBoxChanged(object sender, EventArgs e)
        {
            if (!DollarTextBox.ContainsFocus) return;

            if (double.TryParse(DollarTextBox.Text, out double dollars))
            {
                _currencyValue[CurrencyType.Dollars] = dollars;

                DollarErrorProvider.SetError(DollarTextBox, string.Empty);
            }
            else
            {
                DollarErrorProvider.SetError(DollarTextBox, "Invalid double!");
            }
        }

        private void OnPoundTextBoxChanged(object sender, EventArgs e)
        {
            if( ! PoundTextBox.ContainsFocus ) return;

            if (double.TryParse(PoundTextBox.Text, out double pounds))
            {
                _currencyValue[CurrencyType.Pounds] = pounds;

                PoundErrorProvider.SetError(PoundTextBox, string.Empty);
            }
            else
            {
                PoundErrorProvider.SetError(PoundTextBox, "Invalid double!");
            }
        }

        private void CurrencyCalculatorForm_Load(object sender, EventArgs e)
        {
            _currencyValue = new CurrencyValue();

            // Event handler memory leaks https://www.spicelogic.com/Blog/net-event-handler-memory-leak-16 (nice article)

            // A delegate can be initialized with a lambda expression
            _currencyValue.OnUpdate += (subject, data) =>
            {
                if(CurrencyType.Euros == (CurrencyType) data) return;
                EuroTextBox.Text = string.Format("{0}", _currencyValue[CurrencyType.Euros]);
            };

            // A delegate can be initialized with inline code, called an "anonymous method".
            // An anonymous method is a "method" without a name.
            _currencyValue.OnUpdate += delegate (ISubject subject, object data)
            {
                if (CurrencyType.Dollars == (CurrencyType)data) return;
                DollarTextBox.Text = string.Format("{0}", _currencyValue[CurrencyType.Dollars]);
            };

            // A method that is defined elsewhere in the code
            _currencyValue.OnUpdate += OnUpdatePoundText;
        }

        private void OnUpdatePoundText(ISubject subject, object data)
        {
            if (CurrencyType.Pounds == (CurrencyType)data) return;
            PoundTextBox.Text = string.Format("{0}", _currencyValue[CurrencyType.Pounds]);
        }
    }
}
