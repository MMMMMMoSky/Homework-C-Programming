using System;

namespace AlarmClock
{
    // 发布器 MyAlarm 
    // 包含事件和委托的定义
    public class MyAlarm
    {
        // 设定数秒之后的闹钟
        public delegate void SetClockHandler(object sender, int seconds, string message);

        // 事件: 上面的委托的实例
        // event 关键字的意义: https://blog.csdn.net/lulu_jiang/article/details/6451300
        // 保证 OnSetClock 不能被任意调用, 而只能被MyAlarm调用
        // 类似于 private ?
        public event SetClockHandler OnSetClock;

        // 时间发布函数, 用户调用接口
        // 根据延迟秒数设定闹钟
        public void SetClockAfter(int seconds, string message = "Time is up!")
        {
            Console.WriteLine("Setting clock {0} second{1}later. [{2}]",
                seconds, seconds < 2 ? " " : "s ", DateTime.Now);
            if (OnSetClock == null)
            {
                Console.WriteLine("Failed: No alarm clock found.");
            }
            else if (seconds < 0)
            {
                Console.WriteLine("Failed: You can not set a clock at time before now.");
            }
            else
            {
                OnSetClock(this, seconds, message);
            }
        }

        // 时间发布函数, 用户调用接口
        // 设定某个时间点的闹钟
        // FIXME 有秒级的误差..
        public void SetClockAt(DateTime time, string message = "Time is up!")
        {
            Console.WriteLine("Setting clock at [{0}]", time);
            if (OnSetClock == null)
            {
                Console.WriteLine("Failed: No alarm clock found.");
                return;
            }

            DateTime now = DateTime.Now;
            if (time < now)
            {
                Console.WriteLine("Failed: You can not set a clock at time before now. [{0}]", now);
                return;
            }

            // 获取time和此刻的时间差
            TimeSpan ts = time.Subtract(now);
            int seconds = (int)ts.TotalSeconds;
            OnSetClock(this, seconds, message);
        }

        // 构造函数, 在实例化这个发布器时即可指定一个订阅器
        public MyAlarm(SetClockHandler handler)
        {
            OnSetClock += handler;
        }
    }
}