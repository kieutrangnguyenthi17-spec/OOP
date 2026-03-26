using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event2
{
    //observer: ghi log nhiet do
    public class LogTemperature
    {
        public void Subscribe(Thermometer t)
        {
            t.OnTemperatureChange += new Thermometer.TemperatureChangeHandler(WriteLog);
        }
        public void WriteLog(object sender, TemperatureInfoEventArgs e)
        {
            Console.WriteLine("Ghi log: {0}°C", e.temperature);
        }
    }
}
