using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleObserver
{
    public abstract class NewsPublisherAbstract
    {
        List<INewsObserver> _observers = new List<INewsObserver>();
        List<String> _articles = new List<string>();

        public void AttachObserver(INewsObserver observer)
        {
            _observers.Add(observer);
        }

        public void DetachObserver(INewsObserver observer)
        {
            _observers.Remove(observer);
        }

        public void AddArticle(String article)
        {
            _articles.Add(article);
            NotifyObservers(article);

        }

        public void NotifyObservers(String article)
        {
            foreach (INewsObserver o in _observers)
            {
                o.UpdateNews(article);
            }
        }

        public List<String> GetAllArticles()
        {
            return _articles;
        }
    }
}
