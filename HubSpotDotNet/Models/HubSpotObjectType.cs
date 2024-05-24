namespace HubSpotDotNet.Models;

public enum HubSpotObjectType
{
    [HubSpotObjectTypeInfo("Deal", "deals")] Deal,
    [HubSpotObjectTypeInfo("Company", "companies")] Company
}