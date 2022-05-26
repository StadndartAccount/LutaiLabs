using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmDog.classes.DogStates;

namespace FarmDog.classes
{
    class Dog
    {
        const int MAX_YOUNG_AGE = 2;
        const int MAX_ADULT_AGE = 8;
        const int MAX_OLD_AGE = 13;

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
            else if (Age <= MAX_OLD_AGE)
            {
                State = new OldDog();
                IsTrained = true;
            }

            IsHealthy = isHealthy;
            IsHungry = isHungry;
        }

        public DogState State { get; } = new YoungDog();
        
        public string Name { get; }
        public int Age { get; } = 0;

        public bool IsHealthy { get; } = true;
        public bool IsHungry { get; } = true;
        public bool IsTrained { get; } = false;
    }
}
