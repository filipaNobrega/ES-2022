namespace Exercise1
{
    public class BankAccount
    {
        private static int _accountNumberSeed = 1234567890;
        private readonly List<Transaction> _allTransactions = new List<Transaction>();
        public BankAccount(string name, double initialBalance)
        {
            Number = _accountNumberSeed.ToString();
            _accountNumberSeed++;
            Owner = name;

            MakeDeposit(initialBalance, DateTime.UtcNow, "Initial balance");
        }

        public string Number { get; }
        public string Owner { get; }

        public double Balance
        {
            get
            {
                double balance = 0;
                foreach (var transaction in _allTransactions)
                {
                    balance += transaction.Amount;
                }
                return balance;
            }
        }

        public void MakeWithdrawal(double amount, DateTime date, string note)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive!");
            }
            if (amount > Balance)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), amount, "Amount of withdrawal exceeds balance!");
            }

            Transaction withdrawal = new Transaction(-amount, date, note);
            _allTransactions.Add(withdrawal);
        }

        public void MakeDeposit(double amount, DateTime date, string note)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive!");
            }

            Transaction deposit = new Transaction(amount, date, note);
            _allTransactions.Add(deposit);
        }

        public void GenerateBankStatement()
        {
            double balance = 0;
            using StreamWriter writer = new(new FileStream($"EXT_{Number}.csv", FileMode.Create, FileAccess.Write));
            writer.WriteLine("Data Mov, Descritivo, Montante, Saldo");
            foreach (var transaction in _allTransactions)
            {
                balance += transaction.Amount;
                writer.WriteLine($"{transaction.Date:dd-MM-yyyy},{transaction.Note},{transaction.Amount},{balance}");
            }
        }
    }
}