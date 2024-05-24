using System.Text.Json.Serialization;

namespace HubSpotDotNet.Models;

public class Paging
{
    [JsonPropertyName("next")] public Next? Next { get; set; }
}