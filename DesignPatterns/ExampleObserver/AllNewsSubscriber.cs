using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleObserver
{
    public class AllNewsSubscriber : NewsObserverAbstract
    {
        public override void UpdateNews(string article)
        {
            throw new NotImplementedException();
        }
    }
}
