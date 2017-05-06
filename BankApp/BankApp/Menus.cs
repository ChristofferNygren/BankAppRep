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
        Menuchoice menuchoice = new Menuchoice();
        public void MainMenu()
        {
            Console.WriteLine("Hello and welcome to ACB, How can we be of service today?");
            Console.WriteLine("Would you like to:\n [1] Set up an account.");
            Console.WriteLine("[2] Manage existing account."); // Change name to existing account? Change CardType to existing account? 
            Console.WriteLine("[3] Make a deposit or withdrawl.");
            Console.WriteLine("[4] ");//Om jag kommer på nåt annat
            Console.WriteLine("[5] Exit");
        }

        public void TransactionMenu(Account account)
        {
            Console.WriteLine("Would you like to make a:\n[1] Deposit\n[2] Withdraw");
            menuchoice.TransactionMenuChoice();
            Console.WriteLine($"Your total balance is: {account.AccountBalanceDebit}");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        public void WithdrawMenu()
        {
            Console.WriteLine("Would you like to withdraw from your\n[1] Debit\n[2] Credit");
            menuchoice.WithdrawMenuChoice();

        }
        public void DepositMenu()
        {
                Console.WriteLine("How much would you like to deposit?");
                menuchoice.DepositMenuChoice();
        }
        public void CreditMenu(AccountHolder accountholder)
        {
            if (accountholder.UserAccount.AccountType == "ACB Express card")
            {
                Console.WriteLine("How much would you like to withdraw?");
                menuchoice.CreditMenuChoice();
            }
            else
            {
                Console.WriteLine("You don't have a ACB Express card.");
                Console.WriteLine("To use this feature upgrade your card in Manage account section.");
            }     
        }
        public void DebitMenu()
        {

        }

        public void ManageAccount()
        {

        }

    }

}
