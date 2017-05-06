using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Run run = new BankApp.Run();
            run.RunTheApp(run);
        }
    }
}
