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
            //    var account =Bank.CreateAccount("test2test.com",accountType:TypeOfAccount.Savings,accountName: "MySavings");
            //   // var account=Bank.CreateAccount("test@test.com", "MyChecking", TypeOfAccount.Checking);
            //    //refernce, object, instance of a class

            //    account.Deposit(100.10M);
            //    Console.WriteLine($"Account number:{account.AccountNumber}");
            //    Console.WriteLine($"Email Address:{account.Emailaddress}");
            //    Console.WriteLine($"Account type: {account.AccountType}");

            //    var account2 = new Account
            //    {
            //        Emailaddress = "test2@test.com"
            //};

            //    account2.AccountType = TypeOfAccount.Savings;
            //    account2.Deposit(100.10M);
            //    Console.WriteLine($"Account number:{account2.AccountNumber}+" +
            //        $"Email Address:{account2.Emailaddress},Account type: {account2.AccountType}");

            Console.WriteLine("********************************************");
            Console.WriteLine("Welcome to Bank");
            Console.WriteLine("*********************************************");
            while (true)
            {
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Create an account");
                Console.WriteLine("2.Deposit");
                Console.WriteLine("3.Withdraw");
                Console.WriteLine("4.Print all accounts");

                Console.Write("Please select an option:");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        Console.WriteLine("Thank you for visiting");
                        return;

                    case "1":
                        Console.Write("Email address:");
                        var emailAddress = Console.ReadLine();
                        Console.Write("Account Name:");
                        var accountName = Console.ReadLine();
                        var typeofAccounts = Enum.GetNames(typeof(TypeOfAccount));
                        for (var i = 0; i < typeofAccounts.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}.{typeofAccounts[i]}");
                        }
                        Console.Write("Select type of Account:");
                        var accountType = Convert.ToInt32(Console.ReadLine());
                        var account = Bank.CreateAccount(emailAddress, accountName, (TypeOfAccount)(accountType - 1));
                        Console.WriteLine($"ANumber:{account.AccountNumber},Balance:{account.Balance},TOA:{account.AccountType}");
                        break;
                    case "2":
                        PrintAllAccounts();
                        Console.Write("Account nmber:");
                        var an = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Amount to deposit:");
                        var amount = Convert.ToDecimal(Console.ReadLine());
                        Bank.Deposit(an, amount);
                            break;
                    case "3":
                        break;
                    case "4":
                        PrintAllAccounts();
                        ; break;
                    default:
                        Console.WriteLine("Invalid choice, please try again");
                        break;
                }
            }

        }

        private static void PrintAllAccounts()
        {
            Console.Write("Email Address:");
            var emailAddress = Console.ReadLine();
            var accounts = Bank.GetAllAccounts(emailAddress);
            foreach (var acc in accounts)
            {
                Console.WriteLine($"ANumber:{acc.AccountNumber},Balance:{acc.Balance},TOA:{acc.AccountType}");

            }
        }
    }
}

