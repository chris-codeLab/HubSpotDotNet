using System.Text.Json.Serialization;

namespace HubSpotDotNet.Models.Associations;

public class AssociationResult
{
    [JsonPropertyName("from")] public required AssociationResultFrom From { get; set; }
    [JsonPropertyName("to")] public required AssociationResultTo[] To { get; set; }
}