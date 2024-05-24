using System.Text.Json.Serialization;

namespace HubSpotDotNet.Models.Associations;

public class AssociationResponse
{
    [JsonPropertyName("status")] public required string Status { get; set; }
    [JsonPropertyName("results")] public required AssociationResult[] Results { get; set; }

    [JsonPropertyName("numErrors")] public int NumberOfErrors { get; set; }
    //todo - errors
    //todo - startedAt
    //todo - completedAt
}