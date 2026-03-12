using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2_1
{
    internal class AirConditioner
    {
        private bool _isOnCooling { get; set; } = false;
        private bool _isOnHeating { get; set; } = false;
        private bool _isOff { get; set; } = true;
        public void AirConditionerOperation(object? sender, TemperatureEventArgs e)
        {
            if(e.Temperature < 17)
            {
                _isOnHeating = true;
                Console.WriteLine("Увiмкнено обiгрiв");
                return;
            }
            else if(e.Temperature >= 17 && e.Temperature <= 25)
            {
                _isOff = true;
                Console.WriteLine("Кондицiонер вимкнено");
                return;
            }
            else if (e.Temperature > 25)
            {
                _isOnCooling = true;
                Console.WriteLine("Увімкнено охолодження");
                return;
            }
            
        }
    }
}
