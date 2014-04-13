using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExampleAbstractFactory;
using Moq;

namespace UnitTestDesignPatterns
{
    [TestClass]
    public class FactoryTests
    {
        [TestMethod]
        public void ChickenPizzaCreateTest()
        {
            PizzaAbstract Pizza = new ChickenPizza();
            Assert.IsInstanceOfType(Pizza, typeof(ChickenPizza));
        }

        [TestMethod]
        public void ChickenPizzaPrepareTest()
        {
            PizzaAbstract Pizza = new ChickenPizza();
            string s = Pizza.Prepare(); 
            Assert.AreEqual("Chicken Pizza", s);
        }

        [TestMethod]
        public void PepperoniPizzaCreateTest()
        {
            PizzaAbstract Pizza = new PepperoniPizza();
            Assert.IsInstanceOfType(Pizza, typeof(PepperoniPizza));
        }

        [TestMethod]
        public void PepperoniPizzaPrepareTest()
        {
            PizzaAbstract Pizza = new PepperoniPizza();
            string s = Pizza.Prepare();
            Assert.AreEqual("Pepperoni Pizza", s);
        }

        [TestMethod]
        public void MeatLoversPizzaCreateTest()
        {
            PizzaAbstract Pizza = new MeatLoversPizza();
            Assert.IsInstanceOfType(Pizza, typeof(MeatLoversPizza));
        }

        [TestMethod]
        public void MeatLoversPizzaPrepareTest()
        {
            PizzaAbstract Pizza = new MeatLoversPizza();
            string s = Pizza.Prepare();
            Assert.AreEqual("Meat Lovers Pizza", s);
        }

        [TestMethod]
        public void PizzaFactoryChickenTest()
        {
            PizzaFactory pizzaFactory = new PizzaFactory();

            PizzaAbstract p = pizzaFactory.OrderPizza(Pizzas.Chicken);
            Assert.IsInstanceOfType(p, typeof(ChickenPizza));
        }

        [TestMethod]
        public void PizzaFactoryPepperoniTest()
        {
            PizzaFactory pizzaFactory = new PizzaFactory();

            PizzaAbstract p = pizzaFactory.OrderPizza(Pizzas.Pepperoni);
            Assert.IsInstanceOfType(p, typeof(PepperoniPizza));
        }

        [TestMethod]
        public void PizzaFactoryMeatLoversTest()
        {
            PizzaFactory pizzaFactory = new PizzaFactory();

            PizzaAbstract p = pizzaFactory.OrderPizza(Pizzas.MeatLovers);
            Assert.IsInstanceOfType(p, typeof(MeatLoversPizza));
        }

    }
}
