using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficLightsLab3
{
    class YellowLight : TrafficLightState
    {
        public override void Handle(TrafficLightContext context, int delay)
        {
            Console.WriteLine($"Жёлтый - {delay} секунд");
            context.ChangeState(new RedLight());
        }
    }
}
