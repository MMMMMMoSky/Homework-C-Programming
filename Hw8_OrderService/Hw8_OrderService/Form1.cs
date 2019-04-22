using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ordertest;

namespace Hw8_OrderService
{
    public partial class OrderServiceForm : System.Windows.Forms.Form
    {

        private string[] queryType = { "ALL", "By ID",
            "By Customer Name",
            "By Goods Name",
            "By Total Amount" };

        private OrderService orderService;

        public OrderServiceForm()
        {
            InitializeComponent();
            this.QueryBy.DataSource = queryType;
            this.QueryBy.SelectedIndex = 0;

            Customer customer1 = new Customer(1, "Customer1");
            Customer customer2 = new Customer(2, "Customer2");

            Goods milk = new Goods(1, "Milk", 69.9f);
            Goods eggs = new Goods(2, "eggs", 4.99f);
            Goods apple = new Goods(3, "apple", 5.59f);

            Order order1 = new Order(1, customer1);
            order1.AddDetails(new OrderDetail(apple, 8));
            order1.AddDetails(new OrderDetail(eggs, 10));
            order1.AddDetails(new OrderDetail(milk, 10));

            Order order2 = new Order(2, customer2);
            order2.AddDetails(new OrderDetail(eggs, 10));
            order2.AddDetails(new OrderDetail(milk, 10));

            Order order3 = new Order(3, customer2);
            order3.AddDetails(new OrderDetail(milk, 100));

            orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void QueryBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void QueryButton_Click(object sender, EventArgs e)
        {
            List<Order> res;
            switch (this.QueryBy.SelectedIndex)
            {
                case 0: res = orderService.QueryAll(); break;
                case 1:
                    res = new List<Order>();
                    res.Add(orderService.GetById(Convert.ToInt32(this.QueryContent.Text)));
                    break;
                case 2:
                    res = orderService.QueryByCustomerName(this.QueryContent.Text);
                    break;
                case 3:
                    res = orderService.QueryByGoodsName(this.QueryContent.Text);
                    break;
                case 4:
                    res = orderService.QueryByTotalAmount((float)Convert.ToDouble(this.QueryContent.Text));
                    break;
                default: res = new List<Order>(); break;
            }
            this.orderBindingSource.DataSource = res;
        }

        private void QueryResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
