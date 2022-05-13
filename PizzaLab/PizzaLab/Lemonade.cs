using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaLab
{
    class Lemonade : OrderDecorator
    {
        public int price = 150;

        public Lemonade(Order product) : base(product)
        {
            order = product;
        }

        public override void Wrap()
        {
            Console.Write($"-> Lemonade({price}) ");
            order.Wrap();
            FullPrice = order.FullPrice + price;
        }
    }
}
