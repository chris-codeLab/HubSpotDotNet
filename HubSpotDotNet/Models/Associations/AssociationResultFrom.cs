using System.Text.Json.Serialization;

namespace HubSpotDotNet.Models.Associations;

public class AssociationResultFrom
{
    [JsonPropertyName("id")] public required string Id { get; set; }
}