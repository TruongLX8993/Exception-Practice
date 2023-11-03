using System.Text.Json.Serialization;

namespace Application;

public class CreateProductRequest
{
    [JsonPropertyName("name")] public string Name { get; set; }
    [JsonPropertyName("code")] public string Code { get; set; }
    [JsonPropertyName("price")] public decimal Price { get; set; }
}