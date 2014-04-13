using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleAbstractFactory
{
    public class ChickenPizza : PizzaAbstract 
    {
        public ChickenPizza()
        {
            _pizzaName = "Chicken Pizza";
        }

    }

    public class PepperoniPizza : PizzaAbstract
    {
        public PepperoniPizza()
        {
            _pizzaName = "Pepperoni Pizza";
        }

    }

    public class MeatLoversPizza : PizzaAbstract
    {
        public MeatLoversPizza()
        {
            _pizzaName = "Meat Lovers Pizza";
        }

    }
}
