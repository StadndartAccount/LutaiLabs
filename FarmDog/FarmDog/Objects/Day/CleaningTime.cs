using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmDog.Objects.Day
{
    class CleaningTime : DayState
    {
        public void Handle(DayContext context, List<Dog> dogs)
        {
            context.NotifyObservers(context.State);
            ConsoleOutput.getInstance().SendMessage($"=Уборка вольеров=");
            context.ChangeState(new WorkingTime());
        }
    }
}
