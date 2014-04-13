using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleObserver
{
    public abstract class NewsObserverAbstract: INewsObserver 
    {
        public abstract void UpdateNews(string article);

        public void Notify(String article)
        {
            System.Windows.Forms.MessageBox.Show(article, "New News.");
        }

    }
}
