using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmDog.Objects.Day
{
    public interface Observed
    {
        void AddObserver(Observer observer);
        void RemoveObserver(Observer observer);
        void NotifyObservers(DayState dayState);
    }
}
