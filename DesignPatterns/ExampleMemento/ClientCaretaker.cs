using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleMemento
{
    public class ClientCaretaker
    {
        Stack<ClientMemento> _mementoStack = new Stack<ClientMemento>();

        public int MementoCount
        {
            get 
            {
                return _mementoStack.Count();
            }
        }

        public void CreateMemento(Client client)
        {
            _mementoStack.Push(new ClientMemento(client.FirstName, client.LastName, client.Company));
        }

        public void RestoreLastClientMemento(Client client)
        {
            ClientMemento memento = _mementoStack.Pop(); 

            client.FirstName = memento.FirstName;
            client.LastName = memento.LastName;
            client.Company = memento.Company;

        }
    }
}
