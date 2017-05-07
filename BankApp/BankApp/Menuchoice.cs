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
                    return true;
                case "4": ExitTheBank(accountHolder);
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
                    //Console.WriteLine("How much would you like to deposit?");
                    //double depositAmount = double.Parse(Console.ReadLine());
                    //account.AddFunds(account, depositAmount);
                    //Console.WriteLine($"You added {depositAmount} to your debit.");
                    break;
                case "2":
                    menus.WithdrawMenu(accountholder);
                    //Console.WriteLine("How much would you like to withdraw?");
                    //double withdrawAmount = double.Parse(Console.ReadLine());
                    //account.WithdrawFunds(account, withdrawAmount);
                    //Console.WriteLine($"You withdrew {withdrawAmount} from your account.");
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
            double addAmount = double.Parse(Console.ReadLine());
            accountholder.UserAccount.AddFunds(accountholder.UserAccount, addAmount);
            Console.WriteLine($"You added {addAmount} to you debit.\nYour balance is: {accountholder.UserAccount.AccountBalanceDebit}");
            Thread.Sleep(3000);
            Console.Clear();
        }

        public void WithdrawCreditMenuChoice(AccountHolder accountholder)
        {
            if (accountholder.UserAccount.AccountType == "ACB Express card")
            {
                double withdrawAmount = double.Parse(Console.ReadLine());
                Console.WriteLine($"You withdrew {withdrawAmount} from your credit");
            }
            else
            {
                Console.WriteLine("You don't own a credit card!\nTo use this feature go to Manage existing account in the Main menu");
            }          
        }
        public void WithdrawDebitMenuChoice(AccountHolder accountholder)
        {
            double withdrawAmount = double.Parse(Console.ReadLine());
            Console.Clear();
            accountholder.UserAccount.WithdrawFunds(accountholder.UserAccount, withdrawAmount);
            Console.WriteLine($"You withdrew {withdrawAmount} from your debit.\nYour balance is: {accountholder.UserAccount.AccountBalanceDebit}");
            Thread.Sleep(3000);
            Console.Clear();
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
