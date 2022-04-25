namespace CurrencyCalculator.FirstVersion
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnEuroTextBoxChanged(object sender, EventArgs e)
        {
            if (!EuroTextBox.ContainsFocus) return;

            if (double.TryParse(EuroTextBox.Text, out var euros))
            {
                DollarTextBox.Text = string.Format("{0}", euros * 1.10020);
                PoundTextBox.Text = string.Format("{0}", euros * 0.83380);

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
                EuroTextBox.Text = string.Format("{0}", dollars * 0.90893);
                PoundTextBox.Text = string.Format("{0}", dollars * 0.75786);
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
                EuroTextBox.Text = string.Format("{0}", pounds * 1.19933);
                DollarTextBox.Text = string.Format("{0}", pounds * 1.31950);

                PoundErrorProvider.SetError(PoundTextBox, string.Empty);
            }
            else
            {
                PoundErrorProvider.SetError(PoundTextBox, "Invalid double!");
            }
        }
    }
}