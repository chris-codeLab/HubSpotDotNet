using System.Text.Json;
using System.Text.Json.Serialization;

namespace HubSpotDotNet.Models;

public class HubSpotResult
{
    [JsonPropertyName("id")] public required string Id { get; set; }
    [JsonPropertyName("properties")] public required Dictionary<string, JsonElement> Properties { get; set; }
}