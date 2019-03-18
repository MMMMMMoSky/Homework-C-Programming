using System;
using System.Collections.Generic;

namespace OrderManager
{
    /*
      订单数据管理者
      提供用户接口
      支持: 添加, 删除, 修改, 查询订单
     */
    public class OrderManager 
    {
        private OrderDataBase db;

        public OrderManager(string filename = "orderdata.txt")
        {
            db = new OrderDataBase(filename);
        }

        // 添加一条订单, 订单号自动生成
        // 商品数量不能为0
        public void Add(string customer, string commodity, uint nums)
        {
            if (nums == 0)
            {
                Console.WriteLine("Failed: nums can not be zero.");
            }
            else
            {
                Order o = new Order(customer, commodity, nums);
                db.Add(o);
                Console.WriteLine("Ok: ++{0}++ added.", o);
            }
        }

        public void Remove(ulong id = 0, string customer = null, string commodity = null, uint nums = 0)
        {
            List<Order> list = db.Remove(id, customer, commodity, nums);
            Console.WriteLine("Ok:");
            foreach (Order o in list)
            {
                Console.WriteLine(" --{0}-- removed.", o);
            }
        }

        public void Find(ulong id = 0, string customer = null, string commodity = null, uint nums = 0)
        {
            List<Order> list = db.Find(id, customer, commodity, nums);
            if (list.Count == 0)
            {
                Console.WriteLine("No such order.");
                return ;
            }
            else
            {
                foreach (Order o in list)
                {
                    Console.WriteLine(o);
                }
            }
        }

        // 给定id, 修改其他信息
        public void Update(ulong id, string customer = null, string commodity = null, uint nums = 0)
        {
            List<Order> list = db.Find(id);
            if (list.Count == 0)
            {
                Console.WriteLine("Failed: No such order.");
            }
            else
            {
                Order o = list[0];
                db.Remove(id);
                o.nums = nums == 0 ? o.nums : nums;
                o.customer = customer == null ? o.customer : customer;
                o.commodity = commodity == null ? o.commodity : commodity;
                db.Add(o);
                Console.WriteLine("Ok: {0}", o);
            }
        }

        public void Save()
        {
            db.Save();
        }
    }
}