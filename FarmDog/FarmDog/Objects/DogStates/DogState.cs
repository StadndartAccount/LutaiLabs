using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmDog.Objects.DogStates
{
    public interface DogState
    {
        void GrowUp(Dog dog);
        void MorningActivity(Dog dog);
        void DayActivity(Dog dog);
        void EveningActivity(Dog dog);
    }
}
