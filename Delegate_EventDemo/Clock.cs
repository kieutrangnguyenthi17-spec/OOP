using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegate_EventDemo
{
    //our subject -- it is this class that other classes
    //will observe. This class publishes one event:
    //OnSecondchange. The observers subscribe to that event
    public class Clock       //đối tượng phát đi sự kiện = subject(publisher)
    {
        // the delegate the subscribers must implement
        public delegate void SecondChangeHandler
        (object clock, TimeInfoEventArgs timeInformation); // chứa giờ phút giây hiện tại
        //the event we publish
        public event SecondChangeHandler OnSecondChange;
        //set the clock running
        //it will raise an event for each new second
        public void Run()
        {
            for (; ; )
            {
                // sleep 10 milliseconds
                Thread.Sleep(10);
                // get the current time
                System.DateTime dt = System.DateTime.Now;
                // if the second has changed
                // notify the subscribers
                if(dt.Second != second)
                {
                    //create the TimeInfoEventArgs object
                    //to pass to the subscriber
                    TimeInfoEventArgs timeInfoEventArgs = new TimeInfoEventArgs(dt.Hour, dt.Minute, dt.Second);
                    //if anyone has subscribed, notify them
                    if (OnSecondChange != null)
                    {
                        OnSecondChange(this, timeInfoEventArgs);
                    }
                }
                // update the state
                this.second = dt.Second;
                this.minute = dt.Minute;
                this.hour = dt.Hour;
            }
        }
        private int hour;
        private int minute;
        private int second;
      
    }
}
