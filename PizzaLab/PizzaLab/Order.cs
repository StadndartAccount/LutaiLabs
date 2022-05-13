using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaLab
{
    abstract class Order
    {
        public int FullPrice = 0;
        public abstract void Wrap();
    }
}
