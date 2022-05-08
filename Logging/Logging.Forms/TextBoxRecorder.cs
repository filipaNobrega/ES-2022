namespace Logging.Forms
{
    internal class TextBoxRecorder : IRecorder
    {
        private readonly TextBox _textBox;

        public TextBoxRecorder(TextBox textBox)
        {
            _textBox = textBox;
        }

        public void Record(string message)
        {
            if (string.IsNullOrEmpty(message)) return;
            _textBox.AppendText(message);
            _textBox.AppendText(Environment.NewLine);
        }
    }
}
