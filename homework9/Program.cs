using System;

namespace homework9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CurrentAccount current = new CurrentAccount("GE29TB7100000123456789", 1500.50m, 500m);

            
            DepositAccount deposit = new DepositAccount("GE12TB7200000987654321", 5000.00m, "1234567890123456", "12/28");

           
            CreditAccount credit = new CreditAccount("GE55TB7300000456789123", 250.00m, "9876543210987654", "05/27");

            
            Console.WriteLine("=== მიმდინარე ანგარიში (Current) ===");
            Console.WriteLine($"ანგარიში: {current.AccountNumber}");
            Console.WriteLine($"ბალანსი: {current.Balance} ლარი");
            Console.WriteLine($"ოვერდრაფტი: {current.OverdraftLimit} ლარი\n");

            Console.WriteLine("=== დეპოზიტის ანგარიში (Deposit) ===");
            Console.WriteLine($"ანგარიში: {deposit.AccountNumber}");
            Console.WriteLine($"ბალანსი: {deposit.Balance} ლარი");
            Console.WriteLine($"ბარათი: {deposit.CardNumber}, ვადა: {deposit.ExpiryDate}\n");

            Console.WriteLine("=== საკრედიტო ანგარიში (Credit) ===");
            Console.WriteLine($"ანგარიში: {credit.AccountNumber}");
            Console.WriteLine($"ბალანსი: {credit.Balance} ლარი");
            Console.WriteLine($"ბარათი: {credit.CardNumber}, ვადა: {credit.ExpiryDate}");
        }
    }
}
