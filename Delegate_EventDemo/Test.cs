using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_EventDemo
{
    public class Test    // chạy clock từ cả 2 subscriber
    {
        static void Main(string[] args)
        {
            // create a new clock
            Clock theClock = new Clock();

            // create the display and tell it to
            // subscribe to the clock just created
            DisplayClock dc = new DisplayClock();
            dc.Subscribe(theClock);

            //create a Log object and tell it
            // to subscribe to the clock
            LogCurrentTime Ict = new LogCurrentTime();
            Ict.Subscribe(theClock);

            //get the clock started
            theClock.Run();

            Console.ReadKey();

        }
    }
}
// clock chạy --> gửi event OnSecondChange --> subscriber --> console 
// clock chạy --> gửi event OnSecondChange --> subscriber: DisplayClock & LogCurrentTime 
// -->consle "Current Time .... & Logging to file ...."