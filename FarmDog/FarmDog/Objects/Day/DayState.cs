using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmDog.Objects.Day
{
    interface DayState
    {
        void Handle(DayContext context, List<Dog> dogs);
    }
}
