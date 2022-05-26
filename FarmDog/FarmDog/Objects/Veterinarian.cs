using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmDog.Objects;

namespace FarmDog.Objects
{
    public class Veterinarian
    {
        private static Veterinarian _instance = null;

        public string Name { get; private set; } = "Миша";
        private Veterinarian() { }

        public static Veterinarian getInstance()
        {
            if (_instance == null)
                _instance = new Veterinarian();
            return _instance;
        }
        public void CheckDogHealth(Dog dog)
        {
            ConsoleOutput console = ConsoleOutput.getInstance();
            if(dog.IsHealthy)
            {
                console.SendMessage($"Ветеринар {Name} осмотрел {dog.Name} и не нашёл заболеваний");
                return;
            }

            console.SendMessage($"Ветеринар {Name} осмотрел {dog.Name} и нашёл проблемы");
            CureDog(dog);
        }

        public void CureDog(Dog dog)
        {
            ConsoleOutput console = ConsoleOutput.getInstance();
            dog.GetCured();

            console.SendMessage($" -> Ветеринар {Name} вылечил {dog.Name}");
        }
    }
}
