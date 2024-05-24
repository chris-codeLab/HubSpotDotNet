using System.Text.Json.Serialization;

namespace HubSpotDotNet.Models;

public class Next
{
    [JsonPropertyName("after")] public string? After { get; set; }
}