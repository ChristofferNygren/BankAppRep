using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class AccountHolder
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public Account MyProperty { get; set; }

        public AccountHolder(string name)
        {
            this.Name = name;
        }  
    }
}
