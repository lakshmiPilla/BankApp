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
            Console.WriteLine("0.Exit");
            Console.WriteLine("1.Create an account");
            Console.WriteLine("2.Deposit");
            Console.WriteLine("3.Withdraw");
            Console.WriteLine("4.Print all accounts");

            Console.WriteLine("Please select an option");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "0":
                    Console.WriteLine("Thank you for visiting");
                    return;
           
                case "1":
                    Console.Write("Email address:");
                    var emailAddress=Console.ReadLine();
                    Console.Write("Account Name:");
                    var accountName = Console.ReadLine();
                    var typeofAccounts = Enum.GetNames(typeof(TypeOfAccount));
                    

                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                default:
                    break;
            }


        } 
    }
}

