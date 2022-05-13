using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficLightsLab3
{
    class TrafficLightContext
    {
        public TrafficLightState state;

        public TrafficLightContext(TrafficLightState state)
        {
            this.state = state;
        }

        public void Request(int delay)
        {
            if (state != null) state.Handle(this, delay);
        }

        public void ChangeState(TrafficLightState state)
        {
            this.state = state;
        }
    }
}
