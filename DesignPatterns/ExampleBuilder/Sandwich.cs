using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleBuilder
{
    public class Sandwich
    {
        String _bread;
        String _meat;
        String _condiments;

        public void SetBread(String bread)
        {
            _bread = bread;
        }

        public void SetMeat(String meat)
        {
            _meat = meat;
        }

        public void SetCondiments(String condiments)
        {
            _condiments = condiments;
        }

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(_meat);
            sb.Append(" with " + _condiments);
            sb.Append(" on " + _bread + " bread");

            return sb.ToString();
        }
    }
}
