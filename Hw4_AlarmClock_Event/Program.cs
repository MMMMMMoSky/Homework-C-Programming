namespace AlarmClock
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyAlarm alram = new MyAlarm(AlarmClocks.normalAlarm);

            // 设定两个延时闹钟 (相当于计时器)
            alram.SetClockAfter(3);
            alram.SetClockAfter(10, "Ohhhhhhh");

            // 设定一个闹钟, 在固定的时间响起
            alram.SetClockAt(System.DateTime.Now.AddSeconds(15), "Wake up! Wake up!");

            // 等待所有闹钟响铃之后再结束程序
            AlarmClocks.wait();
        }
    }
}