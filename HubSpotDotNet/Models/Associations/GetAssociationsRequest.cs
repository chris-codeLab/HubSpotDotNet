namespace HubSpotDotNet.Models.Associations;

public class GetAssociationsRequest(HubSpotObjectType fromObject, HubSpotObjectType toObject, IEnumerable<string> fromObjectIds)
{
    public HubSpotObjectType FromObject { get; } = fromObject;
    public HubSpotObjectType ToObject { get; } = toObject;
    public IEnumerable<string> FromObjectIds { get; } = fromObjectIds;
}