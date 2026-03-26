using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_EventDemo
{
    // an observer. DisplayClock subscribes to the
    // clock's events. The job of DisplayClock is 
    // to display the current time
    public class DisplayClock   // đăng kí sự kiện của clock = observers( subscribers)
    {
        //given a clock, subscribe to
        // its SecondChangeHandler(TimeHasChanged);
        public void Subscribe(Clock theClock)
        {
            theClock.OnSecondChange += new Clock.SecondChangeHandler(TimeHasChanged);
        }
        //the method that implements the
        // delegated functionality
        public void TimeHasChanged(     //phương thức riêng 
            object theClock, TimeInfoEventArgs ti)
        {
            Console.WriteLine("Current Time: {0}:{1}:{2}",
                ti.hour.ToString(),
                ti.minute.ToString(),
                ti.second.ToString());
        }
    }
}
