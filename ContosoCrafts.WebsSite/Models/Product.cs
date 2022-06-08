using System.Text.Json;
using System.Text.Json.Serialization;

namespace ContosoCrafts.WebsSite.Models
{
    public class Product
    {
        public string? Id { get; set; }
        public string? Maker { get; set; }

        [JsonPropertyName("img")]
        public string? Image { get; set; }
        public string? Url { get; set; }
        public string? Title { get; set; }

        public string? Description { get; set; }
        public object? Ratings { get; internal set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);


    }
}
