using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    static class Bank
    {
        private static List<Account> accounts = new List<Account>(); // accounts-refernce
        public static Account CreateAccount(string emailAddress,string accountName = "Default Account", TypeOfAccount accountType = TypeOfAccount.Checking)
        {
            var account = new Account
            {
                Emailaddress = emailAddress,
                AccountName = accountName,
                AccountType = accountType
            };
            accounts.Add(account);
            return account;
        }

        public static List<Account> GetAllAccounts()
        {
            return accounts;
        }

        public static void Deposit(int accountNumber, decimal amount)
        {
            // 'Where' is Linq and condition is Lambda when starts with => is Lambda
            var account = accounts.Where(a => a.AccountNumber == accountNumber).FirstOrDefault();
            if(account != null)
            {
                account.Deposit(amount);
            }
        }
    }
}
