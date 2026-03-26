using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event2
{
    //observer: hien thi nhiet do
    public class DisplayThermometer
    {
        public void Subscribe(Thermometer t)
        {
            t.OnTemperatureChange += new Thermometer.TemperatureChangeHandler(ShowTemperature);
        }
        public void ShowTemperature(object sender, TemperatureInfoEventArgs e)
        {
            Console.WriteLine("Nhiet do hien tai: {0}°C, e.temperature");
        }
    }
}
