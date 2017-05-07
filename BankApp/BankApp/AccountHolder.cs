using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace BankApp
{
    public class AccountHolder
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public Account UserAccount { get; set; }

        public AccountHolder()
        {
            this.Id = Guid.NewGuid();
            this.Name = DecideAccountHolderName();
            this.UserAccount = new Account(ChooseAccountType());

        }

        public string DecideAccountHolderName()
        {
            Console.WriteLine("Welcome, All we need to know is your name, and what type of account you would like. The rest will be taken care of by our support staff.");
            Console.WriteLine("In what name would you like to create the account?");
            string name = Console.ReadLine();
            return name;
        }
        public string ChooseAccountType()
        {
            string accountType = "";
            while (accountType != "Debitcard" && accountType != "ACB Express card")
            {
                Console.WriteLine($"Ok, {Name}. Would you like to set up a Debit-Account, or a Credit-Account?");
                Console.WriteLine("[1] for Debit-Account.");
                Console.WriteLine("[2] for ACB Express-Account.");
                accountType = SetAccountType();                                                             
            }
            return accountType;
        }
        public string SetAccountType()
        {
            string choice = Console.ReadLine();
            string a = "";
            switch (choice)
            {
                case "1":
                    a = "Debitcard";
                    return a;
                case "2":
                    a = "ACB Express card";
                    return a;
                default:
                    return a;
            }
        }
    }
}
