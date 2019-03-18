using System;

namespace OrderManager
{
    /* 
        Order类
        存储一条订单信息
     */
    public class Order
    {
        public string customer;     // 客户名
        public string commodity;    // 商品名
        public uint nums;   // 购买数额
        public ulong id;   // 订单编号 以创建订单时的 FileTime 表示

        // 构造函数
        public Order(string customer, string commodity, uint nums)
        {
            this.customer = customer;
            this.commodity = commodity;
            this.nums = nums;
            id = (ulong)DateTime.Now.ToFileTime();
        }

        // 从ToString()返回的格式解析
        public Order(string str)
        {
            string[] strs = str.Split('\t');
            this.id = Convert.ToUInt64(strs[0].Substring(1, strs[0].Length - 2));
            this.customer = strs[2];
            strs = strs[1].Split('x');
            this.commodity = strs[0];
            this.nums = Convert.ToUInt32(strs[1]);
        }

        override public string ToString()
        {
            return String.Format("[{0}]\t{1}x{2}\t{3}", id, commodity, nums, customer);
        }

        // 重载比较运算符
        public static bool operator ==(Order lhs, Order rhs)
        {
            if (lhs is null || rhs is null)
            {
                return lhs is null && rhs is null;
            }
            return lhs.id == rhs.id &&
                   lhs.nums == rhs.nums &&
                   lhs.customer == rhs.customer &&
                   lhs.commodity == rhs.commodity;
        }
        public static bool operator !=(Order lhs, Order rhs)
        {
            if (lhs is null || rhs is null)
            {
                return !(lhs is null && rhs is null);
            }
            return lhs.id != rhs.id ||
                   lhs.nums != rhs.nums ||
                   lhs.customer != rhs.customer ||
                   lhs.commodity != rhs.commodity;
        }
        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return this == (Order)obj;
        }
        // override object.GetHashCode
        public override int GetHashCode()
        {
            return (int)id; // 可以直接以id作为哈希值
        }

        /* 单元测试 通过
        public static void Main(string[] args)
        {
            Order o = new Order("吴昊", "西红柿", 2);
            string s = o.ToString();
            Order o2 = new Order(s);
            Console.WriteLine(o.id == o2.id);
            Console.WriteLine(o.nums == o2.nums);
            Console.WriteLine(o.customer == o2.customer);
            Console.WriteLine(o.commodity == o2.commodity);
            Console.WriteLine(o == o2);
            Console.WriteLine(o == null);
            Console.WriteLine(o);
            Console.WriteLine(o2);
        }
        //*/
    }
}