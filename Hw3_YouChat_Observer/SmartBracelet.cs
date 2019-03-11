using System;

namespace Hw3_YouChat_Observer
{
    class SmartBracelet : Observer, DisplayElement
    {
        private MessageMonitor monitor;
        private string messages;
        private string timeNow;
        private int len;

        public SmartBracelet(MessageMonitor monitor)
        {
            this.monitor = monitor;
            this.monitor.registerObserver(this);
        }

        public void update(string messages, string timeNow)
        {
            len = messages.Length;
            if (len > 5)
            {
                this.messages = messages.Substring(0, 5);
                this.messages += "...";
            }
            else
            {
                this.messages = messages;
            }
            this.timeNow = timeNow;
            display();
        }

        public void display()
        {
            Console.WriteLine("+~~~~~ SmartBracelet ~~~~~+");
            Console.WriteLine(" {0} {1}", timeNow.Split()[1], messages);
            Console.WriteLine("+~~~~~ SmartBracelet ~~~~~+\n");
        }

        public void remove()
        {
            this.monitor.removeObserver(this);
        }
    }
}