using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Task8
{
    internal class PlayerStorage
    {
        public string Save(Player player)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            string json = JsonSerializer.Serialize(player, options);
            File.WriteAllText("Player.json", json);
            return json;
        }
        public Player Load()
        {
            
            if (File.Exists("Player.json"))
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                };
                try
                {
                    string json = File.ReadAllText("Player.json");
                    Player? player = JsonSerializer.Deserialize<Player>(json, options);
                    return player ?? new Player(); 
                }
                catch (JsonException)
                {
                    Console.WriteLine("Помилка: Файл збереження пошкоджено! Перевірте правильність формату JSON.");
                    return new Player();
                }
            }
            else
            {
                return new Player();
            }

        }
    }
}
