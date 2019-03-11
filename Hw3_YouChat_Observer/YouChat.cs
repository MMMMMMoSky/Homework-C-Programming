using System;

namespace Hw3_YouChat_Observer
{
    class YouChat : Observer, DisplayElement
    {
        private MessageMonitor monitor;
        private string messages;
        private string timeNow;

        public YouChat(MessageMonitor monitor)
        {
            this.monitor = monitor;
            this.monitor.registerObserver(this);
        }

        public void update(string messages, string timeNow)
        {
            this.messages = messages;
            this.timeNow = timeNow;
            display();
        }

        public void display()
        {
            Console.WriteLine("+========= YouChat =========+");
            Console.WriteLine(" {0} {1}", timeNow, messages);
            Console.WriteLine("+========= YouChat =========+\n");
        }

        public void remove()
        {
            this.monitor.removeObserver(this);
        }
    }
}