using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    enum OrderStatus
    {
        Pending,
        Processing,
        Completed
    }
    internal class Order
    {
        public int Id { get; set; }
        public OrderStatus Status { get; set; } 
    }
}
