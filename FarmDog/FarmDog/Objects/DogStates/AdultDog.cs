using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmDog.Objects.DogStates
{
    class AdultDog : DogState
    {
        public void MorningActivity(Dog dog)
        {
            ConsoleOutput.getInstance().SendMessage($"Взрослый пёс {dog.Name} съел 500 грамм корма");
            dog.EatFood();
        }

        public void DayActivity(Dog dog)
        {
            ConsoleOutput.getInstance().SendMessage($"Взрослый пёс {dog.Name} отправился на работу");
        }

        public void EveningActivity(Dog dog)
        {
            ConsoleOutput Console = ConsoleOutput.getInstance();

            ConsoleOutput.getInstance().SendMessage($"Взрослый пёс {dog.Name} лёг спать после работы");
            dog.BecomeHungry();
            if (new Random().Next(100) > 40) return;
            
            dog.BecomeIll(); // с шансом 40% собака заболеет
            if (!dog.IsHealthy) Console.SendMessage($" -> Взрослый пёс {dog.Name} заболел с шансом 40%");

        }

        public void GrowUp(Dog dog)
        {
            dog.GrowUp();

            if (dog.Age <= Dog.MAX_ADULT_AGE) return;
            
            ConsoleOutput.getInstance().SendMessage($" -> {dog.Name} вырос до старого пса");
            dog.ChangeState(new OldDog());
        }
    }
}
