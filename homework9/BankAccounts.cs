namespace homework9
{
    
    public class DepositAccount : CardAccount
    {
        public DepositAccount(string accountNumber, decimal balance, string cardNumber, string expiryDate)
            : base(accountNumber, balance, cardNumber, expiryDate)
        {
        }
    }

    
    public class CreditAccount : CardAccount
    {
        public CreditAccount(string accountNumber, decimal balance, string cardNumber, string expiryDate)
            : base(accountNumber, balance, cardNumber, expiryDate)
        {
        }
    }

    
    public class CurrentAccount : Account
    {
        private decimal overdraftLimit;

        
        public decimal OverdraftLimit
        {
            get { return overdraftLimit; }
            set
            {
                if (value >= 0)
                    overdraftLimit = value;
                else
                    overdraftLimit = 0;
            }
        }

        public CurrentAccount(string accountNumber, decimal balance, decimal overdraftLimit)
            : base(accountNumber, balance)
        {
            OverdraftLimit = overdraftLimit;
        }
    }
}