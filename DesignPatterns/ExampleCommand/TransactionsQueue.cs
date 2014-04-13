using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCommand
{
    public class TransactionsQueue
    {
        Queue<CommandAbstract> _transactions = new Queue<CommandAbstract>();

        public void AddTransaction(CommandAbstract command)
        {
            _transactions.Enqueue(command);
        }

        public void CommitTransactions()
        {
            CommandAbstract command;

            while (_transactions.Count > 0)
            {
                command = _transactions.Dequeue();
                command.Execute();
            }
        }

        public int TransactionQueueCount
        {
            get
            {
                return _transactions.Count;
            }
        }
    }
}
