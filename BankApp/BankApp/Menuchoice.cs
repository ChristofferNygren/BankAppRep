using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class Menuchoice
    {

        public void MainMenuChoice()
        {
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AccountHolder accountholder = new AccountHolder();
                    break;
                case "2":
                    menus.ManageAccount();
                    break;
                case "3":
                    menus.TransactionMenu();
                    break;
                case "4":
                    break;
                default:
                    break;
            }
        }
        public void TransactionMenuChoice(Account account)
        {
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("How much would you like to deposit?");
                    double depositAmount = double.Parse(Console.ReadLine());
                    account.AddFunds(account, depositAmount);
                    Console.WriteLine($"You added {depositAmount} to your account.");
                    break;
                case "2":
                    Console.WriteLine("How much would you like to withdraw?");
                    double withdrawAmount = double.Parse(Console.ReadLine());
                    account.WithdrawFunds(account, withdrawAmount);
                    Console.WriteLine($"You withdrew {withdrawAmount} from your account.");
                    break;
                default:
                    break;
            }           
        }
    }
}
