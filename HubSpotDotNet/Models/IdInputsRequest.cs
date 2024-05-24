using System.Text.Json.Serialization;

namespace HubSpotDotNet.Models;

public class IdInputsRequest
{
    [JsonPropertyName("inputs")] public required IdInput[] Inputs { get; set; }
}