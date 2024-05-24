using System.Text.Json.Serialization;
using HubSpotDotNet.Models;

namespace HubSpotDotNet.Extensions;

internal static class EnumExtensions
{
    internal static string GetJsonPropertyName(this Enum enumVal)
    {
        var type = enumVal.GetType();
        var memInfo = type.GetMember(enumVal.ToString());
        var attributes = memInfo[0].GetCustomAttributes(typeof(JsonPropertyNameAttribute), false);
        return ((JsonPropertyNameAttribute)attributes[0]).Name;
    }

    internal static HubSpotObjectTypeInfoAttribute GetHubspotObjectType(this Enum enumVal)
    {
        var type = enumVal.GetType();
        var memInfo = type.GetMember(enumVal.ToString());
        var attributes = memInfo[0].GetCustomAttributes(typeof(HubSpotObjectTypeInfoAttribute), false);
        return ((HubSpotObjectTypeInfoAttribute)attributes[0]);
    }
}