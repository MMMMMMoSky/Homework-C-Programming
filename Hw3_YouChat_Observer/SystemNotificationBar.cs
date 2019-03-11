using System;

namespace Hw3_YouChat_Observer
{
    class SystemNotificationBar : Observer, DisplayElement
    {
        private MessageMonitor monitor;
        private string messages;
        private string timeNow;

        public SystemNotificationBar(MessageMonitor monitor)
        {
            this.monitor = monitor;
            this.monitor.registerObserver(this);
        }

        public void update(string messages, string timeNow)
        {
            this.messages = "您有未读消息";
            this.timeNow = timeNow;
            display();
        }

        public void display()
        {
            Console.WriteLine("+------ SystemNotificationBar ------+");
            Console.WriteLine(" {0} {1}", timeNow.Split()[1], messages);
            Console.WriteLine("+------ SystemNotificationBar ------+\n");
        }

        public void remove()
        {
            this.monitor.removeObserver(this);
        }
    }
}