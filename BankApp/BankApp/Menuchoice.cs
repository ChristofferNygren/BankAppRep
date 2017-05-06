using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
   public class Menuchoice
    {
        public void transactionMenuChoice()
        {
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("How much would you like to deposit?");
                    double depositAmount = double.Parse(Console.ReadLine());
                    break;
                case "2":
                    Console.WriteLine("How much would you like to withdraw?");
                    double withdrawAmount = double.Parse(Console.ReadLine());
                    break;
                default:
                    break;
            }
        }
    }
}
