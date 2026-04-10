using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Task7
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

                string json = File.ReadAllText("Player.json");
                Player? player = JsonSerializer.Deserialize<Player>(json, options);
                return player;
            }
            else
            {
                return null;
            }
        }
    }
}
