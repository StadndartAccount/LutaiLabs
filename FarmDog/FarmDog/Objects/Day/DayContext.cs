using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmDog.Objects.Day
{
    class DayContext
    {
        public DayState State { get; private set; }

        public DayContext()
        {
            State = new Morning();
        }

        public void Request(List<Dog> dogs)
        {
            State.Handle(this, dogs);
        }

        public void ChangeState(DayState state)
        {
            State = state;
        }
    }
}
