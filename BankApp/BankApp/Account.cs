using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class Account
    {
        public double AccountBalanceCredit { get; set; }
        public double AccountBalanceDebit { get; set; }
        public string AccountType { get; set; }

        public Account(string accountType)
        {
            this.AccountType = accountType;
        }

        public void AddFundsDebit(Account account, double add)
        {
            account.AccountBalanceDebit += add;
        }
        public void AddFundsCredit(Account account, double add)
        {
            account.AccountBalanceCredit += add;
        }
        public void WithdrawFunds(Account account, double withdraw)
        {
            if (withdraw > AccountBalanceDebit)
            {
                Console.WriteLine("\nYou dont have that amount.\nPlease add funds to your account before you continue.\n");
            }
            else
            {
                account.AccountBalanceDebit -= withdraw;
            }
        }
    }
}
