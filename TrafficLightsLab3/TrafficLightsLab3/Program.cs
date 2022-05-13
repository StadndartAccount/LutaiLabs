using System;

/*
    Вариант 9. С помощью паттерна Состояние сделайте модель работы
    светофора с регулируемыми задержками переключения цвета. 
*/

namespace TrafficLightsLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            TrafficLightState state = new RedLight();
            TrafficLightContext context = new TrafficLightContext(state);

            context.Request(60); // Красный - 60 сек
            context.Request(40); // Зелёный - 40 сек
            context.Request(5); // Жёлтый - 5 сек
            context.Request(60); // Красный - 60 сек
            context.Request(40); // Зелёный - 40 сек
            context.Request(5); // Жёлтый - 5 сек
            context.Request(60); // Красный - 60 сек
        }
    }
}