using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem
{

    public class SmartHomeController
    {
        private List<ISwitchable> _devices = new List<ISwitchable>();
        private List<IEnergyConsumer> _energy_devices = new List<IEnergyConsumer>();

        public void AddDevice(ISwitchable device)
        {
            _devices.Add(device);
        }
        public void AddEnergyDevice(IEnergyConsumer device)
        {
            _energy_devices.Add(device);
        }
        public void TurnAllOn()
        {
            foreach(var device in _devices)
            {
                device.TurnOn();
            }
            Console.WriteLine();
        }
        public void TurnAllOff()
        {
            foreach (var device in _devices)
            {
                device.TurnOff();
            }
            Console.WriteLine();
        }
        public void ShowEnergyReport(int hours)
        {
            Console.WriteLine();
            double totalEnergyUsage = 0;
            Console.WriteLine($"Звіт про споживання енергії за {hours} год:");
            foreach (var device in _energy_devices)
            {
                double usage = device.GetEnergyUsage(hours);
                totalEnergyUsage += usage;
                Console.WriteLine($"{device.DeviceName}: {usage:F2} кВт·год (потужність: {device.PowerConsumption} Вт)");
            }
            Console.WriteLine($"Загальне споживання: {totalEnergyUsage:F2} кВт·год\n" +
                              $"Вартість (~4 грн/кВт·год): {totalEnergyUsage * 4:F2} грн");
            Console.WriteLine();
        }

    }
}
