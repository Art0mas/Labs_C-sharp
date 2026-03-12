using System.Text;
using System.Threading.Channels;

namespace Pr2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var sensor = new TemperatureSensor();
            var display = new Display();
            var airConditioner = new AirConditioner();
            var securitySystem = new SecuritySystem();

            sensor.TemperatureChanged += display.DisplayTemperature;
            sensor.TemperatureChanged += airConditioner.AirConditionerOperation;
            sensor.TemperatureChanged += securitySystem.SecuritySystemMessage;

            sensor.GetTemperature(46);
            sensor.GetTemperature(15);
            sensor.GetTemperature(1);

            sensor.TemperatureChanged -= display.DisplayTemperature;
            sensor.TemperatureChanged -= airConditioner.AirConditionerOperation;
            sensor.TemperatureChanged -= securitySystem.SecuritySystemMessage;
        }
    }
}
