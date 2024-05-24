using System.Text.Json.Serialization;

namespace HubSpotDotNet.Models;

public class IdInput
{
    [JsonPropertyName("id")] public required string Id { get; set; }
}