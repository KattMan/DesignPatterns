using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleBuilder
{
    public abstract class SandwichBuilder
    {
        protected Sandwich _sandwich;

        public Sandwich GetSandwich()
        {
            return _sandwich;
        }

        public void CreateNewSandwichProduct()
        {
            _sandwich = new Sandwich();
        }

        public abstract void BuildBread();
        public abstract void BuildMeat();
        public abstract void BuildCondiments();

    }
}
