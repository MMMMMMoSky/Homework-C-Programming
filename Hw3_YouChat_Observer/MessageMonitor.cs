using System;
using System.Collections;

namespace Hw3_YouChat_Observer
{
    class MessageMonitor : Observable
    {
        private ArrayList observers;
        private string messages;
        private string timeNow;

        public MessageMonitor()
        {
            observers = new ArrayList();
        }

        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }

        public void removeObserver(Observer o)
        {
            observers.Remove(o);
        }

        public void notifyObservers()
        {
            foreach (Observer observer in observers)
            {
                observer.update(messages, timeNow);
            }
        }

        public void messagesCome(string messages, string timeNow)
        {
            this.messages = messages;
            this.timeNow = timeNow;
            notifyObservers();
        }
    }
}