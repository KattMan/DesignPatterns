using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSimpleFactory
{
    public class Collie : IDog
    {
        public string Bark()
        {
            return "The Collie says Bark Bark";
        }
    }
    public class Poodle : IDog
    {
        public string Bark()
        {
            return "The Poodle says Yip Yip";
        }
    }
    public class Wolfhound : IDog
    {
        public string Bark()
        {
            return "The Wolfhound says Woof Woof";
        }
    }
}
