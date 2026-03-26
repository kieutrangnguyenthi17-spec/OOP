using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event2
{
    // lop chua thong tin su kien ( nhiet do)
    public class TemperatureInfoEventArgs
    {
        public TemperatureInfoEventArgs(int tempt)
        {
            this.temperature = tempt;
        }
        public readonly int temperature; // readonly: phep gan gia tri o thoi diem runtime
    }
}
