using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public interface Subject
    {
        public void RegisterObserver(Observer observer) { }

        public void RemoveOserve(Observer observer) { }

        public void NotifyObservers() { }
    }
}
