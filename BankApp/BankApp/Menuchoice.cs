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
        public void MainMenuChoice(AccountHolder accountHolder)
        {
            string choice = Console.ReadLine();
            switch (choice)
            {
                //case "1":
                //    accountHolder = new AccountHolder();
                //    Console.WriteLine("Thanks for signing with ACB, You can now start using our services.\nReturning to main menu.");
                //    Thread.Sleep(3000);
                //    break;
                case "1":
                    menus.ManageAccount(accountHolder);
                    break;
                case "2":
                    menus.TransactionMenu(accountHolder);
                    break;
                case "3":
                    break;
                default:
                    break;
            }
        }
        public void TransactionMenuChoice(AccountHolder accountholder)
        {
            string choice = Console.ReadLine();
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
            accountholder.UserAccount.WithdrawFunds(accountholder.UserAccount, withdrawAmount);
            Console.WriteLine($"You withdrew {withdrawAmount} from your debit.\nYour balance is: {accountholder.UserAccount.AccountBalanceDebit}");
        }
        public void ManageAccountChoice(AccountHolder a)
        {
            ManageAccountHolder mAH = new ManageAccountHolder();
            string choice = Console.ReadLine();
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
    }
}
