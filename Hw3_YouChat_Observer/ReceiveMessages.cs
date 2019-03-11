using System;
using System.Threading;

namespace Hw3_YouChat_Observer
{
    class ReceiveMessages 
    {
        static void Main(string[] args) {
            MessageMonitor messageMonitor = new MessageMonitor();

            SystemNotificationBar systemNotificationBar = 
                new SystemNotificationBar(messageMonitor);
            YouChat youChat = new YouChat(messageMonitor);
            SmartBracelet smartBracelet = 
                new SmartBracelet(messageMonitor);

            messageMonitor.messagesCome("在吗", DateTime.Now.ToString());
            Thread.Sleep(1000);
            messageMonitor.messagesCome("今晚有没有空", DateTime.Now.ToString());
            Thread.Sleep(3000);
            messageMonitor.messagesCome("emmm, 我想去看电影 :)", DateTime.Now.ToString());
            Thread.Sleep(2000);
            messageMonitor.messagesCome("你有想看的电影吗", DateTime.Now.ToString());
        }
    }
}