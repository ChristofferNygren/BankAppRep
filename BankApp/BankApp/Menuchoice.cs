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
        public void TransactionMenuChoice()
        {
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    menus.DepositMenu();
                    //Console.WriteLine("How much would you like to deposit?");
                    //double depositAmount = double.Parse(Console.ReadLine());
                    //account.AddFunds(account, depositAmount);
                    //Console.WriteLine($"You added {depositAmount} to your debit.");
                    break;
                case "2":
                    menus.WithdrawMenu();
                    //Console.WriteLine("How much would you like to withdraw?");
                    //double withdrawAmount = double.Parse(Console.ReadLine());
                    //account.WithdrawFunds(account, withdrawAmount);
                    //Console.WriteLine($"You withdrew {withdrawAmount} from your account.");
                    break;
                default:
                    break;
            }           
        }
        public void WithdrawMenuChoice()
        {
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    menus.DebitMenu();
                    break;
                case "2":
                    menus.CreditMenu();
                    break;
                default:
                    break;
            }
        }
        public void DepositMenuChoice()
        {

        }

        public void CreditMenuChoice()
        {
            double Withdraw = double.Parse(Console.ReadLine());

        }
        public void DebitMenuChoice()
        {
        }
    }
}
