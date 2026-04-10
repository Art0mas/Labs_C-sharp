using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Task5
{
    internal class AnimalStorage
    {
        public string Save(List<Animal> animals)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            string json = JsonSerializer.Serialize(animals, options);
            File.WriteAllText("Animal.json", json);
            return json;
        }
        public List<Animal> Load()
        {
            if (File.Exists("Animal.json"))
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                };
                string json = File.ReadAllText("Animal.json");
                List<Animal>? animals = JsonSerializer.Deserialize<List<Animal>>(json, options);
                return animals;
            }
            else
            {
                return null;
            }
        }
    }
}
