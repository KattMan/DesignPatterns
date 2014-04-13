using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExampleMemento;

namespace UnitTestDesignPatterns
{
    [TestClass]
    public class MementoTests
    {
        [TestMethod]
        public void ClientCreateTest()
        {
            Client client = new Client();
            Assert.IsInstanceOfType(client, typeof(Client));
        }

        [TestMethod]
        public void ClientMementoCreateTest()
        {
            ClientMemento memento = new ClientMemento("","","");
            Assert.IsInstanceOfType(memento, typeof(ClientMemento));
        }

        [TestMethod]
        public void ClientCaretakerCreateTest()
        {
            ClientCaretaker caretaker = new ClientCaretaker();
            Assert.IsInstanceOfType(caretaker, typeof(ClientCaretaker));
        }

        [TestMethod]
        public void CaretakerMementoCountTest()
        {
            Client client = new Client();
            ClientCaretaker caretaker = new ClientCaretaker();
            caretaker.CreateMemento(client);

            Assert.AreEqual(caretaker.MementoCount, 1);
        }

        [TestMethod]
        public void CaretakerMementoRestoreTest()
        {
            Client client = new Client();
            ClientCaretaker caretaker = new ClientCaretaker();
            client.FirstName = "First";
            caretaker.CreateMemento(client);
            client.FirstName = "Second";
            caretaker.RestoreLastClientMemento(client);
            Assert.AreEqual(client.FirstName, "First");
        }

        [TestMethod]
        public void CaretakerMementoRestoreCountTest()
        {
            Client client = new Client();
            ClientCaretaker caretaker = new ClientCaretaker();
            caretaker.CreateMemento(client);
            caretaker.RestoreLastClientMemento(client);
            Assert.AreEqual(caretaker.MementoCount, 0);
        }

    }
}
