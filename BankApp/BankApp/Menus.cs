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
            Console.WriteLine("[2] Manage existing account.");
            Console.WriteLine("[3] Make a deposit or withdrawl.");
            Console.WriteLine("[4] ");//Om jag kommer på nåt annat

        }
        public void TransactionMenu()
        {
            Console.WriteLine("Would you like to make a witdrawl, press [1]\nDeposit, press [2]");
            menuchoice.transactionMenuChoice();
        }
        public void ManageAccount()
        {

        }

    }

}
