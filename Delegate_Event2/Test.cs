using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event2
{
    public class Test
    {
        public static void Main(string[] args)
        {
            Thermometer t = new Thermometer();
            DisplayThermometer dt = new DisplayThermometer();
            dt.Subscribe(t);

            LogTemperature It = new LogTemperature();
            It.Subscribe(t);

            t.Run();
        }
    }
}
