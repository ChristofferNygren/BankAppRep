using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace BankApp
{
    public class Run
    {
        AccountHolder accountholder;
        Menus menus = new Menus();
        Menuchoice menuchoice = new Menuchoice();
        public void RunTheApp()
        {
            bool keepRunning = true;
            WelcomeAndRegister();
            while (keepRunning)
            {               
                menus.MainMenu();
                keepRunning = menuchoice.MainMenuChoice(accountholder);
            }
        }
        public void WelcomeAndRegister()
        {
            Console.WriteLine("Hello and Welcome to ACB!\nLet me guide you through a registration process.");
            Console.WriteLine("Press any key when you are ready to begin.");
            Console.ReadKey();
            Console.Clear();
            accountholder = new AccountHolder();
        }
    }
}
