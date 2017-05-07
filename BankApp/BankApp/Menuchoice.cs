using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BankApp
{
    public class Menuchoice
    {
        Menus menus = new Menus();
        public bool MainMenuChoice(AccountHolder accountHolder)
        {
            string choice = Console.ReadLine();
            Console.Clear();
            switch (choice)
            {
                case "1":
                    menus.ManageAccount(accountHolder);
                    return true;
                case "2":
                    menus.TransactionMenu(accountHolder);
                    return true;
                case "3":
                    menus.ShowFunds(accountHolder);
                    return true;
                case "4":
                    ExitTheBank(accountHolder);
                    return false;
                default:
                    return true;
            }
        }
        public void TransactionMenuChoice(AccountHolder accountholder)
        {
            string choice = Console.ReadLine();
            Console.Clear();
            switch (choice)
            {
                case "1":
                    menus.DepositMenu(accountholder);
                    break;
                case "2":
                    menus.WithdrawMenu(accountholder);
                    break;
                default:
                    break;
            }           
        }
        public void WithdrawMenuChoice(AccountHolder accountholder)
        {
            string choice = Console.ReadLine();
            Console.Clear();
            switch (choice)
            {
                case "1":
                    menus.WithdrawDebitMenu(accountholder);
                    break;
                case "2":
                    menus.WithdrawCreditMenu(accountholder);
                    break;
                default:
                    break;
            }
        }
        public void DepositMenuChoice(AccountHolder accountholder)
        {
            try
            {
                double addAmount = Math.Abs(double.Parse(Console.ReadLine()));
                accountholder.UserAccount.AddFundsDebit(accountholder.UserAccount, addAmount);
                Console.WriteLine($"You added {addAmount} to you debit.\nYour balance is: {accountholder.UserAccount.AccountBalanceDebit}");
                Thread.Sleep(3000);
                Console.Clear();
            }
            catch (Exception)
            {
                Console.WriteLine("You have to withdraw a numerical value");
                Thread.Sleep(2000);
                Console.Clear();
            }

        }

        public void WithdrawCreditMenuChoice(AccountHolder accountholder)
        {
            if (accountholder.UserAccount.AccountType == "ACB Express card")
            {
                try
                {
                    double addCreditAmount = Math.Abs(double.Parse(Console.ReadLine()));
                    Console.WriteLine($"You withdrew {addCreditAmount} from your credit");
                    accountholder.UserAccount.AddFundsCredit(accountholder.UserAccount, addCreditAmount);
                    accountholder.UserAccount.CreditIntrestCalculation();
                }
                catch (Exception)
                {
                    Console.WriteLine("You have to withdraw a numerical value");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("\nYour current account does not include a credit balance\nTo upgrade your account, select manage existing account in the Main menu");
            }          
        }
        public void WithdrawDebitMenuChoice(AccountHolder accountholder)
        {
            try
            {
                double withdrawAmount = Math.Abs(double.Parse(Console.ReadLine()));
                Console.Clear();
                accountholder.UserAccount.WithdrawFunds(accountholder.UserAccount, withdrawAmount);
                Thread.Sleep(3000);
                Console.Clear();
            }
            catch (Exception)
            {
                Console.WriteLine("You have to withdraw a numerical value");
                Thread.Sleep(2000);
                Console.Clear();
            }

        }
        public void ManageAccountChoice(AccountHolder a)
        {
            ManageAccountHolder mAH = new ManageAccountHolder();
            string choice = Console.ReadLine();
            Console.Clear();
            switch (choice)
            {
                case "1":
                    mAH.ChangeAccountHolderName(a);
                    break;
                case "2":
                    mAH.ChangeAccountHolderAccountType(a);
                    break;
                default:
                    break;
            }
        }
        public void ExitTheBank(AccountHolder a)
        {
            Console.WriteLine($"Thanks for your visit {a.Name}, Hope to see you soon.");
            Thread.Sleep(2500);
        }
    }
}
