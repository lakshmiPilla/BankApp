using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //refernce, object, instance of a class
            var account = new Account
            {
                AccountName = "MyChecking",
                AccountType = TypeOfAccount.Checking,
                Emailaddress = "test@test.com"
            };
           
            account.Deposit(100.10M);
            Console.WriteLine($"Account number:{account.AccountNumber}");
            Console.WriteLine($"Email Address:{account.Emailaddress}");
            Console.WriteLine($"Account type: {account.AccountType}");

            var account2 = new Account
            {
                Emailaddress = "test2@test.com"
        };
           
            account2.AccountType = TypeOfAccount.Savings;
            account2.Deposit(100.10M);
            Console.WriteLine($"Account number:{account2.AccountNumber}+" +
                $"Email Address:{account2.Emailaddress},Account type: {account2.AccountType}");
        } 
    }
}

