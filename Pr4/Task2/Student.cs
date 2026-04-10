using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Task2
{
    internal class Student
    {
        public string? Name { get; set; }
        public int Age { get; set; }

        [JsonPropertyName("avg")]
        public double AverageScore { get; set; }
    }
}
