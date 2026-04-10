using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Task3
{
    internal class AuthorStorage
    {
        public string Save(Author author)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                ReferenceHandler = ReferenceHandler.IgnoreCycles
            };
            string json = JsonSerializer.Serialize(author, options);
            File.WriteAllText("Author.json", json);
            return json;
        }
        public Author Load()
        {
            if (File.Exists("Author.json"))
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                    ReferenceHandler = ReferenceHandler.IgnoreCycles
                };
                string json = File.ReadAllText("Author.json");
                Author? author = JsonSerializer.Deserialize<Author>(json, options);
                return author;
            }
            else
            {
                return null;
            }
        }

    }
}
