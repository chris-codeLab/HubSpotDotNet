using System.Text.Json.Serialization;

namespace HubSpotDotNet.Models.Associations;

public class AssociationResultToAssociationType
{
    [JsonPropertyName("category")] public required string Category { get; set; }
    [JsonPropertyName("typeId")] public required long TypeId { get; set; }
    [JsonPropertyName("label")] public string? Label { get; set; }
}