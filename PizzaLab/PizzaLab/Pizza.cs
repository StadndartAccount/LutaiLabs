using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaLab
{
    class Pizza : Order
    {
        public int price = 500;

        public override void Wrap()
        {
            FullPrice = price;
            Console.Write($"-> Pizza({price}) ");
        }
    }
}
