using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmDog.Objects.Day;
using FarmDog.Objects.DogStates;

namespace FarmDog.Objects
{
    public class Dog : Observer
    {
        public const int MAX_YOUNG_AGE = 2;
        public const int MAX_ADULT_AGE = 8;
        public const int MAX_OLD_AGE = 13;

        public Dog(string name, int age, bool isHungry, bool isHealthy) {
            Name = name;
            Age = age;

            if(Age <= MAX_YOUNG_AGE)
            {
                State = new YoungDog();
                IsTrained = false;
            } 
            else if (Age <= MAX_ADULT_AGE)
            {
                State = new AdultDog();
                IsTrained = true;
            } 
            else
            {
                State = new OldDog();
                IsTrained = true;
            }

            IsHealthy = isHealthy;
            IsFed = isHungry;
        }

        public DogState State { get; private set; } = new YoungDog();
        
        public string Name { get; }
        public int Age { get; private set; } = 0;

        public bool IsHealthy { get; private set; } = true;
        public bool IsFed { get; private set; } = true;
        public bool IsTrained { get; set; } = false;

        public void GetCured()
        {
            IsHealthy = true;
        }

        public void BecomeIll()
        {
            IsHealthy = false;
        }

        public void BecomeTrained()
        {
            IsTrained = true;
        }

        public void EatFood()
        {
            IsFed = true;
        }

        public void BecomeHungry()
        {
            IsFed = false;
        }

        public void GrowUp()
        {
            Age++;
        }

        public void ChangeState(DogState state)
        {
            State = state;
        }

        public void handleEvent(DayState dayState)
        {
            if(dayState is Morning)
            {
                State.MorningActivity(this);
            }

            if (dayState is WorkingTime)
            {
                State.DayActivity(this);
            }

            if (dayState is Evening)
            {
                State.EveningActivity(this);
                State.GrowUp(this);
            }
        }

        public override string ToString() {
            return $"{Name} Возраст: {Age, -2} | Накормлен {(IsFed ? "+" : "-")} |" +
            $" Здоров {(IsHealthy ? "+" : "-")} |" +
            $" Дрессирован {(IsTrained ? "+" : "-")} |";
        }
    }
}
