using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmDog.Objects.DogStates
{
    class OldDog : DogState
    {
        public void MorningActivity(Dog dog)
        {
            ConsoleOutput.getInstance().SendMessage($"Старый пёс {dog.Name} съел 350 грамм корма");
            dog.EatFood();
        }

        public void DayActivity(Dog dog)
        {
            ConsoleOutput.getInstance().SendMessage($"Старый пёс {dog.Name} сидит в вольере");
        }

        public void EveningActivity(Dog dog)
        {
            ConsoleOutput Console = ConsoleOutput.getInstance();
            Console.SendMessage($"Старый пёс {dog.Name} лёг спать в вольере");
            dog.BecomeHungry();
            if (new Random().Next(100) > 80) return;

            dog.BecomeIll(); // с шансом 80% собака заболеет
            if (!dog.IsHealthy) Console.SendMessage($" -> Старый пёс {dog.Name} заболел  с шансом 80%");
        }

        public void GrowUp(Dog dog)
        {
            // 
        }
    }
}
