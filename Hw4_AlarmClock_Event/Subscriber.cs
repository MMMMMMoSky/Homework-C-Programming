using System;
using System.Threading.Tasks;

namespace AlarmClock
{
    // 订阅器 AlarmClocks, 可以定义多种闹钟, 不过此例只实现了一个普通的闹钟: 异步延时执行"响铃"
    // 定义了事件处理函数
    public class AlarmClocks
    {
        public delegate void WaitForAlarm();
        public static WaitForAlarm wait;    // 等待所有闹钟再结束程序

        public static void normalAlarm(object sender, int seconds, string message)
        {
            Console.WriteLine("OK, clock will alarm {0} second{1}later.", seconds, seconds < 2 ? " " : "s ");

            var t = Task.Run(
                async delegate
                {
                    await Task.Delay(seconds * 1000);
                    Console.WriteLine("[{0}] {1}", DateTime.Now, message);
                    return 42;
                });

            wait += t.Wait;            
        }
    }
}