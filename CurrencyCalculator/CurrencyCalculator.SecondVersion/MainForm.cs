namespace CurrencyCalculator.SecondVersion
{
    public partial class MainForm : Form
    {
        private CurrencyValue _currencyValue;

        public MainForm()
        {
            _currencyValue = new CurrencyValue();
            InitializeComponent();
        }

        private void OnEuroTextBoxChanged(object sender, EventArgs e)
        {
            if (!EuroTextBox.ContainsFocus) return;

            if (double.TryParse(EuroTextBox.Text, out var euros))
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

            if (double.TryParse(DollarTextBox.Text, out var dollars))
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
            if (!PoundTextBox.ContainsFocus) return;

            if (double.TryParse(PoundTextBox.Text, out var pounds))
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
            _currencyValue.Attach(new CurrencyObserverAdapter(EuroTextBox, CurrencyType.Euros));
            _currencyValue.Attach(new CurrencyObserverAdapter(DollarTextBox, CurrencyType.Dollars));
            _currencyValue.Attach(new CurrencyObserverAdapter(PoundTextBox, CurrencyType.Pounds));
        }
    }
}