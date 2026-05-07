using AsyncDataLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AsyncDataLibrary.Models
{
    public class Order: IEntity
    {
        [JsonPropertyName("order_id")]
        public int Id { get; set; }

        [JsonPropertyName("user_id")]
        public int UserId { get; set; }

        [JsonPropertyName("book_ids")]
        public List<int>? BookIds { get; set; }

        [JsonPropertyName("price")]
        public decimal Price { get; set; }
    }
}
