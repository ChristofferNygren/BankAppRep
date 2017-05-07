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
            Console.WriteLine("Would you like to:\n[1] Set up an account.");
            Console.WriteLine("[2] Manage existing account."); // Change name of existing account holder? Change CardType to existing account? 
            Console.WriteLine("[3] Make a deposit or withdrawl.");
            Console.WriteLine("[4] ");//Om jag kommer på nåt annat
            Console.WriteLine("[5] Exit");
        }

        public void TransactionMenu(AccountHolder accountholder)
        {
            Console.WriteLine("Would you like to make a:\n[1] Deposit\n[2] Withdraw");
            menuchoice.TransactionMenuChoice(accountholder);           
        }
        public void WithdrawMenu(AccountHolder accountholder)
        {
            Console.WriteLine("Would you like to withdraw from your\n[1] Debit\n[2] Credit");
            menuchoice.WithdrawMenuChoice(accountholder);
        }
        public void DepositMenu(AccountHolder accountholder)
        {
                Console.WriteLine("How much would you like to deposit?");
                menuchoice.DepositMenuChoice(accountholder);
        }
        public void WithdrawDebitMenu(AccountHolder accountholder)
        {
            Console.WriteLine("How much would you like to withdraw?");
            menuchoice.WithdrawDebitMenuChoice(accountholder);           
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();        
        }
        public void WithdrawCreditMenu(AccountHolder accountholder)
        {
            Console.WriteLine("How much would you like to withdraw?");
            menuchoice.WithdrawCreditMenuChoice(accountholder);            
            Console.WriteLine("Our current rate is 5%");
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
        public void ManageAccount(AccountHolder a)
        {
            Console.WriteLine($"Welcome {a.Name}, What feature of your account would you like to change? ");  
            // HÄR SKA ALEX FORTSÄTTA KODA SATAN IMÖÖÖRN!
            // hehe
        }

    }

}
