using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleBuilder
{
    public class MeatBallSandwichBuilder : SandwichBuilder
    {
        public override void BuildBread()
        {
            _sandwich.SetBread("Italian");
        }

        public override void BuildMeat()
        {
            _sandwich.SetMeat("Meatballs");
        }

        public override void BuildCondiments()
        {
            _sandwich.SetCondiments("Tomato Sauce");
        }
    }
}
