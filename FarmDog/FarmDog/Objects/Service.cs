using FarmDog.Objects.Day;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmDog.Objects
{
    public class Service : Observer
    {
        public string Name { get; private set; }
        public Service(string name)
        {
            Name = name;
        }

        public void ClearDogsCages(List<Dog> dogs)
        {
            foreach(Dog dog in dogs)
            {
                ConsoleOutput.getInstance().SendMessage($"Работник {Name} помыл вольер {dog.Name}");
                dog.IsClearedCage = true;
            }
        }

        public void handleEvent(DayState dayState)
        {
            if(dayState is CleaningTime)
            {
                ClearDogsCages(MainForm.dogsToShow);
            }
        }
    }
}
