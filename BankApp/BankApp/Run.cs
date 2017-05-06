using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class Run
    {
        Menus menus = new Menus();
        public void RunTheApp()
        {
            
            menus.MainMenu();
            MainMenuChoice();
        }
        public void MainMenuChoice()
        {
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    menus.SetUpAccount();
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
    }
}
