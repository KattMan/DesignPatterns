using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleBuilder
{
    public class SandwichMachine
    {

        public Sandwich CreateSandwich(SandwichBuilder builder)
        {

            builder.CreateNewSandwichProduct();
            builder.BuildBread();
            builder.BuildCondiments();
            builder.BuildMeat();

            return builder.GetSandwich();
        }

    }
}
