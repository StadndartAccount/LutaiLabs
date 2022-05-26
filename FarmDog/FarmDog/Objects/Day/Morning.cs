using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmDog.Objects.Day
{
    class Morning : DayState
    {
        public void Handle(DayContext context, List<Dog> dogs)
        {
            dogs.ForEach((dog) =>
            {
                dog.State.MorningActivity(dog);
            });
            context.ChangeState(new VeterinarianTime());
        }
    }
}
