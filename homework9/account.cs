using System;

namespace homework9
{
    public class Account
    {
        private string accountNumber;
        private decimal balance;

        
        public string AccountNumber
        {
            get { return accountNumber; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length == 22)
                    accountNumber = value;
                else
                    accountNumber = "GE00000000000000000000"; 
            }
        }

        
        public decimal Balance
        {
            get { return balance; }
            set
            {
                if (value >= 0)
                    balance = value;
                else
                    balance = 0;
            }
        }

        public Account(string accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }
    }
}
