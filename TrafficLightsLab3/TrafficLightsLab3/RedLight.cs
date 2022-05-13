using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficLightsLab3
{
    class RedLight : TrafficLightState
    {
        public override void Handle(TrafficLightContext context, int delay)
        {
            Console.WriteLine($"Красный - {delay} секунд");
            context.ChangeState(new GreenLight());
        }
    }
}
