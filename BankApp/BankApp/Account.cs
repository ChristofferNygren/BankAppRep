using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
   public class Account
    {
        public double AccountBalance { get; set; }
        public string AccountType { get; set; }

        public Account(string accountType)
        {
            this.AccountType = accountType;
        }

        public void AddFunds(Account account, double add)
        {
            account.AccountBalance += add;
        }
        public void WithdrawFunds(Account account, double withdraw)
        {
            account.AccountBalance -= withdraw;
        }
    }
}
