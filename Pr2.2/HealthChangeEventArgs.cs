using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Pr2._2
{
    internal class HealthChangeEventArgs: EventArgs
    {
        public int CurrentHealth {  get; set; }
        public int Damage {  get; set; }
    }
}
