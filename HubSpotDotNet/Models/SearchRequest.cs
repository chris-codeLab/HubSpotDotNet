using System.Text.Json.Serialization;

namespace HubSpotDotNet.Models;

public class SearchRequest
{
    public required HubSpotObjectType ObjectType { get; set; }
    [JsonPropertyName("limit")] public int Limit { get; set; } = 100;
    [JsonPropertyName("after")] public string? After { get; set; }
    [JsonPropertyName("properties")] public required string[] Properties { get; set; }
    [JsonPropertyName("filterGroups")] public required SearchRequestFilterGroup[] FilterGroups { get; set; }
}