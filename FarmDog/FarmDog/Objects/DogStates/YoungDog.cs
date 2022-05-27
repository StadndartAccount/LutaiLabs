using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmDog.Objects.DogStates
{
    class YoungDog : DogState
    {
        public void MorningActivity(Dog dog)
        {
            ConsoleOutput.getInstance().SendMessage($"Молодой пёс {dog.Name} съел 200 грамм корма");
            dog.EatFood();
        }
        public void DayActivity(Dog dog)
        {
            ConsoleOutput.getInstance().SendMessage($"Молодой пёс {dog.Name} тренируется");
        }

        public void EveningActivity(Dog dog)
        {
            ConsoleOutput Console = ConsoleOutput.getInstance();
            Console.SendMessage($"Молодой пёс {dog.Name} лёг спать после тренировки");
            dog.BecomeHungry();
            if (new Random().Next(100) > 20) return;

            dog.BecomeIll(); // с шансом 20% собака заболеет
            if (!dog.IsHealthy) Console.SendMessage($"-> Молодой пёс {dog.Name} заболел с шансом 20%");
        }

        public void GrowUp(Dog dog)
        {
            dog.GrowUp();
            if (dog.Age <= Dog.MAX_YOUNG_AGE) return;

            ConsoleOutput.getInstance().SendMessage($" -> {dog.Name} вырос до взрослого пса");
            dog.BecomeTrained();
            dog.ChangeState(new AdultDog());
        }
    }
}
