using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmDog.Objects.Day
{
    public class DayContext : Observed
    {
        public DayState State { get; private set; }

        List<Observer> subscribers = new List<Observer>();

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

        public void AddObserver(Observer observer)
        {
            subscribers.Add(observer);
        }

        public void RemoveObserver(Observer observer)
        {
            subscribers.Remove(observer);
        }

        public void NotifyObservers(DayState dayState)
        {
            if (subscribers.Count == 0) return;
        
            foreach(Observer subscriber in subscribers)
            {
                subscriber.handleEvent(dayState);
            }
        }
    }
}
