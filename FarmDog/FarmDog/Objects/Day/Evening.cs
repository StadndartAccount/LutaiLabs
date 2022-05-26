using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmDog.Objects.Day
{
    class Evening : DayState
    {
        public void Handle(DayContext context, List<Dog> dogs)
        {
            dogs.ForEach((dog) =>
            {
                dog.State.EveningActivity(dog);
                dog.GrowUp();
            });

            context.ChangeState(new Morning());
        }
    }
}
