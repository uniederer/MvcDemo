using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcDemo.Model
{
    public class TextModel
    {
        public string Content => _text;

        private readonly HashSet<ITextModelObserver> _observers = new();
        private string _text = string.Empty;

        public void Clear()
        {
            _text = string.Empty;
            NotifyObservers();
        }

        public void SetContent(string text)
        {
            _text = text;
            NotifyObservers();
        }

        private void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.OnContentChanged(this);
            }
        }

        public void RegisterView(ITextModelObserver view)
        {
            _observers.Add(view);
        }

        public void UnregisterView(ITextModelObserver view)
        {
            _observers.Remove(view);
        }
    }
}
