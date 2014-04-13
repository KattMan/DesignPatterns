using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCommand
{
    public class DepositCommand: CommandAbstract
    {
        public DepositCommand(BankAccount account, Double amount)
        {
            _bankAccount = account;
            _transactionAmount = amount;
        }

        public override void Execute()
        {
            _bankAccount.Deposit(_transactionAmount);
        }
    }
}
