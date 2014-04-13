using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCommand
{
    public abstract class CommandAbstract
    {
        protected internal BankAccount _bankAccount;
        protected internal double _transactionAmount;

        public abstract void Execute();

    }
}
