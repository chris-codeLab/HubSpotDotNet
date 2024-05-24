using System.Text.Json.Serialization;

namespace HubSpotDotNet.Models;

public class SearchRequestFilterGroup
{
    [JsonPropertyName("filters")] public required SearchRequestFilter[] Filters { get; set; }
}