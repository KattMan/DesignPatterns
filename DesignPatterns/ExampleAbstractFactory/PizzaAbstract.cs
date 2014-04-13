using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleAbstractFactory
{
    public abstract class PizzaAbstract
    {
        protected String _pizzaName;

        public String Prepare()
        {
            return _pizzaName;
        }
    }
}
