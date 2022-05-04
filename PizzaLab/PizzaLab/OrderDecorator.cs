using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaLab
{
    class OrderDecorator : Order
    {
        public Order order;

        public OrderDecorator(Order product)
        {
            order = product;
        }

        public override void Wrap()
        {
            order.Wrap();
            FullPrice = order.FullPrice;
        }
    }
}
