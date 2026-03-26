using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_EventDemo
{
    // a class to hold the information about the event
    // in this case it will hold only information
    // available in the clock class, but could hold
    // additional state information
    public class TimeInfoEventArgs : EventArgs     // giờ-phút-giây hiện tại
    {
        public TimeInfoEventArgs( int hour, int minute, int second)
        {
            this.hour=hour;
            this.minute=minute;
            this.second=second;
        }
        public readonly int hour;
        public readonly int minute;
        public readonly int second;
    }
}
 