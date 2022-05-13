using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaLab
{
    class Salad : OrderDecorator
    {
        public int price = 250;

        public Salad(Order product) : base(product)
        {
            order = product;
        }

        public override void Wrap()
        {
            Console.Write($"-> Salad({price}) ");
            order.Wrap();
            FullPrice = order.FullPrice + price;
        }
    }
}
