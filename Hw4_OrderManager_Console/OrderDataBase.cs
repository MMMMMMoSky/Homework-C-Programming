using System;
using System.IO;
using System.Collections.Generic;

namespace OrderManager
{
    /*
      订单数据存储类
      负责管理订单数据, 进行文件读写
     */
    public class OrderDataBase
    {
        private List<Order> orderList; // 订单列表
        private string filename; // 当前DB对应的文件

        // 构造函数, 从指定文件中读入订单信息
        public OrderDataBase(string filename = "orderdata.txt")
        {
            this.filename = filename;
            orderList = new List<Order>();

            StreamReader sr;
            try
            {
                sr = new StreamReader(filename);
            }
            catch (FileNotFoundException)
            {
                return;
            }
            catch (ArgumentException)
            {
                this.filename = "orderdata.txt";
                return;
            }

            for (string line = sr.ReadLine(); line != null; line = sr.ReadLine())
            {
                orderList.Add(new Order(line)); // TODO: 异常处理
            }
            sr.Close();
        }

        public void Add(Order o)
        {
            orderList.Add(o); // 过度封装了...?
        }

        // 指定某些特征来查找
        public List<Order> Find(ulong id = 0, string customer = null, string commodity = null, uint nums = 0)
        {
            List<Order> result = new List<Order>();
            foreach (Order o in orderList)
            {
                if (
                    (id == 0 || id == o.id) &&
                    (nums == 0 || nums == o.nums) &&
                    (customer == null || customer == o.customer) &&
                    (commodity == null || commodity == o.commodity)
                )
                {
                    result.Add(o);
                }
            }
            return result;
        }

        // 指定某些特征来删除
        public List<Order> Remove(ulong id = 0, string customer = null, string commodity = null, uint nums = 0)
        {
            List<Order> removeList = Find(id, customer, commodity, nums);
            foreach (Order o in removeList)
            {
                orderList.Remove(o); // TODO 可以用for循环优化掉额外的空间消耗, 即不调用Find
            }
            return removeList;
        }

        // 保存文件
        public void Save()
        {
            StreamWriter sw = new StreamWriter(filename, false);
            foreach (Order o in orderList)
            {
                sw.WriteLine(o);
            }
            sw.Close();
        }

        /* 单元测试 通过
        public static void Main(string[] args)
        {
            OrderDataBase odb = new OrderDataBase("tmp.txt");

            odb.Add("吴昊", "苹果", 3);
            odb.Add("吴昊", "香蕉", 3);
            odb.Add("小凌", "橘子", 4);
            odb.Remove(customer: "小凌");

            odb.Save();
        }
        // */
    }
}