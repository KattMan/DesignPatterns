using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCommand
{
    public class BankAccount
    {
        public Double Balance { get; private set; }

        public void Deposit(Double Amount)
        {
            Balance += Amount;
        }

        public void Withdraw(Double Amount)
        {
            Balance -= Amount;
        }
}
}
