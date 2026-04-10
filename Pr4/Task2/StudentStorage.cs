using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Task2
{
    internal class StudentStorage
    {
        public string Save(List<Student> students)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            string json = JsonSerializer.Serialize(students, options);
            File.WriteAllText("Students.json", json);
            return json;
        }

        public List<Student>? Load()
        {
            if (File.Exists("Students.json"))
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                };
                string json = File.ReadAllText("Students.json");

                if (string.IsNullOrWhiteSpace(json)) return new List<Student>(); 

                List<Student>? students = JsonSerializer.Deserialize<List<Student>>(json, options);
                return students;

            }
            else
            {
                File.Create("Students.json");
                List<Student>? students = new List<Student>();
                return students;
            }
        }
    }
}
