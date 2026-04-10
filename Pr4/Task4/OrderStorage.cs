using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Task4
{
    internal class OrderStorage
    {
        public string Save(Order order)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                Converters = { new JsonStringEnumConverter() }
            };
            string json = JsonSerializer.Serialize(order, options);
            File.WriteAllText("Order.json", json);
            return json;
        }
        public Order Load()
        {
            if (File.Exists("Order.json"))
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                    Converters = { new JsonStringEnumConverter() }
                };
                string json = File.ReadAllText("Order.json");
                Order? order = JsonSerializer.Deserialize<Order>(json, options);
                return order;
            }
            else
            {
                return null;
            }
        }
    }
}
