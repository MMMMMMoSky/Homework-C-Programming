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
    public partial class NewDetail : Form
    {
        Order order;
        NewOrder.AddOrderDelegate addOrder;

        public NewDetail()
        {
            InitializeComponent();
        }

        public NewDetail(Order order, NewOrder.AddOrderDelegate addOrder)
        {
            this.order = order;
            this.addOrder = addOrder;
            InitializeComponent();
        }

        private void NewDetail_Load(object sender, EventArgs e)
        {

        }

        private OrderDetail GetOrderDetailFromTextBox()
        {
            uint id = Convert.ToUInt32(this.GoodID.Text);
            string name = this.GoodName.Text;
            float price = Convert.ToSingle(this.GoodPrice.Text);
            uint count = Convert.ToUInt32(this.GoodCount.Text);
            OrderDetail orderDetail = new OrderDetail();
            orderDetail.Goods = new Goods(id, name, price);
            orderDetail.Quantity = count;
            return orderDetail;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            order.AddDetails(GetOrderDetailFromTextBox());
            NewDetail newDetailForm = new NewDetail(order, addOrder);
            newDetailForm.Show();
            this.Close(); 
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            order.AddDetails(GetOrderDetailFromTextBox());
            addOrder(order);
            this.Close();
        }
    }
}
