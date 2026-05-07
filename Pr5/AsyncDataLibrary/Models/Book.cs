using AsyncDataLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AsyncDataLibrary.Models
{
    public class Book: IEntity
    {
        [JsonPropertyName("book_id")]
        public int Id { get; set; }
        [JsonPropertyName("book_name")]
        public string? Name { get; set; }
        [JsonPropertyName("book_author")]
        public string? Author { get; set; }
    }
}
