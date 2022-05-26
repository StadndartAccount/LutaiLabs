using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmDog.Objects
{
    public class Service
    {
        private static Service _instance = null;

        public string Name { get; private set; } = "Никита";
        private Service() { }

        public static Service getInstance()
        {
            if (_instance == null)
                _instance = new Service();
            return _instance;
        }

        public void ClearCage(Dog dog)
        {
            ConsoleOutput.getInstance().SendMessage($"Работник {Name} помыл вольер {dog.Name}");
        }
    }
}
