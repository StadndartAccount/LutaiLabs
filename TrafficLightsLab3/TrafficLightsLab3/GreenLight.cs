using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficLightsLab3
{
    class GreenLight : TrafficLightState
    {
        public override void Handle(TrafficLightContext context, int delay)
        {
            Console.WriteLine($"Зелёный - {delay} секунд");
            context.ChangeState(new YellowLight());
        }
    }
}
