using System.Text.Json.Serialization;

namespace HubSpotDotNet.Models;

public class SearchRequestFilter
{
    [JsonPropertyName("propertyName")] public required string PropertyName { get; set; }
    [JsonPropertyName("value")] public required string Value { get; set; }
    [JsonPropertyName("operator")] public required string Operator { get; set; }
}