using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleAbstractFactory
{
    public class PizzaFactory
    {

        public PizzaAbstract OrderPizza(Pizzas pizza)
        {
            PizzaAbstract _pizza = null;

            switch(pizza)
            {
                case (Pizzas.Chicken):
                    _pizza = new ChickenPizza();
                    break;
                case (Pizzas.Pepperoni):
                    _pizza = new PepperoniPizza();
                    break;
                case (Pizzas.MeatLovers):
                    _pizza = new MeatLoversPizza();
                    break;

            }

            return _pizza;
        }
    }
}
