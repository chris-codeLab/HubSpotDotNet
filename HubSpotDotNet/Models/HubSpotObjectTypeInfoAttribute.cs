namespace HubSpotDotNet.Models;

internal class HubSpotObjectTypeInfoAttribute(string associationName, string urlPathName) : Attribute
{
    public string AssociationName { get; } = associationName;
    public string UrlPathName { get; } = urlPathName;
}