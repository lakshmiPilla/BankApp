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
    }
}
