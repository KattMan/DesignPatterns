using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExampleCommand;

namespace UnitTestDesignPatterns
{
    [TestClass]
    public class CommandTests
    {
        [TestMethod]
        public void BankAccountCreateTest()
        {
            BankAccount bankAccount = new BankAccount();
            Assert.IsInstanceOfType(bankAccount, typeof(BankAccount));
        }

        [TestMethod]
        public void DepositCommandCreateTest()
        {
            DepositCommand command = new DepositCommand(null, 0);
            Assert.IsInstanceOfType(command, typeof(DepositCommand));
            Assert.IsInstanceOfType(command, typeof(CommandAbstract));
        }
        
        [TestMethod]
        public void WithdrawCommandCreateTest()
        {
            WithdrawCommand command = new WithdrawCommand(null, 0);
            Assert.IsInstanceOfType(command, typeof(WithdrawCommand));
            Assert.IsInstanceOfType(command, typeof(CommandAbstract));
        }

        [TestMethod]
        public void TransactionsQueueCreateTest()
        {
            TransactionsQueue command = new TransactionsQueue();
            Assert.IsInstanceOfType(command, typeof(TransactionsQueue));
        }

        [TestMethod]
        public void BankAccountStartingBalanceTest()
        {
            BankAccount bankAccount = new BankAccount();
            Assert.AreEqual(bankAccount.Balance, 0);
        }

        [TestMethod]
        public void BankAccountDepositTest()
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.Deposit(10.5);
            Assert.AreEqual(bankAccount.Balance, 10.5);
        }

        [TestMethod]
        public void BankAccountWithdrawTest()
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.Withdraw(10.5);
            Assert.AreEqual(bankAccount.Balance, -10.5);
        }

        [TestMethod]
        public void DepositCommandExecuteTest()
        {
            BankAccount bankAccount = new BankAccount();
            DepositCommand command = new DepositCommand(bankAccount, 10);
            command.Execute();
            Assert.AreEqual(bankAccount.Balance, 10);
        }

        [TestMethod]
        public void WithdrawCommandExecuteTest()
        {
            BankAccount bankAccount = new BankAccount();
            WithdrawCommand command = new WithdrawCommand(bankAccount, 10);
            command.Execute();
            Assert.AreEqual(bankAccount.Balance, -10);
        }

        [TestMethod]
        public void TransactionQueueAddTest()
        {
            BankAccount bankAccount = new BankAccount();
            WithdrawCommand command = new WithdrawCommand(bankAccount, 10);
            TransactionsQueue queue = new TransactionsQueue();
            
            queue.AddTransaction(command);

            Assert.AreEqual(queue.TransactionQueueCount, 1);
        }

        [TestMethod]
        public void TransactionQueueExecuteTest()
        {
            BankAccount bankAccount = new BankAccount();
            WithdrawCommand command = new WithdrawCommand(bankAccount, 10);
            TransactionsQueue queue = new TransactionsQueue();

            queue.AddTransaction(command);
            queue.CommitTransactions();
            Assert.AreEqual(queue.TransactionQueueCount, 0);
        }
    }
}
