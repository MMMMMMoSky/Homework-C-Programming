using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OrderService
{
    /// <summary>
    /// OrderService:provide ordering service,
    /// like add order, remove order, query order and so on
    /// 实现添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户等字段进行查询)
    /// </summary>
    public class OrderService
    {

        private List<Order> orderList;
        /// <summary>
        /// OrderService constructor
        /// </summary>
        public OrderService()
        {
            orderList = new List<Order>();
        }

        /// <summary>
        /// add new order
        /// </summary>
        /// <param name="order">the order will be added</param>
        public void AddOrder(Order order)
        {
            foreach (Order o in orderList)
            {
                if (o.Id.Equals(order.Id))
                {
                    throw new Exception($"order-{order.Id} is already existed!");
                }
            }
            orderList.Add(order);
        }

        /// <summary>
        /// query by orderId
        /// </summary>
        /// <param name="orderId">id of the order to find</param>
        /// <returns>List<Order></returns> 
        public Order GetById(uint orderId)
        {
            foreach (Order o in orderList)
            {
                if (o.Id == orderId)
                {
                    return o;
                }
            }
            return null;
        }

        /// <summary>
        /// remove order
        /// </summary>
        /// <param name="orderId">id of the order which will be removed</param> 
        public void RemoveOrder(uint orderId)
        {
            Order order = GetById(orderId);
            if (order == null) return;
            orderList.Remove(order);
        }

        /// <summary>
        /// query all orders
        /// </summary>
        /// <returns>List<Order>:all the orders</returns> 
        public List<Order> QueryAllOrders()
        {
            return orderList;
        }


        /// <summary>
        /// query by goodsName
        /// </summary>
        /// <param name="goodsName">the name of goods in order's orderDetail</param>
        /// <returns></returns> 
        public List<Order> QueryByGoodsName(string goodsName)
        {
            var query = orderList.Where(
                order =>
                {
                    var subquery = from detail in order.Details
                                   where detail.Goods.Name == goodsName
                                   select detail;
                    return subquery.Count() > 0;
                }
            );
            List<Order> result = query.ToList();
            return result;
        }

        /// <summary>
        /// query by customerName
        /// </summary>
        /// <param name="customerName">customer name</param>
        /// <returns></returns> 
        public List<Order> QueryByCustomerName(string customerName)
        {
            var query = orderList
                .Where(order => order.Customer.Name == customerName);
            return query.ToList();
        }

        /// <summary>
        /// sort orderList by Order.Id
        /// </summary>
        public void SortById()
        {
            orderList.Sort();
        }

        /// <summary>
        /// export to xml file
        /// </summary>
        /// <param name="filepath">absolute path or relative path</param?>
        /// <returns>bool: succeed or not</returns>
        public bool ExportToXml(string filePath)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    xmlSerializer.Serialize(fs, orderList);
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        /// <summary>
        /// import from xml file
        /// </summary>
        /// <param name="filepath">absolute path or relative path</param?>
        /// <returns>bool: succeed or not</returns>
        public bool ImportFromXml(string filePath)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    orderList = (List<Order>)xmlSerializer.Deserialize(fs);
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
