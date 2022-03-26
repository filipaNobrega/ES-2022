namespace Exercise1
{
    public class Transaction
    {
        public double Amount { get; }
        public DateTime Date { get; }
        public string Note { get; }

        public Transaction(double amount, DateTime date, string note)
        {
            Amount = amount;
            Date = date;
            Note = note;
        }
    }
}