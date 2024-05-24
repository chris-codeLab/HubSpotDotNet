using System.Text.Json.Serialization;

namespace HubSpotDotNet.Models;

public class SearchResponse
{
    [JsonPropertyName("total")] public required int Total { get; set; }
    [JsonPropertyName("results")] public required HubSpotResult[] Results { get; set; }
    [JsonPropertyName("paging")] public Paging? Paging { get; set; }
}