using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BankApp
{
    public class ManageAccountHolder
    {
        public void ChangeAccountHolderName(AccountHolder a)
        {
            bool keeprunning = true;
            Console.WriteLine($"Allrighty then, what is your new name?");
            string newName = Console.ReadLine();
            Console.Clear();
            while (keeprunning)
            {
                Console.WriteLine($"Are you sure you would like to replace {a.Name}, with {newName}");
                Console.WriteLine("[Y] for yes.\n[N] for no.");
                string choice = Console.ReadLine();
                Console.Clear();
                if (choice.ToLower() == "y")
                {
                    a.Name = newName;
                    keeprunning = false;
                }
                else if (choice.ToLower() == "n")
                {
                    keeprunning = false;
                }
                else
                {
                    Console.WriteLine("You have to make a valid choice.");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }
        }
        public void ChangeAccountHolderAccountType(AccountHolder a)
        {
            bool keeprunning = true;
            #region From Debit to ACB Express
            if (a.UserAccount.AccountType == "Debitcard")
            {
                Console.WriteLine($"You currently have a {a.UserAccount.AccountType} card with us. Would you like to change up your plan?");
                Console.WriteLine("Changing your plan will give you the option to withdraw and shop from a credit portion of your account for a fee of 5%");
                while (keeprunning)
                {
                    Console.WriteLine("[Y] for yes.\n[N] for no.");
                    string choice = Console.ReadLine();
                    Console.Clear();
                    if (choice.ToLower() == "y")
                    {
                        a.UserAccount.AccountType = "ACB Express card";
                        keeprunning = false;
                    }
                    else if (choice.ToLower() == "n")
                    {
                        keeprunning = false;
                    }
                    else
                    {
                        Console.WriteLine("You have to make a valid choice.");
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                }
            }
            #endregion 
            #region From ACB Express to Debit
            else if (a.UserAccount.AccountType == "ACB Express card")
            {
                Console.WriteLine($"You currently have a {a.UserAccount.AccountType} card with us. Would you like to change up your plan?");
                Console.WriteLine("Changing your plan will remove the option to withdraw and shop with credit.");
                while (keeprunning)
                {
                    Console.WriteLine("[Y] for yes.\n[N] for no.");
                    string choice = Console.ReadLine();
                    Console.Clear();
                    if (choice.ToLower() == "y")
                    {
                        a.UserAccount.AccountType = "Debitcard";
                        keeprunning = false;
                    }
                    else if (choice.ToLower() == "n")
                    {
                        keeprunning = false;
                    }
                    else
                    {
                        Console.WriteLine("You have to make a valid choice.");
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                }
            }
            #endregion 
        }
    }
}
