using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmDog.Objects.Day
{
    class VeterinarianTime : DayState
    {
        public void Handle(DayContext context, List<Dog> dogs)
        {
            dogs.ForEach((dog) =>
            {
                Veterinarian.getInstance().CheckDogHealth(dog);
            });
            context.ChangeState(new CleaningTime());
        }
    }
}
