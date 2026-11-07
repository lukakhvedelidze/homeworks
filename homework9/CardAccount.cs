namespace homework9
{
    public class CardAccount : Account
    {
        private string cardNumber;
        private string expiryDate;

        
        public string CardNumber
        {
            get { return cardNumber; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length <= 16)
                    cardNumber = value;
                else
                    cardNumber = "0000000000000000";
            }
        }

        public string ExpiryDate
        {
            get { return expiryDate; }
            set { expiryDate = value; }
        }

        public CardAccount(string accountNumber, decimal balance, string cardNumber, string expiryDate)
            : base(accountNumber, balance)
        {
            CardNumber = cardNumber;
            ExpiryDate = expiryDate;
        }
    }
}