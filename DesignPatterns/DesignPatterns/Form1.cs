using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExampleAbstractFactory;
using ExampleSimpleFactory;
using ExampleSingleton;
using ExampleBuilder;
using ExampleMemento;
using ExampleCommand;
using ExampleObserver;

namespace DesignPatterns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateOutput(String Message)
        {
            textBox1.Text += Message + "\r\n";
        }

        private void abstractFactoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateOutput("A factory will be created that will return an abstract instance depending on the variable passed in.");
            PizzaFactory pizzaFactory = new PizzaFactory();
            PizzaAbstract pizza;

            pizza = pizzaFactory.OrderPizza(Pizzas.Chicken);
            UpdateOutput(pizza.Prepare());

            pizza = pizzaFactory.OrderPizza(Pizzas.MeatLovers);
            UpdateOutput(pizza.Prepare());

            pizza = pizzaFactory.OrderPizza(Pizzas.Pepperoni);
            UpdateOutput(pizza.Prepare());

            UpdateOutput(""); 

        }

        private void singletonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateOutput("Multiple instances will be created but the same instance will always be returned giving the same value.");
            SingletonClass singleton1 = SingletonClass.GetInstance();
            SingletonClass singleton2 = SingletonClass.GetInstance();
            SingletonClass singleton3 = SingletonClass.GetInstance();
            UpdateOutput("Singleton 1 Generated Value:" + singleton1.GetValue());
            UpdateOutput("Singleton 2 Generated Value:" + singleton2.GetValue());
            UpdateOutput("Singleton 3 Generated Value:" + singleton3.GetValue());

            UpdateOutput(""); 

        }

        private void builderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateOutput("A machine instance is created and a builder is passed to it, the resulting object returned depends on the builder used.");
            SandwichMachine sandwichMachine = new SandwichMachine();
            Sandwich sandwich;

            sandwich = sandwichMachine.CreateSandwich(new MeatBallSandwichBuilder());
            UpdateOutput("Sandwich 1: " + sandwich.ToString());

            sandwich = sandwichMachine.CreateSandwich(new TurkeySandwichBuilder());
            UpdateOutput("Sandwich 2: " + sandwich.ToString());

            UpdateOutput(""); 

        
        }

        private void simpleFactoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateOutput("A factory is called and will return an instance following an interface definition, no abstract class used.");

            DogFactory dogFactory = new DogFactory();
            IDog dog;

            dog = dogFactory.GetDog(Dogs.Collie);
            UpdateOutput(dog.Bark());

            dog = dogFactory.GetDog(Dogs.Poodle);
            UpdateOutput(dog.Bark());

            dog = dogFactory.GetDog(Dogs.Wolfhound);
            UpdateOutput(dog.Bark());

            UpdateOutput("");
        }

        private void mementoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateOutput("A client is created, the current state is saved before changes are made, then the memento is restored back to the client.");

            Client client = new Client { FirstName="John", LastName = "Smith", Company = "Acme" };
            ClientCaretaker caretaker = new ClientCaretaker();

            UpdateClientDisplay(client, "Client Curret state:");
            UpdateOutput("Memento Count: " + caretaker.MementoCount);
            
            caretaker.CreateMemento(client);
            client.FirstName = "Jane";
            client.LastName = "Doe";
            client.Company = "Delta";
            UpdateClientDisplay(client, "Client New state:");
            UpdateOutput("Memento Count: " + caretaker.MementoCount);

            caretaker.RestoreLastClientMemento(client);
            UpdateClientDisplay(client, "Client Restored state:");
            UpdateOutput("Memento Count: " + caretaker.MementoCount);
            
        }

        private void UpdateClientDisplay(Client client, String Topic)
        {
            UpdateOutput(Topic);
            UpdateOutput(String.Format("\tFirstName: {0}", client.FirstName));
            UpdateOutput(String.Format("\t LastName: {0}", client.LastName));
            UpdateOutput(String.Format("\tCompany: {0}", client.Company));
        }

        private void commandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateOutput("A account is created, transaction commands are queued up then committed, the results are displayed.");

            BankAccount bankAccount = new BankAccount();
            TransactionsQueue queue = new TransactionsQueue();

            CommandAbstract command;
            
            UpdateOutput("Beginning account balance: " + bankAccount.Balance.ToString());

            command = new DepositCommand(bankAccount, 50);
            queue.AddTransaction(command);
            UpdateOutput("Depositing 50");

            command = new DepositCommand(bankAccount, 20);
            queue.AddTransaction(command);
            UpdateOutput("Depositing 20");

            command = new WithdrawCommand(bankAccount, 10);
            queue.AddTransaction(command);
            UpdateOutput("Withdrawing 10");

            UpdateOutput("Before committing account balance: " + bankAccount.Balance.ToString());
            queue.CommitTransactions();

            UpdateOutput("Final account balance: " + bankAccount.Balance.ToString());
        
        }

        private void observerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adapterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void facadeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void repositoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void decoratorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
