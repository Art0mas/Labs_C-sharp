using AsyncDataLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AsyncDataLibrary.Models
{
    public class User: IEntity
    {
        [JsonPropertyName("user_id")]
        public int Id { get; set; }
        [JsonPropertyName("user_name")]
        public string? Name { get; set; }
    }
}
