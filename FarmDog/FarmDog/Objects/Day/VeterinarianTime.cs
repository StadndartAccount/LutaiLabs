using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmDog.Objects.Day
{
    class VeterinarianTime : DayState
    {
        public void Handle(DayContext context, List<Dog> dogs)
        {
            context.NotifyObservers(context.State);
            ConsoleOutput.getInstance().SendMessage($"=Осмотр у ветеринара=");
            context.ChangeState(new CleaningTime());
        }
    }
}
