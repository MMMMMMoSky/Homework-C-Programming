namespace OrderManager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // TODO 不适合用主函数演示
            // 应该写一个命令行交互式的演示程序
            OrderManager manager = new OrderManager();

            manager.Add("钢铁侠", "苹果", 3);
            manager.Add("钢铁侠", "橘子", 2);
            manager.Add("美国队长", "香蕉", 5);
            manager.Add("旺达", "苹果", 3);
            manager.Add("黑寡妇", "西瓜", 3);

            manager.Find(customer: "钢铁侠");

            manager.Update(1234, nums: 5);

            manager.Remove(commodity: "苹果");

            manager.Save();
        }
    }
}