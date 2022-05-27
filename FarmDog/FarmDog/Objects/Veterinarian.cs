using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmDog.Objects;
using FarmDog.Objects.Day;

namespace FarmDog.Objects
{
    public class Veterinarian : Observer
    {
        public string Name { get; private set; }
        public Veterinarian(string name) {
            Name = name;
        }

        public void CheckDogsHealth(List<Dog> dogs)
        {
            ConsoleOutput console = ConsoleOutput.getInstance();

            foreach(Dog dog in dogs)
            {
                if (dog.IsHealthy)
                {
                    console.SendMessage($"Ветеринар {Name} осмотрел {dog.Name} и не нашёл заболеваний");
                    continue;
                }

                console.SendMessage($"Ветеринар {Name} осмотрел {dog.Name} и нашёл проблемы");
                CureDog(dog);
            }
        }

        public void CureDog(Dog dog)
        {
            ConsoleOutput console = ConsoleOutput.getInstance();
            dog.GetCured();

            console.SendMessage($" -> Ветеринар {Name} вылечил {dog.Name}");
        }

        public void handleEvent(DayState dayState)
        {
            if (dayState is VeterinarianTime)
            {
                CheckDogsHealth(MainForm.dogsToShow);
            }
        }
    }
}
