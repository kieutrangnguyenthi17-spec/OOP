using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegate_Event2
{
    //Chu the phat su kien: Nhiet ke
    public class Thermometer
    {
        //khai bao delegate
        public delegate void TemperatureChangeHandler(
            object sender, TemperatureInfoEventArgs e);
        //khai bao event
        public event TemperatureChangeHandler OnTemperatureChange;
        private int currentTemp = 25;
        public void Run()
        {
            Random rnd = new Random();
            for(; ; )
            {
                Thread.Sleep(1000); //1 giay
                int newTemp = rnd.Next(20, 40);

                if (newTemp != currentTemp)
                {
                    TemperatureInfoEventArgs e = new TemperatureInfoEventArgs(newTemp);
                    if(OnTemperatureChange != null)
                    {
                        OnTemperatureChange(this, e);
                    }
                    currentTemp = newTemp;
                }
            }
        }
    }
}
