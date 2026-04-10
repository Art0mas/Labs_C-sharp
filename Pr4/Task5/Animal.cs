using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Task5
{

    [JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
    [JsonDerivedType(typeof(Cat), "cat")]
    [JsonDerivedType(typeof(Dog), "dog")]
    abstract class Animal
    {
        public string Name { get; set; }
    }
}
