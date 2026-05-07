using AsyncDataLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;

namespace AsyncDataLibrary.Infrastructure
{
    public class JsonDataSerializer : IDataSerializer
    {
        private JsonSerializerOptions _options;
        public JsonDataSerializer()
        {
            _options = new JsonSerializerOptions
            {
                WriteIndented = true, 
                PropertyNameCaseInsensitive = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
        }
        public async Task<T> DeserializeAsync<T>(Stream stream)
        {
            if (stream.Length == 0) return default;
            return await JsonSerializer.DeserializeAsync<T>(stream, _options);
        }

        public async Task SerializeAsync<T>(Stream stream, T data)
        {
            await JsonSerializer.SerializeAsync(stream, data, _options);
        }
    }
}
