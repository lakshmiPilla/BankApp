using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public enum TypeOfAccount
    {
        Checking,
        Savings,
        CD,
        Loan
    }
    public class Account
    {
      //  private static int lastAccountNumber = 0;
        #region Constructor
        public Account()
        {
            //AccountNumber = ++lastAccountNumber;
        }
        //when we are calling 2nd constructor, THIS keyword calls other Constructer also
        //public Account(string emailaddress): this()
        //{
        //    Emailaddress = emailaddress;
        //}
        //public Account(string checkingType,string emailaddress):this()
        //{

        //}
        #endregion
        
        #region Properties
            [Key]
        public int AccountNumber { get; private set; }
        [StringLength(100, ErrorMessage ="Emailaddress should be of 50 characters in Length")]
        public string Emailaddress { get; set; }
        public string AccountName { get; set; }
        public TypeOfAccount AccountType { get; set; }
        public decimal Balance { get; private set; }
        #endregion

        #region Methods
        /// <summary>
        /// Deposit money into your account
        /// </summary>
        /// <param name="amount">amount to be deposited</param>
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
#endregion
    }
}
