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
    public partial class NewOrder : Form
    {
        public delegate void AddOrderDelegate(Order order);
        AddOrderDelegate addOrder;

        public NewOrder()
        {
            InitializeComponent();
        }

        public NewOrder(AddOrderDelegate addOrder)
        {
            InitializeComponent();
            this.addOrder = addOrder;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            Order order = new Order();
            order.Id = Convert.ToInt32(this.OrderID.Text);
            order.Customer = new Customer(
                Convert.ToUInt32(this.CustomerID.Text),
                this.CustomerName.Text);
            NewDetail newDetailForm = new NewDetail(order, addOrder);
            newDetailForm.Show();
            this.Close();
        }
    }
}
