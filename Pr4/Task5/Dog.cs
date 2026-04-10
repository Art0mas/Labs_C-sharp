using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Task5
{
    
    internal class Dog: Animal
    {
        public int BarkVolume { get; set; }
    }
}
