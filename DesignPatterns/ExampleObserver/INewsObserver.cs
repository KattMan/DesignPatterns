using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleObserver
{
    public interface INewsObserver
    {
        void UpdateNews(String article);
    }
}
