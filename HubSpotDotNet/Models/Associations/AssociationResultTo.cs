using System.Text.Json.Serialization;

namespace HubSpotDotNet.Models.Associations;

public class AssociationResultTo
{
    [JsonPropertyName("toObjectId")] [JsonInclude] private long? ToObjectIdInternal { get; set; }
    [JsonPropertyName("associationTypes")] public required AssociationResultToAssociationType[] AssociationTypes { get; set; }
    public string ToObjectId => ToObjectIdInternal!.Value.ToString();
}