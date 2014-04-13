using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleMemento
{
    public class ClientMemento
    {
        public String FirstName { get; private set; }
        public String LastName { get; private set; }
        public String Company { get; private set; }

        public ClientMemento(String firstName, String lastName, String company)
        {
            FirstName = firstName;
            LastName = lastName;
            Company = company;
        }
    }
}
