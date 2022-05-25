using System;

/*
    6 вариант В пиццерии главное блюдо – пицца, но с ней можно заказать салат,
    лимонад, кофе, пиво. Назначив цену каждому продукту, подсчитайте
    стоимость заказа с различными составляющими, использовав для этой цели
    Декоратор. 
*/

namespace PizzaLab
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderDecorator decorator = new OrderDecorator(new Pizza());
            decorator.Wrap();
            Console.WriteLine();
            Console.WriteLine($"Цена заказа: {decorator.FullPrice}");
            Console.WriteLine();

            OrderDecorator decorator1 = new Salad(new Beer(new Pizza()));
            decorator1.Wrap();
            Console.WriteLine();
            Console.WriteLine($"Цена заказа: {decorator1.FullPrice}");
            Console.WriteLine();

            OrderDecorator decorator2 = new Salad(new Coffee(new Lemonade(new Beer(new Pizza()))));
            decorator2.Wrap();
            Console.WriteLine();
            Console.WriteLine($"Цена заказа: {decorator2.FullPrice}");
            Console.WriteLine();
        }
    }
}
