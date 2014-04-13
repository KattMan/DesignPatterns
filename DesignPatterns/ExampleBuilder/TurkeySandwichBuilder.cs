using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleBuilder
{
    public class TurkeySandwichBuilder: SandwichBuilder
    {

        public override void BuildBread()
        {
            _sandwich.SetBread("White");
        }

        public override void BuildMeat()
        {
            _sandwich.SetMeat("Sliced Turkey");
        }

        public override void BuildCondiments()
        {
            _sandwich.SetCondiments("Mayonaise");
        }
    }
}
