using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaLab
{
    class Coffee : OrderDecorator
    {
        public int price = 200;

        public Coffee(Order product) : base(product)
        {
            order = product;
        }

        public override void Wrap()
        {
            Console.Write($"-> Coffee({price}) ");
            order.Wrap();
            FullPrice = order.FullPrice + price;
        }
    }
}
