using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSimpleFactory
{
    public class DogFactory
    {
        public IDog GetDog(Dogs breed)
        {
            switch(breed)
            {
                case Dogs.Collie:
                    return new Collie();
                case Dogs.Poodle:
                    return new Poodle();
                case Dogs.Wolfhound:
                    return new Wolfhound();
                default:
                    return null;
            }
        }
    }
}
