using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2_1
{
    internal class TemperatureSensor
    {
        public event EventHandler<TemperatureEventArgs>? TemperatureChanged;
        private int _temperature;

        public void GetTemperature(int temperature)
        {
            _temperature = temperature;
            TemperatureChanged?.Invoke(this, new TemperatureEventArgs { Temperature = _temperature });
        }
    }
}
