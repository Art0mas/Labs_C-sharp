using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Task1
{
    internal class TaskStorage
    {
        public string Save(List<TaskItem> tasks)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            string json = JsonSerializer.Serialize(tasks, options);
            File.WriteAllText("taskItem.json", json);
            return json;
        }

        public List<TaskItem>? Load()
        {
            if (File.Exists("taskItem.json"))
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                };
                string json = File.ReadAllText("taskItem.json");
                List<TaskItem>? tasks = JsonSerializer.Deserialize<List<TaskItem>>(json, options);
                return tasks;

            }
            else
            {
                return null;
            }
        }
        
    }
}
