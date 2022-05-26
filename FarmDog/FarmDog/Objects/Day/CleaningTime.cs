using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmDog.Objects.Day
{
    class CleaningTime : DayState
    {
        public void Handle(DayContext context, List<Dog> dogs)
        {
            dogs.ForEach((dog) =>
            {
                Service.getInstance().ClearCage(dog);
            });
            context.ChangeState(new WorkingTime());
        }
    }
}
