using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BankApp
{
    public class Menus
    {


        public void MainMenu()
        {
            Console.WriteLine("Hello and welcome to ACB, How can we be of service today?");
            Console.WriteLine("Would you like to:");
            Console.WriteLine("[1] Manage existing account."); // Change name of existing account holder? Change CardType to existing account? 
            Console.WriteLine("[2] Make a deposit or withdrawl.");
            Console.WriteLine("[3] ");//Om jag kommer på nåt annat
            Console.WriteLine("[4] Exit");
        }

        public void TransactionMenu(AccountHolder accountholder)
        {
            Menuchoice menuchoice = new Menuchoice();
            Console.WriteLine("Would you like to make a:\n[1] Deposit\n[2] Withdraw");
            menuchoice.TransactionMenuChoice(accountholder);
        }
        public void WithdrawMenu(AccountHolder accountholder)
        {
            Menuchoice menuchoice = new Menuchoice();
            Console.WriteLine("Would you like to withdraw from your\n[1] Debit\n[2] Credit");
            menuchoice.WithdrawMenuChoice(accountholder);
        }
        public void DepositMenu(AccountHolder accountholder)
        {
            Menuchoice menuchoice = new Menuchoice();
            Console.WriteLine("How much would you like to deposit?");
            menuchoice.DepositMenuChoice(accountholder);
        }
        public void WithdrawDebitMenu(AccountHolder accountholder)
        {
            Menuchoice menuchoice = new Menuchoice();
            Console.WriteLine("How much would you like to withdraw?");
            menuchoice.WithdrawDebitMenuChoice(accountholder);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
        public void WithdrawCreditMenu(AccountHolder accountholder)
        {
            Menuchoice menuchoice = new Menuchoice();
            Console.WriteLine("How much would you like to withdraw?");
            menuchoice.WithdrawCreditMenuChoice(accountholder);           
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
        public void ShowFunds(AccountHolder accountholder)
        {
            if (accountholder.UserAccount.AccountType == "ACB Express card")
            {
                Console.WriteLine("Here's you current balance on your account:\n");               
                Console.WriteLine($"Your debit funds: {accountholder.UserAccount.AccountBalanceDebit}");
                Console.WriteLine($"Your credit funds: {accountholder.UserAccount.AccountBalanceCredit}");
                Thread.Sleep(3000);
            }
            else
            {
                Console.WriteLine($"Your debit funds: {accountholder.UserAccount.AccountBalanceDebit}");
                Thread.Sleep(3000);
            }
        }
        public void ManageAccount(AccountHolder a)
        {
            Menuchoice menuchoice = new Menuchoice();
            Console.WriteLine($"Welcome {a.Name}, What feature of your account would you like to change? ");
            Console.WriteLine($"[1] Name of accountholder. (Only if you have legally changed your name from {a.Name}).\n[2] account-type");
            menuchoice.ManageAccountChoice(a);
        }

    }

}
