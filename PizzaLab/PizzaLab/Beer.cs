using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaLab
{
    class Beer : OrderDecorator
    {
        public int price = 300;

        public Beer(Order product) : base(product)
        {
            order = product;
        }

        public override void Wrap()
        {
            Console.Write($"-> Beer({price}) ");
            order.Wrap();
            FullPrice = order.FullPrice + price;
        }
    }
}
