using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmDog.Objects.Day;

namespace FarmDog.Objects
{
    public interface Observer
    {
        void handleEvent(DayState dayState);
    }
}
