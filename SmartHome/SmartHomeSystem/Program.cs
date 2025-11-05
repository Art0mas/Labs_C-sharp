using System.Text;

namespace SmartHomeSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            SmartHomeController controller = new SmartHomeController();

            Light lamp = new Light();
            lamp.Name = "Лампа у вітальні";
            AirConditioner conditioner = new AirConditioner();
            conditioner.Name = "Кондиціонер у спальні";
            CoffeeMachine coffe_machine = new CoffeeMachine();
            coffe_machine.Name = "Кавомашина на кухні";
            MotionSensor sensor = new MotionSensor();
            sensor.Name = "Датчик руху у коридорі";
                    
            controller.AddDevice(lamp);
            controller.AddDevice(conditioner);
            controller.AddDevice(coffe_machine);
            controller.AddDevice(sensor);
            controller.AddEnergyDevice(lamp);
            controller.AddEnergyDevice(conditioner);
            controller.AddEnergyDevice(coffe_machine);

            controller.TurnAllOn();
            lamp.PrintStatus();
            conditioner.PrintStatus();
            coffe_machine.PrintStatus();
            sensor.PrintStatus();
            controller.ShowEnergyReport(5);
            controller.TurnAllOff();
        }
    }
}
