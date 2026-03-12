using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1
{
    public class Logger
    {
        public Action<string> LogHandler;

        public void Log(string message)
        {
            LogHandler?.Invoke(message);
        }
    }
}
