using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficLightsLab3
{
    abstract class TrafficLightState
    {
        public abstract void Handle(TrafficLightContext context, int delay);
    }
}
